using System;

namespace _8._3._1_nasljedjivanje
{
    internal class Auto
    {
        public string MarkaAutomobila = "";
        public double Ks;
        public double OsnovnaCijena;

        internal double IznosPoreza()
        {
            double porez = 0;
            if (Ks < 50)
            {
                porez = 5;
            }
            else if (Ks > 50 && Ks < 150 )
            {
                porez = 10;
            }
            else
            {
                porez = 15;
            }
            return OsnovnaCijena * (porez/100);
        }

        internal double UkupnaCijena()
        {
            double cijenaTotal= 0;
            cijenaTotal = OsnovnaCijena + IznosPoreza();
            return cijenaTotal;
        }

    }
}