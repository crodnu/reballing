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
    public partial class Curva3 : Form
    {
        public string temp12;
        public string temp11;
        public string temp13;
        public string temp14;
        public string tiempo11;
        public string tiempo12;
        public Curva3()
        {
            InitializeComponent();
        }

        private void Curva3_Load(object sender, EventArgs e)
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
    }
}
