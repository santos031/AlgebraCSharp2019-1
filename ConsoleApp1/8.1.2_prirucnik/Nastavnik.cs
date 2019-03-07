using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2_prirucnik
{
    class Nastavnik
    {
        public string ime = "Antonije Marcus"

        public static string Opis() //svojstva objekta Nastavnik ne mogu dohvacati iz static metode
        {
            return "Nastavnik je osoba koja predaje u obrazovnim ustanovama.";
        }

        public static float Koeficijent()
        {
            return 1.5f;
        }
    }
}
