using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca_ucenik
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik u1 = new Ucenik("Iva", "Ivić");
            Ucenik u2 = new Ucenik("Mara", "Marić", "0123456789");
            Ucenik u3 = new Ucenik("Ana", "Anić", "9876543210", 3500);

            List<Ucenik> listaUcenika = new List<Ucenik>();
            listaUcenika.Add(u1);
            listaUcenika.Add(u2);
            listaUcenika.Add(u3);

            /* ispis liste u foreach petlji
            foreach (Ucenik ucenik in listaUcenika)
            {
                IspisiUcenike(ucenik);
            }
            */

            //lambda funkcija ispisa ucenika
            listaUcenika.ForEach(Ucenik => IspisiUcenike(Ucenik));

            //listaUcenika.ForEach(Ucenik => Ucenik.Racun -= skolarina); //odmah rjesava problem skolarine uz ispis

            Console.ReadKey();
        }

        //ispis
        private static void IspisiUcenike(Ucenik ucenik)
        {
            Console.WriteLine(ucenik.ToString());
            //Console.WriteLine("Učenik: " + ucenik.Ime + " " + ucenik.Prezime + " " + ucenik.Racun + " ("+ ucenik.StvarnoStanjeRacuna() +")");
        }
    }
}

