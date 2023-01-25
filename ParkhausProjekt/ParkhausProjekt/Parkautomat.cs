using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkhausProjekt
{
    public class Parkautomat
    {
        private Parktarif tarif, privattarif;

        private double parkkosten, bestand;

        private bool privatkunde;

        public Parkautomat()
        {
            tarif = new Parktarif(1, 1);
            privattarif = new Parktarif(3, 2);
            parkkosten = 0;
            bestand = 0;
            privatkunde = false;
        }

        public void ErmittleParkkosten(int parkdauer)
        {
            if (privatkunde)
            {
                parkkosten = privattarif.berechneParkkosten(parkdauer);
            }
            else
            {
                parkkosten = tarif.berechneParkkosten(parkdauer);
            }
        }

        public double Gibparkkosten()
        {
            return parkkosten;
        }

        public string GeldEinwerfen(double geld)
        {
            string parkausgabe = "";
            if (parkkosten >= 0.1)
            {
                if (geld == 0.2 || geld == 0.5 || geld == 1 || geld == 2)
                {
                    bestand += geld;
                    parkkosten -= geld;
                    parkausgabe = "Es fehlen noch: ";
                }
            }
            if (parkkosten < 0)
            {
                parkkosten = parkkosten * (-1);
                bestand -= parkkosten;
                parkausgabe = "Sie bekommen zurück: ";
            }
            return parkausgabe + parkkosten.ToString("C");
        }

        public void Privatkunde()
        {
            privatkunde = true;
        }

        public void Geschaeftskunde()
        {
            privatkunde = false;
        }
    }

}
