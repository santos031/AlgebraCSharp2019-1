using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_11._1._3_automobil
{
    class Automobil
    {
        private string marka;
        private string model;
        private int zapremina;

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int Zapremina { get => zapremina; set => zapremina = value; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool unos = true;
            List<Automobil> auti = new List<Automobil>();

            while (unos)
            {
                auti.Add(UnosAutomobila());

                Console.WriteLine("Zelite li upisati novi automobil (d/n)?");
                unos = Console.ReadLine().ToLower() == "d";
            }

            List<string> modeliVelikeZapremine = (from auto in auti
                                                  orderby auto.Model
                                                  where auto.Zapremina > 1600
                                                  select auto.Model).ToList();
            Console.Write("Automobili sa zapreminom većom od 1600 su: ");

            foreach  (string model in modeliVelikeZapremine)
            {
                Console.WriteLine("{0}, ", model);
            }
            Console.ReadKey();
        }

        private static Automobil UnosAutomobila()
        {
            Automobil auto = new Automobil();

            Console.WriteLine("Unesite marku automobila:");
            auto.Marka = Console.ReadLine();

            Console.WriteLine("Unesite model automobila:");
            auto.Model = Console.ReadLine();

            Console.WriteLine("Unesite zapreminu automobila:");
            auto.Zapremina = int.Parse(Console.ReadLine());

            return auto;
        }
    }
}
