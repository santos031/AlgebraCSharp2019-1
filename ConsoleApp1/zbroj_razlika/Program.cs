using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zbroj_razlika
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;
            Console.WriteLine("Unesi 1.broj");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesi 2.broj");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Zbroj 1. i 2. broja je:{0}", a + b);

            Console.WriteLine("Razlika 1. i 2. broja je:{0}", a - b);

            Console.WriteLine("Umnožak 1. i 2. broja je:{0}", a * b);

            Console.WriteLine("Kvocijent 1. i 2. broja je:{0}", a / b);

            Console.ReadLine();
        }
    }
}
