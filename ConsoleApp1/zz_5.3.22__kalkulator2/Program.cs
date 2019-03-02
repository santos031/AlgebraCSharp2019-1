using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5._3._22__kalkulator2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b = 0;
            string operacija = "";
            string odgovor = "D";

            while (odgovor == "D" || odgovor == "d")
            {
                Console.WriteLine("Unesite 1.broj: ");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Unesite 2.broj: ");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("Unesite računsku operaciju: ");
                operacija = Console.ReadLine();

                switch (operacija)
                {
                    case "+":
                        Console.WriteLine("Zbroj: {0}", a + b);
                        break;
                    case "-":
                        Console.WriteLine("Zbroj: {0}", a - b);
                        break;
                    case "*":
                        Console.WriteLine("Zbroj: {0}", a * b);
                        break;
                    case "/":
                        Console.WriteLine("Zbroj: {0}", a / b);
                        break;
                    default:
                        Console.WriteLine("Greška u unosu računske operacije!");
                        break;
                }

                Console.WriteLine("Želite li računati ponovo (D/N)?");
                odgovor = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
