using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unos_brojeva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi broj ili prekid s 0:");
            List<int> brojeviSa2i3 = new List<int>();
            List<int> brojeviSa2ne3 = new List<int>();
            List<int> brojeviSa3ne2 = new List<int>();
            List<int> brojeviOstali = new List<int>();
            int a = int.Parse(Console.ReadLine());

            while (a != 0)
            {
                if (a % 2 == 0 && a % 3 == 0)
                {
                    brojeviSa2i3.Add(a);
                }
                else if (a % 2 == 0 && a % 3 != 0)
                {
                    brojeviSa2ne3.Add(a);
                }
                else if (a % 3 == 0 && a % 2 != 0)
                {
                    brojeviSa3ne2.Add(a);
                }
                else
                {
                    brojeviOstali.Add(a);
                }
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Djeljivi s 2 i 3:");
            foreach (int item in brojeviSa2i3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Djeljivi s 2, ali ne s 3:");
            foreach (int item in brojeviSa2ne3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Djeljivi s 3, ali ne s 2:");
            foreach (int item in brojeviSa3ne2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Ostali brojevi:");
            foreach (int item in brojeviOstali)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}