using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flaechenberechnung
{
    class Flaechen
    {
        public static double Rechteck(double a, double b) {

            double erg = a * b;
            return erg;
        }

        public static double Quadrat(double a)
        {

            double erg = a * a;
            return erg;
        }

        public static double Kreis(double r) {

            double erg = Math.PI * r * r;
            return erg;
        }

        public static double Kugeloberfläche(double r)
        {

            double erg = 4 * Math.PI * r * r;
            return erg;
        }
    }
}
