using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace leervolt
{
    public partial class Form1 : Form
    {
        string dato;
        string dato1;
        string puertoseleccionado;
        public string temp1;
        string temp2;
        string temp3;
        string temp4;
        string temp5;
        string tiempo1;
        string tiempo2;
        string A;
        bool Habilito;
        string Recibidos;
        bool OnOff;
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

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.Dispose();
            startButton.Visible = false;
            pauseButton.Visible = false;
           // button5.Visible = false;
            Close();
            exitButton.Visible = false;
        }
        private void form1_load(object sender, EventArgs e)
        {
            timer1.Start();
       


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.Dispose();
            puertoseleccionado = portComboBox.Text;
            serialPort1.PortName = puertoseleccionado;
            serialPort1.Open();
            CheckForIllegalCrossThreadCalls = false;
            if (serialPort1.IsOpen == true)
            {
                label3.Text = "PUERTO ENCONTRADO";
               
                sendDataButton.Visible = true;
            }
            else
            {
                return;
            }
            OnOff = false;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (OnOff == true)
            {
                //serialPort1.Open();
                dato = serialPort1.ReadLine();
                A = dato;
                Console.WriteLine(A);
                string[] arr = A.Split(new string[] { "|" }, StringSplitOptions.None);
                string b = arr[0];  
                string c = arr[1];
                string d = arr[2];
                string f = arr[3];
                string g = arr[4];
                string k = arr[5];
                string l = arr[6];
                string m = arr[7];
                string n = arr[8];
                string o = arr[9];
                string p = arr[10];
                string q = arr[11];
                string r = arr[12];
                string t = arr[13];
                // double dato1 = Convert.ToDouble(b);
                //double numero = Convert.ToDouble(dato1);
                //double voltaje = Math.Round(((numero * 5) / 1023), 2);

                controlTemperatureLabel.Text = b;
                lowerProbeTemperature.Text = c;
                upperProbeTemperature.Text = d;
                lowerResistanceLabel1.Text = f;
                lowerResistanceLabel2.Text = g;
                lowerResistanceLabel3.Text = k;
                lowerResistanceLabel4.Text = l;
                upperResistanceLabel.Text = m;
                upperFanLabel.Text = o;
                lowerFanLabel.Text = p;
                label21.Text = q;
                label22.Text = r;

                string voltaje = dato;
               // textBox6.Text = b;
                if (i == false)
                {
                    rt = 0;
                    i = true;
                }

                temperatureChart.Series[0].Points.AddXY(rt, b);
                temperatureChart.Series[1].Points.AddXY(rt, c);
                temperatureChart.Series[2].Points.AddXY(rt, d);
                 

            }

        }
        private void Recepcion(object sender, SerialDataReceivedEventArgs e)
        {
            Recibidos += serialPort1.ReadExisting();
            Invoke(new EventHandler(Actualizar));
        }

        private void Actualizar(object sender, EventArgs e)
        {
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(Recepcion);

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // serialPort1.Open();
            serialPort1.WriteLine("7");
            runningIndicator.Visible = true;
            startButton.Image = pictureBox13.Image;
            pauseButton.Image = pictureBox16.Image;
            exitButton.Visible = false;
            Habilito = true;
            OnOff = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           serialPort1.WriteLine("9");
            runningIndicator.Visible = false;
            pauseButton.Image = pictureBox15.Image;
            exitButton.Visible = false;
            startButton.Image = pictureBox14.Image;
            //OnOff = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {



        }



        private void button5_Click(object sender, EventArgs e)
        {
            //serialPort1.Write("Temperaturas[]");
            // textBox1.Text = Curba1.textBox1.Text;
            temp1 = "0" + textBox1.Text;
            temp2 = "0" + textBox2.Text;
            temp3 = "0" + textBox3.Text;
            temp4 = "0" + textBox4.Text;
            tiempo1 = textBox5.Text;
            tiempo2 = textBox6.Text;
            serialPort1.Write(temp1);
            serialPort1.Write(",");
            serialPort1.Write(temp2);
            serialPort1.Write(",");
            serialPort1.Write(temp3);
            serialPort1.Write(",");
            serialPort1.Write(temp4);
            serialPort1.Write(",");
            serialPort1.Write(tiempo1);
            serialPort1.Write(",");
            serialPort1.Write(tiempo2);
            // serialPort1.Close();

            // label6.Text = serialPort1.Read;
            startButton.Visible = true;
            pauseButton.Visible = true;
            sendDataButton.Visible = false;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(Recepcion);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("075");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("085");
        }
        double rt = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            rt = rt + 0.1;
          
           
        }
        Boolean i = false;

        private void button9_Click(object sender, EventArgs e)
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
                button10.Visible = false;
                button11.Visible = false;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
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
                button9.Visible = false;
                button11.Visible = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
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
                button10.Visible = false;
                button9.Visible = false;
            }
        }

        private void label14_TextChanged(object sender, EventArgs e)
        {
            if (lowerResistanceLabel1.Text == "1")
            {
                lowerResistanceIcon1.BackColor = Color.Red;
            }
            if (lowerResistanceLabel1.Text == "0")
            {
                lowerResistanceIcon1.BackColor = Color.White;
            }
        }

        private void label15_TextChanged_1(object sender, EventArgs e)
        {
            if (lowerResistanceLabel2.Text == "1")
            {
                lowerResistanceIcon2.BackColor = Color.Red;
            }
            if (lowerResistanceLabel2.Text == "0")
            {
                lowerResistanceIcon2.BackColor = Color.White;
            }
        }

        private void label16_TextChanged(object sender, EventArgs e)
        {
            if (lowerResistanceLabel3.Text == "1")
            {
                lowerResistanceIcon3.BackColor = Color.Red;
            }
            if (lowerResistanceLabel3.Text == "0")
            {
                lowerResistanceIcon3.BackColor = Color.White;
            }
        }

        private void label17_TextChanged(object sender, EventArgs e)
        {
            if (lowerResistanceLabel4.Text == "1")
            {
                lowerResistanceIcon4.BackColor = Color.Red;
            }
            if (lowerResistanceLabel4.Text == "0")
            {
                lowerResistanceIcon4.BackColor = Color.White;
            }
        }

        private void label18_TextChanged(object sender, EventArgs e)
        {
            if (upperResistanceLabel.Text == "1")
            {
                upperResistanceIcon.BackColor = Color.Red;
            }
            if (upperResistanceLabel.Text == "0")
            {
                upperResistanceIcon.BackColor = Color.White;
            }
        }

    private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("8");
            runningIndicator.Visible = false;
            startButton.Image = pictureBox14.Image;
            pauseButton.Image = pictureBox16.Image;
            OnOff = false;
            exitButton.Visible = true;
        }

       

        private void label20_TextChanged(object sender, EventArgs e)
        {
            if (upperFanLabel.Text == "1")
            {
                upperFanIcon.Visible = false;
                pictureBox8.Visible = true;
               
            }
            if (upperFanLabel.Text == "0")
            {
                pictureBox8.Visible = false;
                upperFanIcon.Visible = true;
               
            }
        }

        private void label24_TextChanged_1(object sender, EventArgs e)
        {
            if (lowerFanLabel.Text == "1")
            {
                
                lowerFanIcon.Visible = true;
                pictureBox12.Visible = false;
            }
            if (lowerFanLabel.Text == "0")
            {
               
                pictureBox12.Visible = true;
                lowerFanIcon.Visible = false;
            }
        }
         
    private void timer2_Tick(object sender, EventArgs e)
        {
            
            
        }
        private void InitializeTimer()
        {
            // Call this procedure when the application starts.  
            // Set to 1 second.  
            timer2.Interval = 3000;
            timer2.Tick += new EventHandler(timer2_Tick);

            // Enable timer.  
            timer2.Enabled = true;
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (controlTemperatureLabel.Text == textBox4.Text)
            {

                finishIndicator.Visible = true;
                
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }

       
    }
