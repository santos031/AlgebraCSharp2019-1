﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5_2_5_u_intervalu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj: ");
            int a = int.Parse(Console.ReadLine());

            if (a >= 100 && a <= 200)
            {
                Console.WriteLine("Broj je u intervalu [100,200]");
            }
            else
            {
                Console.WriteLine("Broj NIJE u navedenom intervalu.");
            }
            Console.ReadKey();
        }
    }
}
