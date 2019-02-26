using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5_2_9_cjelobrojno_dijeljenje
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Unesite prirodan broj: ");
                int a = 0;
                try
                {

                    a = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Provjeri je li unešen broj?" + e.ToString());

                }
                if (a % 2 == 0)
                {
                    Console.WriteLine("Broj je paran.");
                }
                if (a % 3 == 0)
                {
                    Console.WriteLine("Broj je dijeljiv sa 3.");
                }
                else
                {
                Console.WriteLine("Broj {0} nije dijeljiv sa 3, ostatak je {1}.", a, (a % 3));
                }
            Console.ReadKey();
           
        }
    }
}
