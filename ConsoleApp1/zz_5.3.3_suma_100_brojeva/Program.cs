using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5._3._3_suma_100_brojeva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nSuma prvih 100.");
            int suma = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.Write("{0} ", suma += i);
            }
        }
    }  
}
