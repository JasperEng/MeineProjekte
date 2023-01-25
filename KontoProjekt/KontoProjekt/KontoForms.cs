namespace KontoProjekt
{
    public partial class KontoForms : Form
    {
        int kontostandt;
        Konto konto;
        
        public KontoForms()
        {
            InitializeComponent();
            konto = new Konto(1);
            kontostandLabel.Text = "0";
            KontoNrTextBox.Text = konto.gibkontoNr().ToString();
            betragLabel.Text = "0";
        }
        

        private void einzahlenButton_Click(object sender, EventArgs e)
        {
            checkZahlung();
            konto.einzahlen(kontostandt);
            reloadGui();
        }
        private void auszahlenButton_Click(object sender, EventArgs e)
        {
            checkZahlung();
            konto.auszahlen(kontostandt);
            reloadGui();
        }

        private void reloadGui()
        { 
            double aktuellkonto = konto.gibSaldo();
            kontostandLabel.Text = aktuellkonto.ToString();   
        }

        private void checkZahlung()
        {
            kontostandt = Convert.ToInt32(betragLabel.Text);
        }

        private void auszugButton_Click(object sender, EventArgs e)
        {
            auszugTextBox.Text = konto.kontoauszug();
        }
    }
}