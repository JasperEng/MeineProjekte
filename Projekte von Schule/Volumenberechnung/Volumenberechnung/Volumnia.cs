using System;
using System.Collections.Generic;
using System.Text;

namespace Volumenberechnung
{
    class Volumina
    {
        public static double Quader(double seitea, double seiteb, double seitec)
        {
            double volume = seitea * seiteb * seitec;
            return volume;
        }

        public static double Wuerfel(double seitea) 
        {
            double volume = seitea * seitea * seitea;
            return volume;
        }
        public static double Pyramide(double seiteA, double hoehe)
        {
            double volumen = seiteA * seiteA * 1 / 3 * hoehe;
            return volumen;
        }
    }
}
