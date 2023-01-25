using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restwert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Preis, restwert, zeit;

            try
            {

                restwert = Convert.ToDouble(textBox2.Text);
                Preis = Convert.ToDouble(textBox1.Text);

                zeit = 0;

                while (restwert < Preis)
                {

                    if (zeit < 1)
                    {
                        Preis = Preis - (Preis / 100 * 15);
                        zeit++;
                        label5.Text = zeit.ToString();

                    }
                    else if (zeit < 5)
                    {
                        Preis = Preis - (Preis / 100 * 7);
                        zeit++;
                        label5.Text = zeit.ToString();

                    }
                    else if (zeit < 10)
                    {
                        Preis = Preis - (Preis / 100 * 6);
                        zeit++;
                        label5.Text = zeit.ToString();

                    }
                    else
                    {
                        Preis = Preis - (Preis / 100 * 7);
                        zeit++;
                        label5.Text = zeit.ToString();

                    }
                }
            }
            catch(Exception error) {

                MessageBox.Show(error.Message + " Bitte überprüfen Sie ihre Eingabe!", "Fehler");
            }

        }
    }
}
