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
            string odgovor = "D"; //char umjesto string

            try
            {
                while (odgovor == "D" || odgovor == "d")
                {
                    Console.WriteLine("Unesite 1.broj: ");
                    a = float.Parse(Console.ReadLine());
                    Console.WriteLine("Unesite 2.broj: ");
                    b = float.Parse(Console.ReadLine());
                    Console.WriteLine("Unesite računsku operaciju: ");
                    operacija = Console.ReadLine();

                    if (b == 0)
                    {
                        throw new DivideByZeroException();
                    }

                    switch (operacija)
                    {
                        case "+":
                            Console.WriteLine("Zbroj: {0}", a + b);
                            break;
                        case "-":
                            Console.WriteLine("Razlika: {0}", a - b);
                            break;
                        case "*":
                            Console.WriteLine("Umnožak: {0}", a * b);
                            break;
                        case "/":
                            Console.WriteLine("Kvocijent: {0}", a / b);
                            break;
                        default:
                            Console.WriteLine("Greška u unosu računske operacije!");
                            break;
                    }
                }
            }

            catch (DivideByZeroException dex)
            {
                Console.WriteLine("GREŠKA: Nemoguće je dijeljenje sa 0." + dex);
            }
            finally
            {
                Console.WriteLine("Želite li računati ponovo (D/N)?");
                odgovor = Console.ReadLine(); //convert to char - odgovor = Char.ToLower(Console.Readkey().KeyChar); (pretvaranje velikog u malo slovo)
                //može biti i readkey zato sto se ne mora stisnuti enter
                //if (odgovor=="n")
                Console.ReadKey();
            }
        }

            public class DivideByZeroException:ArithmeticException
            {
            public DivideByZeroException()
            {
            }
            }
        }
    }

