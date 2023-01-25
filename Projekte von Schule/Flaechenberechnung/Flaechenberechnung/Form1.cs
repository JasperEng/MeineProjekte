using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flaechenberechnung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, erg;

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            erg = Flaechen.Rechteck(a, b);

            label4.Text = erg.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, erg;

            a = Convert.ToDouble(textBox3.Text);


            erg = Flaechen.Quadrat(a);

            label8.Text = erg.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double r, erg;

            r = Convert.ToDouble(textBox4.Text);
            

            erg = Flaechen.Kreis(r);

            label10.Text = erg.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double r, erg;

            r = Convert.ToDouble(textBox5.Text);

            erg = Flaechen.Kugeloberfläche(r);

            label13.Text = erg.ToString();
        }
    }
}
