using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zbroj_razlika
{
    class Program
    {
<<<<<<< HEAD
        
        static void Main(string[] args)
        {
            int a=0, b = 0;


            Console.WriteLine(@"Unesi 1. broj\n\n\n\tjhjk\\as\'hd\jkh\tkkskd\tkk");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi 2. broj");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Zbroj je:{0}", a + b);

            Console.WriteLine("Razlika je:{0}", a - b);

            Console.WriteLine("Razlika je:{1} Zbroj je:{0}", a + b, a - b);

            Console.WriteLine("Umnožak je:{0}", a * b);

            Console.WriteLine("Kvocijent je:{0}", (decimal)a/(decimal)b);

            
=======
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
>>>>>>> b46ce98c4078c5d0271fe79615ab9a2d953b4ff2

            Console.ReadLine();
        }
    }
}
