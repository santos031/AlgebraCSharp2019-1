using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_7._2._10_ukupna_cijena
{
    class Program
    {
        static double UlaznaCijena(double ukupna)
        {
            double ulaznaCijena = 0;
            if (ukupna < 131.23)
            {
                ulaznaCijena = (ukupna - 5.5) / 1.27;
            }
            else if (ukupna < 328.22)
            {
                ulaznaCijena = (ukupna - 9.5) / 1.28;
            }
            else if (ukupna < 658.71)
            {
                ulaznaCijena = (ukupna - 15) / 1.29;
            }
            else if (ukupna < 1323.7)
            {
                ulaznaCijena = (ukupna - 25) / 1.3;
            }
            else
            {
                ulaznaCijena = (ukupna - 50) / 1.35;
            }
            return ulaznaCijena;
        }

        static void Main(string[] args)
        {
            Console.Write("Unesi ukupnu cijenu: ");
            Console.Write("Ulazna cijena je: " + UlaznaCijena(double.Parse(Console.ReadLine())));
            Console.Read();
        }
    }
}
