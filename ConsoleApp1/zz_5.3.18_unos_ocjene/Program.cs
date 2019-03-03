using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5._3._18_unos_ocjene
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena = 0;
            bool unos = false;

            try
            {
                while (!unos)
                {

                    Console.WriteLine("Unesite ocjenu:");
                    ocjena = int.Parse(Console.ReadLine());

                    if (ocjena > 0 && ocjena <= 5)
                    // if (ocjena == "1" || ocjena == "2" || ocjena == "3" || ocjena == "4" || ocjena == "5")
                    {
                        unos = true;
                        Console.WriteLine("Ispravna ocjena");
                    }
                    else
                    {
                        Console.WriteLine("Molim unos ispravne ocjene!");
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("GREŠKA: Nije unešen numerički znak." + ex.Message);
            }
            finally
            { 
                Console.ReadKey();
            }
        }
    }
}
