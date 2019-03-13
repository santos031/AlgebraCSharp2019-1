using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_9._1._6_palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite rečenicu: ");
            string recenica = Console.ReadLine();

            //uklanjanje razmaka
            recenica = recenica.Replace(" ", "");

            //nova string varijabla koja ucitava znakove obrnuto
            string obrnuto = "";
            for (int i = recenica.Length - 1; i >= 0; i--)
            {
                obrnuto += recenica[i];
            }

            //uvjet kolji zadovoljava pravilo palindroma
            if (recenica == obrnuto)
            {
                Console.WriteLine("PALINDROM");
            }
            else
            {
                Console.WriteLine("NIJE palindrom");
            }
            Console.ReadKey();
        }
    }
}
