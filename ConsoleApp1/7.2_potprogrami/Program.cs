using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2_potprogrami
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            Program.HelloWorld(); //ukoliko se nalazim izvan programa upisujem ovo

            Console.WriteLine( HelloWorld("Ola"));

            Console.ReadKey();
        }
        static void HelloWorld()
        {
            Console.WriteLine("Hellloooo");
        }
        static String HelloWorld(String poz)
        {
            return poz + " hello i tebi";
        }
    }
}
