using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pozitivan_negativan
{
    class Pozitivan_Negativan
    {
        static void Main()
        {
            Console.Write("Unesi prirodan broj:");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("Uneseni broj je POZITIVAN.");
            } 

            else
            {
                if (a < 0)
                {
                    Console.WriteLine("Uneseni broj je NEGATIVAN.");
                }
                else
                {
                    Console.WriteLine("Uneseni broj je 0.");
                }
            }
            Console.ReadKey();
        }
    }
}
