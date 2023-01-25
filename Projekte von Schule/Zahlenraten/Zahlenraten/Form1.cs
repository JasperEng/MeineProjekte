using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zahlenraten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Z1,erg;

            Z1 = Convert.ToInt32(textBox1.Text);

            erg = Spiel.zufall();

            label4.Text = erg.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Z2, erg;

            Z2 = Convert.ToInt32(textBox2.Text);

            erg = Spiel.zufall();

            label5.Text = erg.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Z3, erg;

            Z3 = Convert.ToInt32(textBox3.Text);

            erg = Spiel.zufall();

            label6.Text = erg.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int Z1, Z2, Z3, A1, A2, A3;
        }
    }
}
