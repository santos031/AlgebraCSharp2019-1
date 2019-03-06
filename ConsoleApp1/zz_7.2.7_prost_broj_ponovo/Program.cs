using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_7._2._7_prost_broj_ponovo
{
    class Program
    {
        static bool DalSiProst(int num)
        {
            if (num < 2)
            {
                return false;
            }
            int dj = 2;
            while (num > dj)
            {
                if (num % dj == 0)
                {
                    return false;
                }
                dj++;
            }
            return true;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Unesi broj: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(DalSiProst(b));
                Ponovo:
                Console.Write("Ponovo? (D/N) ");
                string ans = Console.ReadLine().ToLower();
                if (ans == "d")
                {
                    continue;
                }
                else if (ans == "n")
                {
                    break;
                }
                else
                {
                    goto Ponovo;
                }

            }
        }
    }
}