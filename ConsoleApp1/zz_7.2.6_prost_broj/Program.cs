using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_7._2._6_prost_broj
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
            Console.WriteLine(DalSiProst(5));
            Console.Read();
        }
    }
}
