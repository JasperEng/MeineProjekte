namespace NummernAnzeige
{
    public partial class Form1 : Form
    {
        Uhr uhr;
        Weckstopuhr weckUhr;

        bool stoppuhrAn = false, weckerAn = true;

        public Form1()
        {
            InitializeComponent();
            uhr = new Uhr();
            weckUhr = new Weckstopuhr();
        }
        //setze Zeit
        private void buttonZeit_Click(object sender, EventArgs e)
        {
            try
            {
                string setzeUhr = textBoxSetzeZeit.Text;
                uhr.setzezeit(Convert.ToInt32(setzeUhr.Substring(0, 2)), Convert.ToInt32(setzeUhr.Substring(3, 2)), Convert.ToInt32(setzeUhr.Substring(6, 2)));
                uhrLabel.Text = uhr.gibuhrzeit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Fehler");
            }
            
        }
        //auto tick in 1 sekunde
        private void timer1_Tick(object sender, EventArgs e)
        {
            uhr.erhoeheUhrzeit();
            uhrLabel.Text = uhr.gibuhrzeit();
            weckUhr.erhoehzeit();
            Stopplabel.Text = weckUhr.stopuhrGibzeit();
            ueberpruefe();
        }
        //stoppuhr an oder aus
        private void buttonStoppAnAus_Click(object sender, EventArgs e)
        {
           if(stoppuhrAn)
            {
                
                weckUhr.stopUhraus();
                stoppuhrAn = false;
            }
            else 
            {
                weckUhr.stopUhrstarten();
                stoppuhrAn = true;
            }
        }
        //stopp uhr reset
        private void buttonStoppReset_Click(object sender, EventArgs e)
        {
            weckUhr.Reseten();
            Stopplabel.Text = weckUhr.stopuhrGibzeit();
        }
        // stelle Wecker
        private void buttonSetzeWecker_Click(object sender, EventArgs e)
        {
            string setzeUhr = textBoxWecker.Text;
            weckUhr.weckerstellen(Convert.ToInt32(setzeUhr.Substring(0, 2)), Convert.ToInt32(setzeUhr.Substring(3, 2)), Convert.ToInt32(setzeUhr.Substring(6, 2)));
            label4.Text = "Wecker an";
            weckerAn = true;
        }
        //überprüft ob wecker alarm gibt
        private void ueberpruefe()
        {
            if(weckUhr.alarm())
            {
                label1.Text = "ALARM!!!!!!";
            }
            else
            {
                label1.Text = "";
            }
        }
        // schlummer modus
        private void buttonSchlummer_Click(object sender, EventArgs e)
        {
            weckUhr.schlummermodus();
        }
        //test
        private void button1_Click(object sender, EventArgs e)
        {
            //string setzeUhr = textBox1.Text;
            //weckUhr.setzteuhrzeit(Convert.ToInt32(setzeUhr.Substring(0, 2)), Convert.ToInt32(setzeUhr.Substring(3, 2)), Convert.ToInt32(setzeUhr.Substring(6, 2)));
            
        }

        private void buttonAlarmAus_Click(object sender, EventArgs e)
        {
            weckUhr.alarmaus();
        }


        // Wecker an oder aus
        private void buttonWeckerAnAus_Click(object sender, EventArgs e)
        {
            if(!weckerAn)
            {
                weckUhr.weckeran();
                weckerAn = true;
                label4.Text = "Wecker an";
            }
            else
            {
                weckUhr.weckeraus();
                weckerAn = false;
                label4.Text = "Wecker aus";
            }
        }
    }
}