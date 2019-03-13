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

            /*
            List<Ucenik> listaUcenika = new List<Ucenik>();
            listaUcenika.Add(u1);
            listaUcenika.Add(u2);
            listaUcenika.Add(u3);

            //lambda funkcija ispisa ucenika
            listaUcenika.ForEach(Ucenik => IspisiUcenike(Ucenik));
            */


            List<Ucenik2> listaUcenika2 = new List<Ucenik2>();
            //listaUcenika2.Add(UnosUcenika());

            for (int i = 1; i <= 5; i++)
            {
                listaUcenika2.Add(UnosUcenika(i));
            }
            listaUcenika2.ForEach(Ucenik2 => IspisiUcenike(Ucenik2));


            /* ispis liste u foreach petlji
            foreach (Ucenik ucenik in listaUcenika)
            {
                IspisiUcenike(ucenik);
            }
            */





            Console.ReadKey();
        }

        //ispis
        private static void IspisiUcenike(Ucenik2 ucenik)
        {
            Console.WriteLine(ucenik.ToString());
            //Console.WriteLine("Učenik: " + ucenik.Ime + " " + ucenik.Prezime + " " + ucenik.Racun + " ("+ ucenik.StvarnoStanjeRacuna() +")");
        }

        //DODATAK - unos ucenika u listu
        public static Ucenik2 UnosUcenika(int i)
        {

            Ucenik2 ucenik = new Ucenik2();
            Console.WriteLine("Unesite ime {0} učenika: ", i);
            ucenik.Ime = Console.ReadLine();

            Console.WriteLine("Unesite prezime učenika: ");
            ucenik.Prezime = (Console.ReadLine());

            Console.WriteLine("Unesite OIB: ");
            ucenik.Oib = (Console.ReadLine());

            Console.WriteLine("Unesite Racun: ");
            ucenik.Racun = Double.Parse(Console.ReadLine());

            if (ucenik.Racun == 0)
            {
                ucenik.Racun = ucenik.getRandomNumber();
            }

            Console.WriteLine("-----------------------------------\n");

            return ucenik;
        }
    }
}

