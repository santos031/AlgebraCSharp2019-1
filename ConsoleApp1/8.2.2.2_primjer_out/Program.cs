using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._2._2_primjer_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Inicijaliziraj(out a);
            Console.WriteLine("a = {0}", a);

           //inicijalizira varijablu a na unesenu vrijednost, a u slucaju loseg unosa vrijednost je 0
            //Console.WriteLine("Unesite broj:");
            //int.TryParse(Console.ReadLine(), out a);

            Console.ReadKey();
        }

        private static void Inicijaliziraj(out int a)
        {
            a = 1;
        }
    }
}
