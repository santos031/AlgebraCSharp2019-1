using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5._3._7_7_3_ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brojevi iz intervala [1,100] djeljivi sa 7, ali ne i sa 3 su:");
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 7 == 0) && !(i % 3 == 0))
                {
                    Console.Write("{0} ", i.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
