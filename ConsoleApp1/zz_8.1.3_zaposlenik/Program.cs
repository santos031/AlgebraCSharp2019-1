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
            Zaposlenik z2 = new Zaposlenik("Pero", "Perić");

            List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
            listaZaposlenika.Add(z1);
            listaZaposlenika.Add(z2);

            //DRUGI NAČIN
            //List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>
            //{
            //Zaposlenik z1 = new Zaposlenik("Ivo", "Ivić", "1234567891011");
            //Zaposlenik z2 = new Zaposlenik("Pero", "Perić");
             //}

            //lambda funkcije - uljepsavanje koda
            listaZaposlenika.ForEach(Zaposlenik => UnesiBodove(Zaposlenik));
            listaZaposlenika.ForEach(Zaposlenik => UnesiVrijednostBodova(Zaposlenik));
            listaZaposlenika.ForEach(Zaposlenik => IspisiZaposlenika (Zaposlenik));


            Console.ReadKey();
        }

        private static void IspisiZaposlenika (Zaposlenik zaposlenik)
        {
            throw new NotImplementedException();

            Console.WriteLine("Zaposlenik: " + z1.Ime + " " + z1.Prezime);
            Console.WriteLine("Neto: " + z1.NetoIzracunPlace());
            Console.WriteLine("Porez: " + z1.Porez);
            Console.WriteLine("Bruto: " + z1.BrutoIzracunPlace());
        }

        private static void UnesiBodove(Zaposlenik zaposlenik)
        {
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
        }

        private static void UnesiVrijednostBodova(Zaposlenik zaposlenik)
        {
            bool provjeraUnosa = false;
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

        }
    }
}
