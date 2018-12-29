using System;
using System.Diagnostics;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                comboBox1.Items.Add(mostrar);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.Dispose();
            button2.Visible = false;
            button3.Visible = false;
           // button5.Visible = false;
            Close();
        }
        private void form1_load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.Dispose();
            puertoseleccionado = comboBox1.Text;
            serialPort1.PortName = puertoseleccionado;
            serialPort1.Open();
            CheckForIllegalCrossThreadCalls = false;
            if (serialPort1.IsOpen == true)
            {
                label3.Text = "PUERTO ENCONTRADO";
               
                button5.Visible = true;
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
                dato = serialPort1.ReadLine();
                double dato1 = Convert.ToDouble(dato);
                double numero = Convert.ToDouble(dato1);
                double voltaje = Math.Round(((numero * 5) / 1023), 2);
                label4.Text = voltaje.ToString();
                //textBox6.Text = SerialPort1.ReadLine();
                if (i == false)
                {
                    rt = 0;
                    i = true;
                }

                chart1.Series[0].Points.AddXY(rt, voltaje);
                label6.Text = serialPort1.ReadLine();
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
            serialPort1.WriteLine("065");
            pictureBox1.Visible = true;
            Habilito = true;
            OnOff = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("066");
            pictureBox1.Visible = false;
            OnOff = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {



        }



        private void button5_Click(object sender, EventArgs e)
        {
            //serialPort1.Write("Temperaturas[]");
            // textBox1.Text = Curba1.textBox1.Text;
            temp1 = textBox1.Text;
            temp2 = textBox2.Text;
            temp3 = textBox3.Text;
            temp4 = textBox4.Text;
            temp5 = textBox5.Text;

            serialPort1.Write(temp1);
            serialPort1.Write(",");
            serialPort1.Write(temp2);
            serialPort1.Write(",");
            serialPort1.Write(temp3);
            serialPort1.Write(",");
            serialPort1.Write(temp4);
            serialPort1.Write(",");
            serialPort1.Write(temp5);

            // label6.Text = serialPort1.Read;
            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

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
            label8.Text = rt.ToString();
        }
        Boolean i = false;

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

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
                comboBox1.Visible = true;
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
                comboBox1.Visible = true;
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
                comboBox1.Visible = true;
                button10.Visible = false;
                button9.Visible = false;
            }
        }
    }
}

      
