using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zuwachssparen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Zinsen, kapital, zIst, Jahr;
            try
            {

                kapital = Convert.ToDouble(textBox1.Text);
                Zinsen = Convert.ToDouble(textBox2.Text);
                zIst = Convert.ToDouble(textBox3.Text);

                listBox1.Items.Clear();

                Jahr = 1;
                    for (int i = 0; i <= 4; i++)
                    {

                        kapital = kapital + (kapital / 100 * Zinsen);

                        Zinsen = Zinsen + zIst;

                        listBox1.Items.Add("Nach " + Jahr.ToString() + " Jahren " + kapital.ToString("F2") + " €" + " Zinssatz:" + Zinsen + "%");

                        Jahr++;
                    }
                
            }
            catch (Exception error) {
                MessageBox.Show(error.Message + " Bitte überprüfen Sie ihre eingaben. Nur Zahlen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
