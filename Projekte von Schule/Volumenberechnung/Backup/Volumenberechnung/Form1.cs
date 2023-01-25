using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Volumenberechnung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string auswahl;
            double v, k, a, b, c;

            auswahl = comboBox1.Text;

            switch (auswahl)
            {
                case "Wuerfel":
                    {
                        k = Convert.ToDouble(textBox1.Text);

                        v = Volumina.Wuerfel (k);

                        label7.Text = v.ToString("F2"); break;
                    }

                case "Quader":
                    {
                        a = Convert.ToDouble(textBox2.Text);
                        b = Convert.ToDouble(textBox3.Text);
                        c = Convert.ToDouble(textBox4.Text);

                        v = a * b * c;

                        label7.Text = v.ToString("F2"); break;
                    }
            }
        }
        
    }
}

       