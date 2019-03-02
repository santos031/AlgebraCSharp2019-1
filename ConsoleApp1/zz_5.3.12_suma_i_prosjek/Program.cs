using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5._3._12_suma_i_prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = 0;
            int suma = 0;
            decimal prosjek = 0;

            try
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Unesite {0}. prirodni broj:", i.ToString());
                    suma += int.Parse(Console.ReadLine());
                }

                prosjek = (decimal)suma / 5;

                Console.WriteLine("Suma = {0} \n Prosjek = {1}", suma, prosjek);
            }
            catch (FormatException fex)
            {
                Console.WriteLine("GREŠKA: Nije unešen numerički znak.");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
