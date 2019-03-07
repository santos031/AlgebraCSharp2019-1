using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2_prirucnik
{
    class Nastavnik
    {
        private string ime = "Antonije Marcus";
        private int oib;

        //read only
        public string Ime { get => ime;}

        //write only
        public int Oib { set => oib = value;}

        //dozvoljava ispis prve 4 znamenke OIBA
        public int PartialOib { get => int.Parse(oib.ToString().Substring(0,3)); }

        public static string Opis() //svojstva objekta Nastavnik ne mogu dohvacati iz static metode
        {
            return "Nastavnik je osoba koja predaje u obrazovnim ustanovama.";
        }
        /// <summary>
        /// Ovo dohvaća koeficijent za izračun plaće
        /// </summary>
        /// <returns>float</returns>
        public static float Koeficijent()
        {
            return 1.5f;
        }

        public override string ToString()
        {
            return "Moje ime je " 
                + this.Ime 
                + "a moj oib je: " 
                + this.PartialOib 
                + "*******";
        }
    }
}
