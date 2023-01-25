namespace ParkhausProjekt
{
    public partial class ParkautomatForms : Form
    {
        int parkdauer;
        string kosten,kunde;

        Parkautomat automat;
        public ParkautomatForms()
        {
            InitializeComponent();
            automat = new Parkautomat();
            comboBox1.Text = "Geschäftskunde";


        }

        private void button20cent_Click(object sender, EventArgs e)
        {
           kosten =  automat.GeldEinwerfen(0.2);
            textBoxAktuBetrag.Text = kosten; 

        }

        private void button50cent_Click(object sender, EventArgs e)
        {
            kosten = automat.GeldEinwerfen(0.5);
            textBoxAktuBetrag.Text = kosten;
        }

        private void button1eur_Click(object sender, EventArgs e)
        {
            kosten = automat.GeldEinwerfen(1);
            textBoxAktuBetrag.Text = kosten;
        }

        private void button2eur_Click(object sender, EventArgs e)
        {
            kosten = automat.GeldEinwerfen(2);
            textBoxAktuBetrag.Text = kosten;
        }

        private void buttonRechnen_Click(object sender, EventArgs e)
        {
           try
           {
                parkdauer = Convert.ToInt32(parkDauerTextBox.Text);
                kunde = comboBox1.Text;
                if (kunde == "Privatkunde")
                {
                    automat.Privatkunde();
                }
                else
                {
                    automat.Geschaeftskunde();
                }
                automat.ErmittleParkkosten(parkdauer);


                textBoxBetrag.Text = automat.Gibparkkosten().ToString("C");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Fehler");
            }


        }


    }
}