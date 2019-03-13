using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_ucenik
{
    class Ucenik2
    {
        #region Svojstva

        private string ime = "";
        public string Ime { get => ime; set => ime = value; }

        private string prezime = "";
        public string Prezime { get => prezime; set => prezime = value; }

        private string oib;
        public string Oib { get => oib;  set => oib = value; }

        public string telefon;
        public string Telefon { get => telefon; set => telefon = value; }

        private double racun = 0;
        public double Racun { get => racun; set => racun = value; }

        #endregion


        #region Metode

        override
        public string ToString()
        {
            return "Dobar dan " + this.Ime + " " + this.Prezime + "\n Stanje Računa: " + this.StvarnoStanjeRacuna();
        }

        public int getRandomNumber()
        {
            Random random = new Random();
            int rInt = random.Next(2000, 6000);
            return rInt;
        }

        public double StvarnoStanjeRacuna()
        {
            return this.Racun - 900;
        }

        #endregion


        #region Konstruktori

        public Ucenik2() { }

        public Ucenik2(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.racun = getRandomNumber();
        }

        public Ucenik2(string ime, string prezime, string oib)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.Oib = oib;
            this.racun = getRandomNumber();
        }

        public Ucenik2(string ime, string prezime, string oib, double racun)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.Oib = oib;
            this.Racun = racun;

            #endregion
        }
    }
}
