using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_primjer
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            /*
            int arg0 = int.Parse(args[0]);
            int arg1 = int.Parse(args[1]);

            Console.Write("Unijeli ste brojeve {0} i {1}", arg0, arg1);
            */
            Console.Write("Unesite prirodan broj: ");
            int a = int.Parse(Console.ReadLine());

            if (a > 10)
            {
                Console.WriteLine("Uneseni broj je veći od 10.");
            }
            else
            {
                Console.WriteLine("Uneseni broj NIJE veći od 10.");
            }

            Console.ReadKey();
=======
            int arg0 = int.Parse(arg[0]);
            int arg1 = int.Parse(arg[1]);

            Console.WriteLine

>>>>>>> b46ce98c4078c5d0271fe79615ab9a2d953b4ff2
        }
    }
}
