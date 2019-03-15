using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _2_rijeci_abc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rijeci = new List<string>();

            while (true)
            {
                Console.WriteLine("Upišite riječi: ");
                string rijec = Console.ReadLine();

                if (rijec.ToLower() == "kraj")
                {
                    break;
                }
                else
                {
                    rijeci.Add(rijec);
                }
            }

            List<string> rijeciA = (from rijec in rijeci
                                   where rijec.ToLower().StartsWith("a")
                                   select rijec).ToList();

            Console.Write("Riječi koje počinju sa slovom A su: ");

            foreach (var rijec in rijeciA)
            {
                Console.WriteLine(rijec + ", ");
            }

            List<string> rijeciB = (from rijec in rijeci
                                    where rijec.ToLower().StartsWith("b")
                                    select rijec).ToList();

            Console.Write("Riječi koje počinju sa slovom B su: ");

            foreach (var rijec in rijeciB)
            {
                Console.WriteLine(rijec + ", ");
            }

            List<string> rijeciC = (from rijec in rijeci
                                    where rijec.ToLower().StartsWith("c")
                                    select rijec).ToList();

            Console.Write("Riječi koje počinju sa slovom C su: ");

            foreach (var rijec in rijeciC)
            {
                Console.WriteLine(rijec + ", ");
            }



            Console.ReadKey();
        }
    }
}