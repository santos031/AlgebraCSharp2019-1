using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5._3._1_neparni_do_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ispis svih neparnih brojeva većih od 1, a manjih ili jednakih 20.");
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }
    }
    
}
