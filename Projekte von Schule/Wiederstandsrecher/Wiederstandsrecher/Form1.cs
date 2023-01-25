using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wiederstandsrecher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R1, R2, r;
            string auswahl = comboBox1.Text;

            R1= Convert.ToDouble(textBox1.Text);
            R2= Convert.ToDouble(textBox2.Text);

            switch (auswahl) { 
            
                case "Parallelschaltung":
                    r = R1 * R2 / (R1 + R2);
                    label4.Text = "Der Wiederstand ist " + r +" Ohm";
                    break;

                case "Reihenschaltung":
                    r = R1 + R2;
                    label4.Text = "Der Wiederstand ist " + r + " Ohm"; 
                    break;

                default:
                    label4.Text = "Fehler!!! Bitte wählen sie Parallel oder Reihenschaltung aus";
                    break;
            }
        }
    }
}
