using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5._3._15_ispis_unatrag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prirodni brojevi iz intervala [1,10] napisani unatrag su:");

            for (int i = 10; i > 0; i--)
            {
                Console.Write("{0}, ", i.ToString());
            }
            Console.ReadKey();
        }
    }
}
