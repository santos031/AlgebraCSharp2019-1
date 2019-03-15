using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvjetno_grananje
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Unesite prirodan broj: ");
                int x = int.Parse(Console.ReadLine());

                if (x % 4 == 0)
                {
                    Console.WriteLine("Uneseni broj je djeljiv sa 4");
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine("Uneseni broj je djeljiv sa 3");
                }
                else if ((x % 4 == 0) && (x % 3 == 0))
                {
                    Console.WriteLine("Uneseni broj je djeljiv sa oba broja (3 i 4)");
                }
                else
                {
                    Console.WriteLine("Uneseni broj NIJe djeljiv sa zadanim brojevima (3 i 4)");
                }
            }
            catch (FormatException fex)
            {
                Console.WriteLine("GREŠKA " + fex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
