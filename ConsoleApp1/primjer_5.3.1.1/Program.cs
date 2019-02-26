using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primjer_5._3._1._1
{
    class Primjer_5_3_1_1_FOR
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. ALGEBRA", (i + 1).ToString());
            }

             Console.WriteLine("\n\n####   TABLICA MNOŽENJA    ####");
             Console.WriteLine("\n\n");
             for (int i = 1; i < 10; i++)
                {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0}\t", (i*j).ToString());
                }
                }
             Console.ReadKey();
        }
    }
}
