﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2_prirucnik
{
    class Program
    {
        static void Main(string[] args)
        {
            //pozivanje klase Nastavnik
            Console.WriteLine("Što je to nastavik?");
            Console.WriteLine(Nastavnik.Opis());

            Console.WriteLine("Koji je koeficijent nastavik?");
            Console.WriteLine(Nastavnik.Koeficijent());

            Nastavnik n1 = new Nastavnik();
            // n1.Ime = "Claudije"; //ne mozemo postaviti READ ONLY property

            //ispis može (set opcija)
            Console.WriteLine("Njegovo ime je " + n1.Ime);

            //OIB mozemo postaviti
            n1.Oib = 12345;


            //Console.WriteLine("Njegovo OIB je " + n1.Oib); //ne dozvoljava citanje OIBA

            //Ispisi dio OIBA
            Console.WriteLine("Njegovo OIB je " + n1.PartialOib + "*******");

            //Instanciraj novi objekt klase Ucenik
            Ucenik uc1 = new Ucenik();

            //Inicijalizacija objekta (postavljanje svojstava objekta)
            Console.WriteLine("Unesi ime učenika:");
            uc1.Ime = Console.ReadLine();

            Console.WriteLine("Unesi prezime učenika:");
            uc1.prezime = Console.ReadLine();

            Console.WriteLine("Unesi ocjenu iz Matematike:");
            uc1.OcjenaizMatematike = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi ocjenu iz Biologije:");
            uc1.OcjenaizBiologije = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi ocjenu iz Engleskog:");
            uc1.OcjenaizEngleskog = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Prosjek je: " + uc1.Prosjek());

            //instanciraj novi objekt klase Ucenik
            Ucenik uc2 = new Ucenik("perica");

            Console.WriteLine("Ime ucenika je " + uc1.Ime + " i " + uc2.Ime);

            // List<Ucenik> ucenici = new List<Ucenik>(); //moze i ovako
            List<Ucenik> ucenici = new List<Ucenik>() { uc1, uc2};
            ucenici.Add(uc1);
            ucenici.Add(uc2);

            foreach (var item in ucenici)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nNastavnici:");

            List<Nastavnik> nastavnici = new List<Nastavnik>();
            nastavnici.Add(n1);

            foreach (var item in nastavnici)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
