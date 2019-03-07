using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_8._1._3_zaposlenik
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaposlenik z1 = new Zaposlenik("Ivo", "Ivić", "1234567891011");

            bool provjeraUnosa = false;
            while (!provjeraUnosa)
                {
                Console.WriteLine("Unesite broj bodova: ");

                try
                {
                    z1.BrojBodova = double.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }
                catch (FormatException fex)
                {
                    Console.WriteLine("GREŠKA: " + fex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("GREŠKA: " + ex.Message);
                }
            }

            provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.WriteLine("Unesite vrijednost boda: ");

                try
                {
                    z1.VrijednostBoda = double.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }
                catch (FormatException fex)
                {
                    Console.WriteLine("GREŠKA: " + fex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("GREŠKA: " + ex.Message);
                }
            }


            Console.WriteLine("Zaposlenik: " + z1.Ime + " " + z1.Prezime);
            Console.WriteLine("Neto: " + z1.NetoIzracunPlace());
            Console.WriteLine("Porez: " + z1.porez);
            Console.WriteLine("Bruto: " + z1.BrutoIzracunPlace());

            Console.ReadKey();
        }
    }
}
