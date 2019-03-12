
using System;
namespace _8._3._1_nasljedjivanje
{
    internal class Ucenik:Osoba
    {
        // private string ime = "";
        // public DateTime datumNastanka;
        //public string prezime = "";
        public int OcjenaizMatematike = 0;
        public int OcjenaizBiologije = 0;
        public int OcjenaizEngleskog = 0;

        //ovaj radi samo kod direktnog poziva 
        //Ucenik u99 = new Ucenik/
        public Ucenik()
        {
            this.datumNastanka = DateTime.Now;
            Console.WriteLine("Pozvana metoda Ucenik:Ucenik()");
        }

        public Ucenik(string v) : base() //poziva base klasu i preskace metodu datumNastanka
        {
            this.Ime = v;
        }
        public Ucenik(string v, string prez) : this (v) //pozivam istu klasu, a metodu iznad ove
        {
            //this.Ime = v;
            this.prezime = prez;
        }

        internal double Prosjek()
        {
            double prosjek = 0;
            prosjek = (double)(OcjenaizBiologije + OcjenaizEngleskog + OcjenaizMatematike) / 3;

            return prosjek;
            //throw new NotImplementedException();
        }

        public override string ToString() 
        {
            return "Moje ime je " + this.Ime + " a moj prosjek je: " + this.Prosjek();
        }
    }
}