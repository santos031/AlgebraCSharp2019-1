using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5._3._4_faktorijel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molim unesite cijeli pozitivni broj:");
            //5! = 120 (5*4*6*2*1 =120)
            try
            {
                int a = int.Parse(Console.ReadLine());
                if (a <= 0)
                {
                    throw new NegativeNumberException("NEGATIVNI BROJ");
                }
                if (a >= 20)
                {
                    throw new Exception("BROJ > 20 !!");
                }
                int fact = 1;
                for (int i = a; i > 0; i--)
                {
                    // Console.WriteLine(i);
                    fact *= i;
                }
                Console.WriteLine("Njegov faktorijel je:" + fact);
            }

            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Dozvoljeni brojevi su u intervalu 1,19 " ex.ToString());
            }
            catch (VeciOdDvajstException ex)
            {
                Console.WriteLine("Broj je prevelik, rezultat je veci od dimenzije int " ex.ToString());
            }
            finally
            {
                Console.ReadLine();
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
            Console.WriteLine("Dodatno custom pojašnjenje klase NegativeNumberException");
        }
        public NegativeNumberException(string message, Exception inner)
            : base(message, inner)
        {
        }





        public class VeciodDvajstException : Exception
        {
            public VeciodDvajstException()
            {
            }

            public VeciodDvajstException(string message)
                : base(message)
            {
            }
            public VeciodDvajstException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }
    }
}
