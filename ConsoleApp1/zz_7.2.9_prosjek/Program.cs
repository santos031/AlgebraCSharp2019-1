using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_7._2._9_prosjek
{
    class Program
    {
        static string Prosjek (double o)
        {
            string p = "";

            if (o < 2)
            {
                p = "Nedovoljan";
            }
            else if (o < 2.5)
            {
                p= "Dovoljan";
            }
            else if (o < 3.5)
            {
                p = "Dobar";
            }
            else if (o < 4.5)
            {
                p = "Vrlo dobar";
            }
            else if (o >= 4.5)
            {
                p = "Odlican";
            }
            return p;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ocjenu: ");
            double o = double.Parse(Console.ReadLine());

            Console.WriteLine("Ocjena je: {0}" , Prosjek(o));

            Console.ReadKey();
        }
    }
}
