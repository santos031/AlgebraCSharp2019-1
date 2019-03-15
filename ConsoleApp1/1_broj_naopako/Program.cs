using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_broj_naopako
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Unesite prirodan broj");
            string broj = Console.ReadLine();

            char[] znamenkeArray = broj.ToCharArray();
            Array.Reverse(znamenkeArray);
            Console.WriteLine("Ispis znamenki naopako: ");
            Console.WriteLine(znamenkeArray);


            Console.ReadKey();

        }
    }
}