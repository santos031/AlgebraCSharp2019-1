using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_6._2._4_znamenke
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Unesite prirodan broj");
            string broj = Console.ReadLine();

            char[]znamenkeArray = broj.ToCharArray();
            Array.Reverse(znamenkeArray);
            Console.WriteLine("Ispis znamenki naopako: ");
            Console.WriteLine(znamenkeArray);

            //ili ovako:
           //string ulaz_broj = Console.ReadlLine();
           // int broj = int.Parse(ulaz_broj);
           //console.writeline("original: {0} Obrnuti {0}, broj, new string(ulaz_broj.reverse().ToArray)")
           //

            Console.ReadKey();
        }
    }
}
