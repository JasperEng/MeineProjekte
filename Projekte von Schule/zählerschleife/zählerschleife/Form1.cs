using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zählerschleife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long erg, g;
            try
            {
                g = Convert.ToInt64(textBox1.Text);
                erg = 1;

                for (int i = 1; g >= i; i++)
                {

                    erg = erg * i;
                }

                label3.Text = erg.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + " überprüfen Sie die Einagbe!", "Fehler!!"); 
            }
        }
    }
}
