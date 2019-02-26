using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5_2_3_veliki_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj: ");
            int a = int.Parse(Console.ReadLine());

            if (a > 99)
            {
                Console.WriteLine("Broj je velik.");
            }
            else
            {
                Console.WriteLine("Broj NIJE velik.");
            }
            Console.ReadKey();
        }
    }
}
