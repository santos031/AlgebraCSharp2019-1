using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_7._2._5_udaljenost
{
    class Program
        {
        static double Udaljenost( double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Unesite vrijednost X1 za izračunavanje: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite vrijednost X2 za izračunavanje: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite vrijednost Y1 za izračunavanje: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite vrijednost Y2 za izračunavanje: ");
            double y2 = double.Parse(Console.ReadLine()); 

            Console.Write("Udaljenost između točaka P1 i P2 iznosi: " + Udaljenost(x1, x2, y1, y2));
            Console.Read();
        }
    }
}