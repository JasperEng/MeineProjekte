using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkhausProjekt
{
	public class Parktarif
	{
		private int preisErsteStunde, preisWeitereStunde;

		public Parktarif(int PreisErsteStunde, int PreisWeitereStunde)
		{
			this.preisErsteStunde = PreisErsteStunde;
			this.preisWeitereStunde = PreisWeitereStunde;
		}

		public int berechneParkkosten(int parkdauer)
		{
			parkdauer = parkdauer - 1;
			return preisErsteStunde + parkdauer * preisWeitereStunde;
		}
	}
}
