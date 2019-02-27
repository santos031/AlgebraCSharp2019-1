using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5._3._11_savrseni_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Savršeni brojevi iz intervala [1,1000] su:");
            int zbrojDjelitelja = 0;

            for (int i = 0; i <= 1000; i++)
            {
                zbrojDjelitelja = 0;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        zbrojDjelitelja += j;
                    }
                }
                if (i == zbrojDjelitelja)
                {
                    Console.Write("{0}, ", i.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
