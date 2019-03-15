using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_11._1._1_imena
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> imena = new List<string>();

            while (true)
            {
                Console.WriteLine("Upišite imena: ");
                string ime = Console.ReadLine();

                if (ime.ToLower() == "kraj")
                {
                    break;
                }
                else
                {
                    imena.Add(ime);
                }
            }

            List<string> imenaA = (from im in imena
                                   where im.ToLower().Contains("a")
                                   select im).ToList();

            Console.Write("Imena sa slovom A su: ");

            foreach (var ime in imenaA)
            {
                Console.WriteLine(ime + ", ");
            }

            Console.ReadKey();
        }
    }
}
