using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_7._1._1_zbroj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj x: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesite broj y: ");
            float y = float.Parse(Console.ReadLine());

            Zbroj(x,y);
            Console.ReadKey();

        }

       static void Zbroj (float x, float y)
        {
            Console.WriteLine("x + y = {0}", x + y);
        }
    }
}
