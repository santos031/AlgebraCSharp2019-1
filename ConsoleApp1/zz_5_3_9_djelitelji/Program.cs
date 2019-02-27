using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5_3_9_djelitelji
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodan broj:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Djelitelji broja {0} su:", a);

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine("{0}, ", i.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}