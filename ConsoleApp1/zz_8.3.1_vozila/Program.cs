using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace zz_8._3._1_vozila
{
    class Program
    {
        static void Main(string[] args)
        {
            char unos = 'd';

            ArrayList vozila = new ArrayList();
            Automobili automobili = new Automobili();

            while (unos == 'd' || unos = 'D')
            {
                Console.WriteLine("Za unos automobila birajte 1, a za unos broda birajte 2");
                char odabir = Console.ReadKey(false).KeyChar;
                Console.WriteLine();

                if (odabir == '1')
                {
                    Automobil automobil = new Automobil();

                    Console.WriteLine("Unesite naziv automobila");
                    automobil.Naziv = Console.ReadLine();
                    Console.WriteLine("Unesite boju automobila");
                    automobil.Boja = Console.ReadLine();
                    Console.WriteLine("Unesite KS automobila");
                    automobil.Ks = int.Parse(Console.ReadLine());
                    Console.WriteLine("Unesite Ccm automobila");
                    automobil.Ccm = double.Parse(Console.ReadLine());

                    vozila.Add(automobil);
                    automobili.Add(automobil);
                }
                else if (odabir == '2')
                {
                    Brod brod = new Brod();

                    brod.NaPromjenuIstisnine += new Brod.PromjenaIstisnineDelegat(NaPromjenuIstisnine);

                    Console.WriteLine("Unesite naziv broda");
                    brod.Naziv = Console.ReadLine();
                    Console.WriteLine("Unesite boju broda");
                    brod.Boja = Console.ReadLine();
                    Console.WriteLine("Unesite KS broda");
                    brod.Ks = int.Parse(Console.ReadLine());
                    Console.WriteLine("Unesite istisninu broda");
                    brod.Istisnina = double.Parse(Console.ReadLine());

                    vozila.Add(brod);
                }
                else
                {
                    Console.WriteLine("Greška pri unosu!");
                }

                Console.WriteLine("Želite li unositi jos vozila? D/N");
                unos = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            Console.WriteLine("Sva vozila:");
            foreach (object objekt in vozila)
            {
                Vozilo vozilo = (Vozilo)objekt;

                Console.WriteLine("NAziv {0}, Boja: {1}, KS: {2}, KW: {3}", vozilo.Naziv, vozilo.Boja, vozilo.Ks, vozilo.KStoKW());
            }

            Console.WriteLine("Automobili:");
            foreach(Automobil automobil in automobili)
            {
                Console.WriteLine(automobili.ToString());
            }

            Console.ReadKey();

            
        }

        static void NaPromjenuIstisnine(object o, EventArgs e)
        {
            Brod brod = (Brod)o;
            Console.WriteLine("Promjena istisnine.");
            Console.WriteLine("Nova istisnina je: {0} ", brod.Istisnina);
        }
    }
}
