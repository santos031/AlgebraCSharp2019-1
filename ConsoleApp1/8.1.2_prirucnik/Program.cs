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
            //Instanciraj novi objekt klase Ucenik
            Ucenik uc1 = new Ucenik();

            //Inicijalizacija objekta (postavljanje svojstava objekta)
            Console.WriteLine("Unesi ime učenika:");
            uc1.ime = Console.ReadLine();

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
            Ucenik uc2 = new Ucenik("Perica");

            Console.WriteLine("Ime ucenika je " + uc1.ime + " i " + uc2.ime);

            // List<Ucenik> ucenici = new List<Ucenik>(); //moze i ovako
            List<Ucenik> ucenici = new List<Ucenik>() { uc1, uc2};
            ucenici.Add(uc1);
            ucenici.Add(uc2);

            foreach (var item in ucenici)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();
        }
    }
}
