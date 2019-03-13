using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_ucenik
{
    class Ucenik
    {
<<<<<<< HEAD
       
=======

>>>>>>> a4bc292fa5a14f6cef9a63944d5727b1e3d44ee1
        #region Svojstva

        private string ime = "";
        public string Ime { get => ime; }

        private string prezime = "";
        public string Prezime { get => prezime; }

        private string oib;
        public string Oib { set => oib = value; }

        public string telefon;
<<<<<<< HEAD
        public string Telefon { get => telefon; set => telefon = value; }

=======
   
>>>>>>> a4bc292fa5a14f6cef9a63944d5727b1e3d44ee1
        private double racun;
        public double Racun { get => racun; set => racun = value; }

        private static Random random = new Random();

        #endregion


        #region Metode

        override
        public string ToString()
        {
            return "Dobar dan " + this.Ime + " " + this.Prezime + "\n Stanje Računa: " + this.StvarnoStanjeRacuna();
        }

        public int getRandomNumber()
        {
            int rInt = random.Next(2000, 6000);
            return rInt;
        }

        public double StvarnoStanjeRacuna()
        {
            return this.Racun - 900; ///ne radi ok (jer ne ispisuje umanjenje, treba izracun u kreatoru??? )
        }

        #endregion


        #region Konstruktori

        public Ucenik() { }

        public Ucenik(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.racun = getRandomNumber();
        }

        public Ucenik(string ime, string prezime, string oib)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.Oib = oib;
            this.racun = getRandomNumber();
        }

        public Ucenik(string ime, string prezime, string oib, double racun)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.Oib = oib;
            this.Racun = racun;

            #endregion
        }
    }
}
