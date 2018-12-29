using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace leervolt
{

public partial class Form1 : Form
{
    string temp1;
    string temp2;
    string temp3;
    string temp4;
    string tiempo1;
    string tiempo2;

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
    private int IdkWhatThisIs1;
    private int IdkWhatThisIs2;

    //bool OnOff1;
    public Form1()
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

        // arr[8] unused

        UpperFanIsTurnedOn = arr[9] == "1";
        LowerFanIsTurnedOn = arr[10] == "1";

        IdkWhatThisIs1 = Int32.Parse(arr[11]);
        IdkWhatThisIs2 = Int32.Parse(arr[12]);

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

        idkWhatThisIsLabel1.Text = IdkWhatThisIs1.ToString();
        idkWhatThisIsLabel2.Text = IdkWhatThisIs2.ToString();
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
        //serialPort1.Write("Temperaturas[]");
        // textBox1.Text = Curba1.textBox1.Text;
        temp1 = "0" + textBox1.Text;
        temp2 = "0" + textBox2.Text;
        temp3 = "0" + textBox3.Text;
        temp4 = "0" + textBox4.Text;
        tiempo1 = textBox5.Text;
        tiempo2 = textBox6.Text;
        arduinoPort.Write(temp1);
        arduinoPort.Write(",");
        arduinoPort.Write(temp2);
        arduinoPort.Write(",");
        arduinoPort.Write(temp3);
        arduinoPort.Write(",");
        arduinoPort.Write(temp4);
        arduinoPort.Write(",");
        arduinoPort.Write(tiempo1);
        arduinoPort.Write(",");
        arduinoPort.Write(tiempo2);
        
        startButton.Visible = true;
        pauseButton.Visible = true;
        stopButton.Visible = true;
        sendDataButton.Visible = false;
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        rt += timer.Interval / 1000.0;
    }

    private void intelButton_Click(object sender, EventArgs e)
    {
        Curva1 Curva1 = new Curva1();
        DialogResult res = Curva1.ShowDialog();
        if (res == DialogResult.OK)
        {
            textBox1.Text = Curva1.temp11;
            textBox2.Text = Curva1.temp12;
            textBox3.Text = Curva1.temp13;
            textBox4.Text = Curva1.temp14;
            textBox5.Text = Curva1.tiempo11;
            textBox6.Text = Curva1.tiempo12;
            portComboBox.Visible = true;
            xBoxButton.Visible = false;
            otherChipButton.Visible = false;
        }
    }

    private void xBoxButton_Click(object sender, EventArgs e)
    {
        Curva2 Curva2 = new Curva2();
        DialogResult res = Curva2.ShowDialog();
        if (res == DialogResult.OK)
        {
            textBox1.Text = Curva2.temp11;
            textBox2.Text = Curva2.temp12;
            textBox3.Text = Curva2.temp13;
            textBox4.Text = Curva2.temp14;
            textBox5.Text = Curva2.tiempo11;
            textBox6.Text = Curva2.tiempo12;
            portComboBox.Visible = true;
            intelButton.Visible = false;
            otherChipButton.Visible = false;
        }
    }

    private void otherChipButton_Click(object sender, EventArgs e)
    {
        Curva3 Curva3 = new Curva3();
        DialogResult res = Curva3.ShowDialog();
        if (res == DialogResult.OK)
        {
            textBox1.Text = Curva3.temp11;
            textBox2.Text = Curva3.temp12;
            textBox3.Text = Curva3.temp13;
            textBox4.Text = Curva3.temp14;
            textBox5.Text = Curva3.tiempo11;
            textBox6.Text = Curva3.tiempo12;
            portComboBox.Visible = true;
            xBoxButton.Visible = false;
            intelButton.Visible = false;
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

    /*
    private void button6_Click(object sender, EventArgs e)
    {
        arduinoPort.DataReceived += new SerialDataReceivedEventHandler(Recepcion);
    }

    private void button7_Click(object sender, EventArgs e)
    {
        arduinoPort.WriteLine("075");
    }

    private void button8_Click(object sender, EventArgs e)
    {
        arduinoPort.WriteLine("085");
    }

    private void form1_load(object sender, EventArgs e)
    {
        timer.Start();
    }
    */
}

}
