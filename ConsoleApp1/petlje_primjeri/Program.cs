using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petlje_primjeri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ispis svih brojeva 0,1,2,...,99
            Console.WriteLine("Ispis svih brojeva 0,1,2,...,99"); 
            for (int i = 0; i < 100; i++)
            {
                Console.Write("{0} ", i);
            }
          
            Console.WriteLine("\n\nIspis svih brojeva 0,2,4...,88");
            //Ispis svih brojeva 0,2,4...,88
            for (int i = 16; i < 89; i+=2)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\n\nIspis svih brojeva 135,130,125,,,55");
            //Ispis svih brojeva 135,130,125,,,55
            for (int i = 135; i < 54; i -= 5)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\n\nIspis svih brojeva od 0 do 99, osim 80");
            //Ispis svih brojeva od 0 do 99, osim 80
            for (int i = 0; i < 100; i ++)
            {
                if (i == 80)
                {
                    continue;
                }
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\n\nIspis svih brojeva od 0 do 99, a preskoči veće od 80");
            //Ispis svih brojeva od 0 do 99, a preskoči veće od 80
            for (int i = 0; i < 100; i++)
            {
                if (i == 80)
                {
                    break;
                }
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\n\nIspis svih brojeva od 0 do 99, koji su djeljivi sa 17 i 13");
            //Ispis svih brojeva od 0 do 9999, koji su djeljivi sa 17 i 13
            for (int i = 0; i < 10000; i++)
            {
                if (i % 17 == 0 && i % 13 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadLine();
             }
    }
}
