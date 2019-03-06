using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_7._2._1_krug2
{
    class Program
    {
        static double ToRadius(double num, string op)
        {
            double result = 0;
            if (op == "o")
            {
                result = num / (2 * Math.PI);
            }
            else if (op == "p")
            {
                result = Math.Sqrt(num / Math.PI);
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Unos opsega ili povrsine?(O/P) ");
            string ans = Console.ReadLine().ToLower();
            Console.Write("Unesi vrijednost: ");
            double num = double.Parse(Console.ReadLine());

            if (ans == "o")
            {
                Console.WriteLine("Radijus je: " + ToRadius(num, "o"));
            }
            else if (ans == "p")
            {
                Console.WriteLine("Radijus je: " + ToRadius(num, "p"));
            }
            Console.Read();
        }
    }
}
