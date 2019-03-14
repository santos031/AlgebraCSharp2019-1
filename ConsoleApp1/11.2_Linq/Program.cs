using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer;

namespace _11._2_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //reference iz Business Layera (nest ne stima)
            Ucenik uc1 = new Ucenik("Maja", "Majić");
            Ucenik uc2 = new Ucenik("Ana", "Majić");
            Ucenik uc3 = new Ucenik("Maja", "Jajić");
            Ucenik uc4 = new Ucenik("Maja", "Anić");

            //Može i ovako List<Ucenik> osobe = new List<Ucenik>();

            List<Osoba> osobe = new List<Osoba>();
            List<Osoba> samoMaje = new List<Osoba>();
            osobe.Add(uc1); //ucenik je naslijedio osobu, pa mogu ubaciti novu varijablu ucenik u osobu
            osobe.Add(uc2);
            osobe.Add(uc3);
            osobe.Add(uc4);

            string trazenoIme = "Maja";
            int brojacMaja = 0;
            foreach (var item in osobe)
            {
                if (item.Ime == trazenoIme)
                {
                    brojacMaja++;
                    //samoMaje.Add(item);  //ručno dodavanje, ali se narušava koncept LINQa
                    Console.WriteLine(item.Ime);
                }
            }

            Console.WriteLine(trazenoIme + " se pojavljuje " + brojacMaja + " puta.");
            try
            {
                //from <alias> in <collection>
                Osoba trazenaOsoba = (
                        from os
                        in osobe
                        where os.Ime == trazenoIme
                        select os).SingleOrDefault(); //dohvaca prvu Maju

                samoMaje = (
                    from os
                    in osobe
                    where os.Ime == trazenoIme
                    select os).Take(2).ToList(); //dohvaca prve dvije Maje i vraca ih u listu

                Console.WriteLine("Našao sam osobu" + trazenaOsoba.Ime + " " + trazenaOsoba.Prezime);
            }
            catch(InvalidOperationException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            finally
            {
                foreach (var item in samoMaje)
                {
                    Console.WriteLine("Moje ime je" + item.Ime + " " + item.Prezime);
                }
            }

            Console.ReadKey();
        }
    }
}
