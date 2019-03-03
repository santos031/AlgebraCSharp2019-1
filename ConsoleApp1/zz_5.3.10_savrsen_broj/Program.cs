using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5._3._10_savrsen_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, perfect = 0;

            try
            {
                Console.WriteLine("Unesite prirodan broj:");
                x = int.Parse(Console.ReadLine());

                if (x <= 0)
                {
                    throw new NegativeNumberException("NEGATIVNI BROJ!");
                }

                for (int i = 1; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        perfect += i;
                    }
                }
                if (x == perfect)
                {
                    Console.WriteLine("Unesen broj je SAVRŠEN (broj koji je jednak zbroju svojih djelitelja, bez njega samoga).");
                }
                else
                {
                    Console.WriteLine("Uneseni broj NIJE savršen.");
                }
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Dozvoljeni su samo prirodni brojevi." + ex.Message);
            }
            catch (FormatException fex)
            {
                Console.WriteLine("GREŠKA: Nije unešen numerički znak:" + fex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException()
        {
        }

        public NegativeNumberException(string message)
            : base(message)
        {
            Console.WriteLine("Negativni brojevi nisu u domeni savršenih.");
        }
        public NegativeNumberException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}




