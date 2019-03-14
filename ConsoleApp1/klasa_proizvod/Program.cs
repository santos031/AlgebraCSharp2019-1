using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasa_proizvod
{
    class Program
    {
        static void Main(string[] args)
        {
            Proizvod proizvod = new Proizvod();
            proizvod.NaIzracunCijene += new Proizvod.NaIzracunCijeneDelegat(proizvod_NaIzracunCijene);

            Console.Write("Unesite naziv proizvoda:");
            proizvod.Naziv = Console.ReadLine();
            Console.Write("Unesite osnovnu cijenu proizvoda:");
            proizvod.OsnovnaCijena = double.Parse(Console.ReadLine());

            bool unosMarzeOK = false;
            while (!unosMarzeOK)
            {
                Console.Write("Unesite marzu:");

                try
                {
                    proizvod.Marza = double.Parse(Console.ReadLine());
                    unosMarzeOK = true;
                }
                catch (FormatException fex)
                {
                    Console.WriteLine("Greška" + fex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Greška" + ex.Message);
                }
            }
            Console.WriteLine("ukupna cijena proizvoda je {0}", proizvod.IzacunajCijenu());
            Console.ReadKey();
        }

        static void proizvod_NaIzracunCijene(object sender, EventArgs e)
        {
            Proizvod proizvod = (Proizvod)sender;
            Console.WriteLine("Izracunata je ukupna cijena proizvoda {0}", proizvod.Naziv);
        }
    }
}

