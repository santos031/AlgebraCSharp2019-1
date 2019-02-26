using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5__2_7_dobar_broj_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj: ");
            int a=0;
            try
            {

                a = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Provjeri je li unešen broj?" + e.ToString());

            }
                if (a % 4 == 0 && a >= 100)
                {
                    Console.WriteLine("Broj je djeljiv sa 4 i nije manji od 100");
                }
                else
                {
                    Console.WriteLine("Broj NIJE dobar.");
                }
           
            Console.ReadKey();
        }
    }
}
