using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NummernAnzeige
{

    public class Weckstopuhr
    {
        private Uhr stopuhr, uhr, weckuhr;
        bool stopUhrAn, weckerAn, alarmAn, ukWechsel, wechsel;
        int restzeit, schlumm;

        public Weckstopuhr()
        {
            stopuhr = new Uhr();
            uhr = new Uhr();
            weckuhr = new Uhr();
            stopUhrAn = false;
            weckerAn = false;
            alarmAn = false;
            ukWechsel = false;
            wechsel = true;
            restzeit = 0;
            schlumm = 0;
        }

       /* public void ukAn()
        {
            ukWechsel = true;
        }

        public void ukAus()
        {
            ukWechsel = false;
        }*/

        public void schlummermodus()
        {
            if (alarmAn)
            {
                alarmAn = false;
                schlumm++;
                for (int i = 0; i < 300; i++)
                {
                    weckuhr.erhoeheUhrzeit();
                }
            }
        }

        private void schlumernzuruck()
        {
            for (int i = 0; i < 60 * 60 * 24 - 5 * 60 * schlumm; i++)
            {
                weckuhr.erhoeheUhrzeit();
            }
            schlumm = 0;
        }


        public void weckeran()
        {
            weckerAn = true;
        }

        public void weckeraus()
        {
            weckerAn = false;
            alarmaus();
        }

        public void alarmaus()
        {
            alarmAn = false;
            schlumernzuruck();
        }

        public void weckerstellen(int stunden, int minuten, int sekunden)
        {
            weckuhr.setzezeit(stunden, minuten, sekunden);
            weckerAn = true;
        }

        private void ueberprufealarm()
        {
            if (weckuhr.gibuhrzeit().Equals(uhr.gibuhrzeit()))
            {
                alarmAn = true;
            }
        }

        public bool alarm()
        {
            bool alarm = false;
            if(alarmAn)
            {
                alarm = true;
            }
            return alarm;
        }
        //stopp Uhr
        public void stopUhrstarten()
        {
            stopUhrAn = true;
        }

        public void stopUhraus()
        {
            stopUhrAn = false;
        }

        public void Reseten()
        {
            if (stopUhrAn == false)
            {
                stopuhr.setzezeit(0, 0, 0);
            }
        }

        public String stopuhrGibzeit()
        {
            return stopuhr.gibuhrzeit();
        }

        public void erhoehzeit()
        {
            uhr.erhoeheUhrzeit();
            /*if (ukWechsel)
            {
                if (uhr.gibuhrzeit().Equals("12:00:00"))
                {
                    wechsel = true;
                    if (wechsel)
                    {
                        wechsel = false;
                    }
                }
            }*/
            if (stopUhrAn)
            {
                stopuhr.erhoeheUhrzeit();
            }
            if (weckerAn)
            {
                ueberprufealarm();
            }
        }

        public void setzteuhrzeit(int stunden, int minuten, int sekunden)
        {
            uhr.setzezeit(stunden, minuten, sekunden);
        }



        public String gibzeit()
        {
            String zeit = uhr.gibuhrzeit();
            /*if (ukWechsel)
            {
                zeit = (uhr.gibStunde() - 12) + ":" +
                        uhr.gibMinuten() + ":" +
                        uhr.gibSekunde() + "PM";
            }*/
            return zeit;
        }
    }

}
