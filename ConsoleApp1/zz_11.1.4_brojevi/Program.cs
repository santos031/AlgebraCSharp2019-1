﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_11._1._4_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> brojevi = new List<int>();
            int unos = -1;

            while (unos != 0)
            {
                Console.WriteLine("Unesite broj: ");
                unos = int.Parse(Console.ReadLine());

                if (unos != 0)
                {
                    brojevi.Add(unos);
                }
            }

            int Parni = (from br in brojevi
                         where br % 2 == 0
                         select br).Count();

            int Neparni = brojevi.Count - Parni;

            Console.WriteLine("Parnih ima {0}, a neparnih {1}", Parni, Neparni);

            Console.ReadKey();
        }
    }
}
