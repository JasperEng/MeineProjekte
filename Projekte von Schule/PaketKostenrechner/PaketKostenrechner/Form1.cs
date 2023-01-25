using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PaketKostenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Kg, cO;

            Kg = Convert.ToDouble(textBox1.Text);

            if(Kg <= 5){
            cO= 7;
            
            label3.Text= cO.ToString()+ " €";
            } else 
             
            if(Kg <= 10){
                cO = 10.5;

                label3.Text =cO.ToString() + " €";
            }else

                if (Kg <= 20)
                {
                    cO = 14;

                    label3.Text =  cO.ToString() + " €";
                }
                else {
                    label3.Text = "Übergweicht, Paket in Ablage 1";
                }
        }
    }
}
