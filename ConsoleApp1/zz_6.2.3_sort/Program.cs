using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_6._2._3_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = -1;
            ArrayList brojevi = new ArrayList();

            Console.WriteLine("Unos brojeva:");

            while (broj != 0)
            {
                broj = int.Parse(Console.ReadLine());
                brojevi.Add(broj);
            }

            brojevi.Sort();

            Console.WriteLine("Uneseni brojevi poredani prema veličini:");
            foreach (int a in brojevi)
            {
                Console.WriteLine(" " + a);
            }
            Console.ReadKey();
        }
    }
}
