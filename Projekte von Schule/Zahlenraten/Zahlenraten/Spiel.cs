using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zahlenraten
{
    class Spiel
    {
        

        public static int zufall() {
            Random zufallszahl = new Random();
            int zahl = zufallszahl.Next(0, 3);

            return zahl;
        }

        public static int gewinn(int Z1, int Z2, int Z3, int A1, int A2, int A3) {
            if (Z1 == A1 && Z2 == A2 && Z3 == A3) {
                int erg;
                return erg;
            }
            else if (Z1 == A1 && Z2 == A2 || Z3 == A3 || Z2 == A2 && Z1 == A1 || Z2 == A3 || Z3 == A3 && Z2 == A2 || Z1 == A1) {
                int erg;
                return erg;
            }
        }
    }
}
