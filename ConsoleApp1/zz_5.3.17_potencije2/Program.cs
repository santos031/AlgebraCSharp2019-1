using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5._3._17_potencije2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. i 10. potencija broja 2 su:");

            for (int i = 2; i <= 10; i *= 2)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
        }
    }
}
