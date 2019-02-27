using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5._3._13_min_max
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int broj;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Unesite {0}. prirodni broj:", i.ToString());
                broj = int.Parse(Console.ReadLine());

                if (broj < min)
                {
                    min = broj;
                }
                if (broj > max)
                {
                    max = broj;
                }
            }
            Console.WriteLine("Najmanji = {0} \n Najveći = {1}", min, max);
            Console.ReadKey();
        }
    }
}
