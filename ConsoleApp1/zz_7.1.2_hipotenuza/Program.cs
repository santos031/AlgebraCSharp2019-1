using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_7._1._2_hipotenuza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite 1. katetu: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesite 2. katetu: ");
            float b = float.Parse(Console.ReadLine());

            Hipotenuza(a, b);
            Console.ReadKey();

        }

        static void Hipotenuza(float a, float b)
        {
            Console.WriteLine("Hipotenuza = {0}", Math.Sqrt(a*a + b*b));
        }
    }
}
