﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_8._1._3_zaposlenik
{
    class Zaposlenik
    {
        #region Svojstva

        public string ime = "";
        public string Ime { get => ime; set => ime = value; }

        private string prezime = "";
        public string Prezime { get => prezime; set => prezime = value; }

        private string jmbg;
        public string Jmbg { get => jmbg; set => jmbg = value; }

        private double brojBodova;
        public double BrojBodova { get => brojBodova; set => brojBodova = value; }

        private double vrijednostBoda;
        public double VrijednostBoda { get => vrijednostBoda; set => vrijednostBoda = value; }

        public double Porez
        {
            get
            {
                double neto = this.NetoIzracunPlace();
                if (neto < 3000)
                {
                    return neto * 0.06;
                }
                else if (neto < 6000)
                {
                    return neto * 0.12;
                }
                else
                {
                    return neto * 0.2;
                }
            }
        }

        #endregion


        #region Metode

        public double NetoIzracunPlace()
        {
            return this.BrojBodova * this.VrijednostBoda;
        }

        public double BrutoIzracunPlace()
        {
            return this.NetoIzracunPlace() + this.porez;
        }

        #endregion


        #region Konstruktori

        public Zaposlenik() { }

        public Zaposlenik(string ime, string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
        }

        public Zaposlenik(string ime, string prezime, string jmbg) //moguc dodatak :this(ime, prezime) pa se ne mora dvaput izraditi konstruktor
        {
            this.Ime = ime;             //u tom slucaju prva dva reda u tijelu ne treba ponovno navoditi (ime, prezime)
            this.Prezime = prezime;     //preuzima ih iz prethodnog konstruktora (fallthrow)
            this.Jmbg = jmbg;
        }

        #endregion

    }
}
