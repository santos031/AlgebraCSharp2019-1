using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_7._2._8_faktorijel
{
    class Program
    {
        static int? Faktorijel(int n)
        {
            if (n < 0)
            {
                return null;
            }
            int m = 1;
            for (int i = 2; i <= n; i++)
            {
                m *= i;
            }
            return m;
        }

        static void Main(string[] args)
        {
            Console.Write("Unesi broj: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Faktorijel(b));
            Console.Read();
        }
    }
}
