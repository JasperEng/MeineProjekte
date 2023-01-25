using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace temperaturumrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tk, tc, tf, tempWert;
            string tempEinheit = comboBox1.Text;

            tempWert = Convert.ToDouble(textBox1.Text);

            

            switch (tempEinheit)
            { 
                case "°F":
                    tc = (tempWert - 32) * 5 / 9;
                    tk = (tempWert - 32) * 5 / 9 + 273.15;
                    label2.Text = "= " + tc.ToString("F2") + " °C = " + tk.ToString("F2") + " K"; 

                    break;

                case "K":
                    tc = tempWert - 273.15;
                    tf = (tempWert - 273.15) * 9 / 5 + 32;
                    label2.Text = "= " + tc.ToString("F2") + " °C = " + tf.ToString("F2") + " °F" ;

                    break;

                case "°C":
                    tf = tempWert * 9 / 5 + 32;
                    tk = tempWert + 273.15;
                    label2.Text = "= " + tf.ToString("F2") + " °F = " + tk.ToString("F2") + " K";
                    break;

                default:
                    label2.Text = "Fehler!!! Bitte wählen sie: °F/K/°C";
                    break;
            }
        }
    }
}
