using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_7._2._1_krug
{
    class Program
    {
        static void Main(string[] args)
        {
            //za uneseni opseg kruga izračunava radijus i površinu
            Console.WriteLine("Unesite radijus kruga:");
            double radijus = double.Parse(Console.ReadLine());

            Console.WriteLine("RADIJUS: " + radijus);
            Console.WriteLine("OPSEG: " + Math.Round(Opseg(radijus)),2);
            Console.WriteLine("POVRŠINA: " + Math.Round(Povrsina(radijus)),2);

            Console.WriteLine("RADIJUS: " + Math.Round(RadijusIzPovrsine(31)), 2);

            Console.ReadKey();

        }

        static double Opseg(double radijus)
        {
            return 2 * radijus * Math.PI;
        }

        static double Radijus (double opseg)
        {
            return Math.PI / (2*opseg);
        }

        static double Povrsina (double radijus)
        {
            return radijus * radijus * Math.PI;
        }


        static double RadijusIzPovrsine(double povrsina)
        {
            return  Math.Sqrt(povrsina / Math.PI) ;
        }





    }
}
