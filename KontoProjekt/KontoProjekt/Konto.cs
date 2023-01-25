using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoProjekt
{

    public class Konto
    {
        private int kontoNr, saldo;
        private String auszug = "";
        
        public Konto(int neuekontoNr)
        {
            kontoNr = neuekontoNr;
            saldo = 0;
        }

        public int gibkontoNr()
        {
            return kontoNr;
        }

        public int gibSaldo()
        {
            return saldo;
        }

        private void updateKonto(int geld, Boolean einzahlung)
        {
            String einAuszahlung;
            if (einzahlung)
            {
                einAuszahlung = "eingezahlt";
            }
            else
            {
                einAuszahlung = "ausgezahlt";
            }
            auszug = auszug + geld + " € " + einAuszahlung + " aktuellerkontostand: " + saldo + "€ " + ", ";
        }

        public void einzahlen(int geld)
        {
            pruefung(geld);
            saldo = saldo + geld;
            updateKonto(geld, true);
        }

        public void auszahlen(int geld)
        {
            pruefung(geld);
            if (saldo >= geld)
            {
                saldo = saldo - geld;
                updateKonto(geld, false);
            }
        }

        private void pruefung(int geld)
        {
            int zw = geld % 5;
            if (saldo >= 0)
            {
                if (geld < 0 && zw == 0)
                {
                    geld = 0;
                }
            }
        }

        public String kontoauszug()
        {
            return auszug;
        }

    }
}
