using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leervolt
{
    public partial class Curva1 : Form
    {
        
        public string temp12;
        public string temp11;
        public string temp13;
        public string temp14;
        public string tiempo11;
        public string tiempo12;
        public Curva1()
        {
            InitializeComponent();
        }

        private void Curba1_load(Object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            temp11 = textBox1.Text;
            temp12 = textBox2.Text;
            temp13 = textBox3.Text;
            temp14 = textBox4.Text;
            tiempo11 = textBox5.Text;
            tiempo12 = textBox6.Text;
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}