using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NummernAnzeige
{
    public class Uhr
    {

        private Nummeranzeige stunden, minuten, sekunden;
        private string zeitSek, zeitMin, zeitStun;
        public Uhr()
        {
            stunden = new Nummeranzeige(23);
            minuten = new Nummeranzeige(59);
            sekunden = new Nummeranzeige(59);
        }

        public void setzezeit(int stunden, int minuten, int sekunden)
        {
            if (minuten <= 59 && minuten >= 0 &&
            sekunden <= 59 && sekunden >= 0 &&
            stunden <= 23 && stunden >= 0)
            {
                this.minuten.setzewert(minuten);
                this.sekunden.setzewert(sekunden);
                this.stunden.setzewert(stunden);
            }
        }

        public int gibStunde()
        {
            return stunden.ausgabe();
        }

        public int gibMinuten()
        {
            return minuten.ausgabe();
        }

        public int gibSekunde()
        {
            return sekunden.ausgabe();
        }

        public string gibuhrzeit()
        {
                 zeitSek = gibSekunde().ToString("D2");
                 zeitMin = gibMinuten().ToString("D2");
                 zeitStun = gibStunde().ToString("D2");

            
            return zeitStun + ":" + zeitMin + ":" + zeitSek;
        }

        public void erhoeheUhrzeit()
        {
            sekunden.erhoeung();
            if (sekunden.ausgabe() == 0)
            {
                minuten.erhoeung();
                if (minuten.ausgabe() == 0)
                {
                    stunden.erhoeung();
                }
            }
        }
    }
}
