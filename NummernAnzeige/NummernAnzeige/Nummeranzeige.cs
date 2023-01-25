using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NummernAnzeige
{

    public class Nummeranzeige
    {

        private int max, wert;

        public Nummeranzeige(int max)
        {
            this.max = max;
            wert = 0;
        }

        public int ausgabe()
        {
            return wert;
        }

        public void setzewert(int wert)
        {
            this.wert = wert;
            if (wert > max)
            {
                wert = max;
            }
        }

        public void erhoeung()
        {
            if (wert < max)
            {
                wert = wert + 1;
            }
            else
            {
                wert = 0;
            }
        }
    }

}
