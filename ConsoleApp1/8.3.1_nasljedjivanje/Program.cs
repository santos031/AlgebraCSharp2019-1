using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3._1_nasljedjivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik uc1 = new Ucenik();      // Osoba() i Ucenik()
            Ucenik uc2 = new Ucenik("Anica");       // Osoba()
            Ucenik uc3 = new Ucenik("Perica", "Perić" );    // Osoba()

            List<Ucenik> ucenici = new List<Ucenik> { uc1, uc2, uc3 };

            foreach (var item in ucenici)
            {
                Console.WriteLine(item);
            }

            //DODAJ VOZACE
            Vozac vo1 = new Vozac("Luka", "Krilić");
            vo1.Kategorija_a = true;
            vo1.Kategorija_c = true;

            var a1 = new Auto();
            a1.MarkaAutomobila = "Ford";
            var a2 = new Auto();
            a2.MarkaAutomobila = "Mazda";

            vo1.Automobili.Add(a1); ///??????
            vo1.Automobili.Add(a2);

            Vozac vo2 = new Vozac("Niko", "Bulić");
            vo2.Kategorija_b = true;
            vo2.Kategorija_d = true;

            List<Vozac> vozaci = new List<Vozac> { vo1, vo2 };

            foreach (var item in vozaci)
            {
                Console.WriteLine(item);
            }

            Pilot pi1 = new Pilot("Ford", "Roks");
            pi1.Kategorija_b = true;
            pi1.Kategorija_d = true;
            pi1.Kategorija_x = true;

            List<Pilot> piloti = new List<Pilot> { pi1 };

            foreach (var item in piloti)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
