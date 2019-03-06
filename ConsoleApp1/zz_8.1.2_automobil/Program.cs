using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_8._1._2_automobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto();
            

            Console.WriteLine("Unesite marku auta: ");
            a1.MarkaAutomobila = Console.ReadLine();

            Console.WriteLine("Unesite KS vozila: ");
            a1.Ks = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite osnovnu cijenu: ");
            a1.OsnovnaCijena = double.Parse(Console.ReadLine());

    
            Console.WriteLine("Porez je {0}, a ukupna cijena je {1}.", a1.IznosPoreza(), a1.UkupnaCijena());

            Console.ReadKey();
        }
    }
}
