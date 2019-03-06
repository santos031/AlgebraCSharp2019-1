using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_7._2._9_prosjek
{
    class Program
    {
        static void OpisOcjene(double n)
        {
            if (n < 2)
            {
                Console.WriteLine("Nedovoljan");
            }
            else if (n < 2.5)
            {
                Console.WriteLine("Dovoljan");
            }
            else if (n < 3.5)
            {
                Console.WriteLine("Dobar");
            }
            else if (n < 4.5)
            {
                Console.WriteLine("Vrlo dobar");
            }
            else if (n >= 4.5)
            {
                Console.WriteLine("Odlican");
            }
        }

        static void Main(string[] args)
        {
            OpisOcjene(4.5);
            Console.Read();
        }
    }
}
