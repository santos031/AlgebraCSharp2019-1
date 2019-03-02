using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5._4._14_neparni_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neparni brojevi iz intervala [1,10] su:");

            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("{0}, ", i.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
