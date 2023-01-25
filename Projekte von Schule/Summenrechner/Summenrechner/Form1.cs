using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Summenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double g, erg, i;

            g = Convert.ToDouble(textBox1.Text);
            i = 0;
            erg = 0;

            while (g > i) {

                i = i + 1;
                erg = erg + 1 + i * i;

            }

            label2.Text = erg.ToString();

        }
    }
}
