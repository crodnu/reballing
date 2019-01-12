using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace leervolt
{

public partial class MainProgramForm : Form
{
    private bool IsPaused = false;
    private bool HasStartedReballing = false;
    private double rt = 0;

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

    private ChipConfiguratonData chipConfiguratonData;

    public MainProgramForm()
    {
        InitializeComponent();
        string[] puertos = SerialPort.GetPortNames();
        foreach (String mostrar in puertos)
        {
            portComboBox.Items.Add(mostrar);
        }
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
        }
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

        // arr[13] unused
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

        temperatureChart.Series[0].Points.AddXY(rt, ControlTemperature);
        temperatureChart.Series[1].Points.AddXY(rt, LowerProbeTemperature);
        temperatureChart.Series[2].Points.AddXY(rt, UpperProbeTemperature);

        controlTemperatureLabel.Text = ControlTemperatureStr + "°C";
        lowerProbeTemperature.Text = LowerProbeTemperatureStr + "°C";
        upperProbeTemperature.Text = UpperProbeTemperatureStr + "°C";
    }

    private void arduinoPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
    {
        if (HasStartedReballing)
        {
            LoadDataFromPort();
            UpdateGUI();
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
        arduinoPort.WriteLine("7");
        runningIndicator.Visible = true;
        startButton.Image = pictureBox13.Image;
        pauseButton.Image = pictureBox16.Image;
        exitButton.Visible = false;
        HasStartedReballing = true;
    }

    private void pauseButton_Click(object sender, EventArgs e)
    {
        arduinoPort.WriteLine("9");
        runningIndicator.Visible = false;
        pauseButton.Image = pictureBox15.Image;
        exitButton.Visible = false;
        startButton.Image = pictureBox14.Image;
    }

    private void sendDataButton_Click(object sender, EventArgs e)
    {
        string messageToSend = 
            chipConfiguratonData.InitialTargetTemperature + ","
            + chipConfiguratonData.FirstPlateauTemperature + ","
            + chipConfiguratonData.SecondPlateauTemperature + ","
            + chipConfiguratonData.DamageTemperarure + ","
            + chipConfiguratonData.FirstPlateauDuration + ","
            + chipConfiguratonData.SecondPlateauDuration + ",";

        arduinoPort.Write(messageToSend);

        ReballingButtonsControl.Enabled = true;
        sendDataButton.Hide();
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        rt += timer.Interval / 1000.0;
    }

    private void selectChipButton_Click(object sender, EventArgs e)
    {
        SelectChipDialog selectChipDialog = new SelectChipDialog();
        DialogResult res = selectChipDialog.ShowDialog();
        if (res == DialogResult.OK)
        {
            chipConfiguratonData = selectChipDialog.data;
            portComboBox.Visible = true;
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
}

}
