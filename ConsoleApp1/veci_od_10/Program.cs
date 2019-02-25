using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veci_od_10
{
    class Primjer_5_2_1_1_Veci_od_10
    {
        static void Main()
        {
            Console.Write("Unesi prirodan broj:");
            int a = int.Parse(Console.ReadLine());
            if (a > 10)
            {
                Console.WriteLine("Uneseni broj je veći od 10.");
            }
            else
            {
                Console.WriteLine("Uneseni broj NIJE veći od 10.");
            }
            Console.ReadKey();
        }
    }
}
