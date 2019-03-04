using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5._3._8_7_3_koliko
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if ((i % 7 == 0) && !(i % 3 == 0))
                {
                    x ++;
                }
            }
            Console.WriteLine("U intervalu [1,1000] ima {0} brojeva dijeljivih sa 7, dok su istovremeno nedijelivi sa 3.", x);
            Console.ReadKey();
        }
    }
}
