
using System;
namespace _8._1._2_prirucnik
{
    internal class Ucenik
    {
        public string ime = "";
        public DateTime datumNastanka;
        public string prezime = "";
        public int OcjenaizMatematike = 0;
        public int OcjenaizBiologije = 0;
        public int OcjenaizEngleskog = 0;

        public Ucenik()
        {
            this.datumNastanka = DateTime.Now;
        }

        public Ucenik(string v)
        {
            this.ime = v;
        }
        public Ucenik(string v, string prez)
        {
            this.ime = v;
            this.prezime = prez;
        }

        internal double Prosjek()
        {
            double prosjek = 0;
            prosjek = (double)(OcjenaizBiologije + OcjenaizEngleskog + OcjenaizMatematike) / 3;

            return prosjek;
            //throw new NotImplementedException();
        }

        public override string ToString() //gaženje bazne metode
        {
            return "Moje ime je " + this.ime + " a moj prosjek je: " + this.Prosjek();
        }
    }
}