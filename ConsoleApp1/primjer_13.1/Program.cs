using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primjer_13._1
{
    
    public enum RadniDani
    {
        ponedjeljak=1, utorak, srijeda, cetvrtak, petak
    }

    public enum Ocjene
    {
        nedovoljan=1, dovoljan, dobar, vrlodobar, odlican
    }

    public enum KatoviZgrade
    {
        prizemlje, prvi, drugi, treci, cetvrti //što ne napišemo po defaultu kreće od 0
    }

    class Program
    {
        static void Main(string[] args)
        {
            Firma algebra = new Firma("Algebra d.o.o.");
            algebra.Kat = KatoviZgrade.treci;
            Console.WriteLine(algebra);
            Console.ReadKey();
        }
    }

    class Firma
    {
        private KatoviZgrade kat;
        private string naziv;

        public Firma(string v)
        {
            this.Naziv = v;
        }

        public KatoviZgrade Kat { get => kat; set => kat = value; }
        public string Naziv { get => naziv; set => naziv = value; }

        public override string ToString()
        {
            string kojiKat = "";
            switch ((int)kat)
            {
                case 0: kojiKat = "nultom"; break;
                case 1: kojiKat = "prvom"; break;
                case 2: kojiKat = "drugom"; break;
                case 3: kojiKat = "trecem"; break;
                case 4: kojiKat = "cetvrtom"; break;
                default: kojiKat = "nepoznato"; break;
            }

            return "Naše ime je " + this.naziv + "i nalazimo se na " + kojiKat + " katu.";
        }
    
    }
}
