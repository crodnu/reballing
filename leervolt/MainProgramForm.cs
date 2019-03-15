using System;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace leervolt
{

public partial class MainProgramForm : Form
{
    private bool IsPaused = false;
    private bool HasStartedReballing = false;

    private double ControlTemperature;
    private double UpperProbeTemperature;
    private double LowerProbeTemperature;
    private string ControlTemperatureStr;
    private string UpperProbeTemperatureStr;
    private string LowerProbeTemperatureStr;
    private bool UpperFanIsTurnedOn;
    private bool LowerFanIsTurnedOn;
    private readonly bool[] LowerResistancesAreTurnedOn = new bool[4];
    private bool UpperResistanceIsTurnedOn;
    private int currentState = NOT_STARTED_STATE;
    private int lastState = NOT_STARTED_STATE;
    private int statePercentage = 0;
    private Stopwatch sw = new Stopwatch();

    private const int NOT_STARTED_STATE = 0;
    private const int PAUSED_FANS_ON_STATE = 1;
    private const int PAUSED_FANS_OFF_STATE = 2;
    private const int PREHEAT_STATE = 3;
    private const int SOAK_STATE = 4;
    private const int REFLOW_STATE = 5;
    private const int COOLING_STATE = 6;
    private const int FINISHED_STATE = 7;
    private const int EMERGENCY_COOLING_STATE = 8;

    private const int roomTemperature = 25;
    private const int meltingTime = 10;

    private ChipConfiguratonData chipConfiguratonData;

    public MainProgramForm()
    {
        InitializeComponent();
        string[] puertos = SerialPort.GetPortNames();
        foreach (String mostrar in puertos)
        {
            portComboBox.Items.Add(mostrar);
        }

        preheatProgressBar.BarColor = Brushes.ForestGreen;
        soakProgressBar.BarColor = Brushes.DarkOrange;
        reflowProgressBar.BarColor = Brushes.Red;
        coolingProgressBar.BarColor = Brushes.DarkTurquoise;
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
        arduinoPort.Close();
        arduinoPort.Dispose();
        Close();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        arduinoPort.Close();
        arduinoPort.Dispose();
        arduinoPort.PortName = portComboBox.Text;
        arduinoPort.Open();
        CheckForIllegalCrossThreadCalls = false;

        if (arduinoPort.IsOpen)
        {
            label3.Text = "PUERTO ENCONTRADO";
            sendDataButton.Visible = true;
            emergencyCoolingButton.Visible = true;
        }
    }

    private void restartGraph()
    {
        temperatureChart.Series["Sonda de abajo"].Points.Clear();
        temperatureChart.Series["Sonda de arriba"].Points.Clear();

        temperatureChart.Series["Temperatura de precalentamiento"].Points.Clear();
        temperatureChart.Series["Temperatura de activación"].Points.Clear();
        temperatureChart.Series["Temperatura de fundición"].Points.Clear();
        temperatureChart.Series["Temperatura de enfriamiento"].Points.Clear();
    }

    private void onReballingRestarted()
    {
        restartGraph();
    }

    private void LoadDataFromPort()
    {
        string dato = arduinoPort.ReadLine();
        string[] arr = dato.Split(new string[] { "|" }, StringSplitOptions.None);

        ControlTemperature = Double.Parse(arr[0]);
        LowerProbeTemperature = Double.Parse(arr[1]);
        UpperProbeTemperature = Double.Parse(arr[2]);

        ControlTemperatureStr = arr[0];
        LowerProbeTemperatureStr = arr[1];
        UpperProbeTemperatureStr = arr[2];

        LowerResistancesAreTurnedOn[0] = arr[3] == "1";
        LowerResistancesAreTurnedOn[1] = arr[4] == "1";
        LowerResistancesAreTurnedOn[2] = arr[5] == "1";
        LowerResistancesAreTurnedOn[3] = arr[6] == "1";

        UpperResistanceIsTurnedOn = arr[7] == "1";

        UpperFanIsTurnedOn = arr[8] == "0";
        LowerFanIsTurnedOn = arr[9] == "0";

        lastState = currentState;
        currentState = int.Parse(arr[10]);
        statePercentage = int.Parse(arr[11]);
    }
    
    private int getProgressBarValue(int index, int currentState, int progress) { 
        if(index > currentState) return 0;
        if(index < currentState) return 100;
        return Math.Min(progress, 100);
    }

    private void updateProgressBars(int state, int progress) {
        preheatProgressBar.Value = getProgressBarValue(PREHEAT_STATE, state, progress);
        soakProgressBar.Value = getProgressBarValue(SOAK_STATE, state, progress);
        reflowProgressBar.Value = getProgressBarValue(REFLOW_STATE, state, progress);
        coolingProgressBar.Value = getProgressBarValue(COOLING_STATE, state, progress);
    }

    private void updateGraph()
    {
        long time = sw.ElapsedMilliseconds / 1000;

        temperatureChart.Series["Sonda de abajo"].Points.AddXY(time, LowerProbeTemperature);
        temperatureChart.Series["Sonda de arriba"].Points.AddXY(time, UpperProbeTemperature);

        temperatureChart.Series["Temperatura de precalentamiento"].Points.AddXY(time, currentState == PREHEAT_STATE ? ControlTemperature : 0);
        temperatureChart.Series["Temperatura de activación"].Points.AddXY(time, currentState == SOAK_STATE ? ControlTemperature : 0);
        temperatureChart.Series["Temperatura de fundición"].Points.AddXY(time, currentState == REFLOW_STATE ? ControlTemperature : 0);
        temperatureChart.Series["Temperatura de enfriamiento"].Points.AddXY(time, currentState == COOLING_STATE ? ControlTemperature : 0);
        temperatureChart.Series["Enfriamiento de emergencia"].Points.AddXY(time, currentState == EMERGENCY_COOLING_STATE ? ControlTemperature : 0);
    }

    private void UpdateGUI()
    {
        lowerResistanceIcon1.BackColor = LowerResistancesAreTurnedOn[0] ? Color.Red : Color.White;
        lowerResistanceIcon2.BackColor = LowerResistancesAreTurnedOn[1] ? Color.Red : Color.White;
        lowerResistanceIcon3.BackColor = LowerResistancesAreTurnedOn[2] ? Color.Red : Color.White;
        lowerResistanceIcon4.BackColor = LowerResistancesAreTurnedOn[3] ? Color.Red : Color.White;
        
        upperResistanceIcon.BackColor = UpperResistanceIsTurnedOn ? Color.Red : Color.White;

        upperFanOnIcon.Visible = UpperFanIsTurnedOn;
        upperFanOffIcon.Visible = !UpperFanIsTurnedOn;
        lowerFanOnIcon.Visible = LowerFanIsTurnedOn;
        lowerFanOffIcon.Visible = !LowerFanIsTurnedOn;

        controlTemperatureLabel.Text = ControlTemperatureStr + "°C";
        lowerProbeTemperature.Text = LowerProbeTemperatureStr + "°C";
        upperProbeTemperature.Text = UpperProbeTemperatureStr + "°C";
        
        if (currentState == PAUSED_FANS_OFF_STATE || currentState == PAUSED_FANS_ON_STATE) return;
        if (currentState < lastState) onReballingRestarted();

        updateProgressBars(currentState, statePercentage);
        updateGraph();
    }

    private void arduinoPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
    {
        if (HasStartedReballing)
        {
            LoadDataFromPort();
            UpdateGUI();
        }
    }

    private bool isReballingState(int state)
    {
        switch(state) {
            case NOT_STARTED_STATE: return false;
            case PAUSED_FANS_ON_STATE: return false;
            case PAUSED_FANS_OFF_STATE: return false;
            case PREHEAT_STATE: return true;
            case SOAK_STATE: return true;
            case REFLOW_STATE: return true;
            case COOLING_STATE: return true;
            case FINISHED_STATE: return false;
            case EMERGENCY_COOLING_STATE: return true; // To update the time on the graph.
            default: return false;
        }
    }

    private void Recepcion(object sender, SerialDataReceivedEventArgs e)
    {
        Invoke(new EventHandler(Actualizar));
    }

    private void Actualizar(object sender, EventArgs e)
    {
        arduinoPort.DataReceived += new SerialDataReceivedEventHandler(Recepcion);
    }

    private void startButton_Click(object sender, EventArgs e)
    {
        if(!HasStartedReballing) sw.Reset();
        sw.Start();
        arduinoPort.WriteLine("7");
        runningIndicator.Visible = true;
        startButton.Image = pictureBox13.Image;
        pauseButton.Image = pictureBox16.Image;
        exitButton.Visible = false;
        HasStartedReballing = true;
    }

    private void pauseButton_Click(object sender, EventArgs e)
    {
        sw.Stop();
        arduinoPort.WriteLine("9");
        runningIndicator.Visible = false;
        pauseButton.Image = pictureBox15.Image;
        exitButton.Visible = false;
        startButton.Image = pictureBox14.Image;
    }

    private void sendDataButton_Click(object sender, EventArgs e)
    {
        string messageToSend = 
            chipConfiguratonData.SoakTemperature + ","
            + chipConfiguratonData.ReflowTemperature + ","
            + chipConfiguratonData.DamageTemperarure + ","
            + chipConfiguratonData.PreheatDuration + ","
            + chipConfiguratonData.SoakDuration + ","
            + chipConfiguratonData.ReflowDuration + ","
            + chipConfiguratonData.CoolingDuration + ",";

        arduinoPort.Write(messageToSend);

        ReballingButtonsControl.Enabled = true;
        sendDataButton.Hide();
    }

    private void loadChipDataLabels() {
        preheatDurationLabel.Text = (chipConfiguratonData.PreheatDuration / 1000).ToString();
        soakDurationLabel.Text = (chipConfiguratonData.SoakDuration / 1000).ToString();
        reflowDurationLabel.Text = (chipConfiguratonData.ReflowDuration / 1000).ToString();
        coolingDurationLabel.Text = (chipConfiguratonData.CoolingDuration / 1000).ToString();
        soakTemperatureLabel.Text = chipConfiguratonData.SoakTemperature.ToString();
        reflowTemperatureLabel.Text = chipConfiguratonData.ReflowTemperature.ToString();
        damageTemperatureLabel.Text = chipConfiguratonData.DamageTemperarure.ToString();
    }
    
    private void drawChipTemperatureGraph()
    {
        temperatureChart.Series["Curva del chip"].Points.Clear();

        int time = 0;
        temperatureChart.Series["Curva del chip"].Points.AddXY(time, roomTemperature);

        time += chipConfiguratonData.PreheatDuration / 1000;
        temperatureChart.Series["Curva del chip"].Points.AddXY(time, chipConfiguratonData.SoakTemperature);

        time += chipConfiguratonData.SoakDuration / 1000;
        temperatureChart.Series["Curva del chip"].Points.AddXY(time, chipConfiguratonData.SoakTemperature);

        time += meltingTime;
        temperatureChart.Series["Curva del chip"].Points.AddXY(time, chipConfiguratonData.ReflowTemperature);

        time += chipConfiguratonData.ReflowDuration / 1000 - meltingTime;
        temperatureChart.Series["Curva del chip"].Points.AddXY(time, chipConfiguratonData.ReflowTemperature);

        time += chipConfiguratonData.CoolingDuration / 1000;
        temperatureChart.Series["Curva del chip"].Points.AddXY(time, roomTemperature);
    }

    private void selectChipButton_Click(object sender, EventArgs e)
    {
        SelectChipDialog selectChipDialog = new SelectChipDialog();
        DialogResult res = selectChipDialog.ShowDialog();
        if (res == DialogResult.OK)
        {
            chipConfiguratonData = selectChipDialog.data;
            loadChipDataLabels();
            portComboBox.Visible = true;
            temperatureChart.Series["dummy"].Points.Clear();
            int totalReballingTime = (chipConfiguratonData.PreheatDuration + chipConfiguratonData.CoolingDuration + chipConfiguratonData.SoakDuration + chipConfiguratonData.CoolingDuration) / 1000;
            temperatureChart.Series["dummy"].Points.AddXY(totalReballingTime, chipConfiguratonData.DamageTemperarure + 20);
            drawChipTemperatureGraph();
        }
    }

    private void stopButton_Click(object sender, EventArgs e)
    {
        arduinoPort.WriteLine("8");
        runningIndicator.Visible = false;
        startButton.Image = pictureBox14.Image;
        pauseButton.Image = pictureBox16.Image;
        HasStartedReballing = false;
        exitButton.Visible = true;
    }

    private void emergencyCoolingButton_Click(object sender, EventArgs e)
    {
        arduinoPort.WriteLine("6");
        runningIndicator.Visible = false;
        startButton.Image = pictureBox14.Image;
        pauseButton.Image = pictureBox16.Image;
        HasStartedReballing = true;
        exitButton.Visible = true;
    }
}

}
