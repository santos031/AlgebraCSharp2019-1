using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_klasa_automobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil a1 = new Automobil();
            
            Console.WriteLine("Unesiten naziv auta: ");
            a1.naziv = Console.ReadLine());

            Console.WriteLine("Unesite osnovnu cijenu vozila: ");
            a1.osnovnaCijena = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite godinu proizvodnje auta: ");
            a1.godinaProizvodnje = int.Parse(Console.ReadLine());


            Console.Write("Ukupna cijena je: " + ukupnaCijena(double.Parse(Console.ReadLine()));
        }
    }
}
