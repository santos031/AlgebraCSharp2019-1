using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace prijestupna_godina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite godinu: ");
            int godina = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(godina))  ////???? godina treba biti boolean
            //Console.WriteLine((DateTime.IsLeapYear(godina)) ? "Ovo je prijestupna godina? " : "Ovo nije prijestupna godina");
            {
                Console.WriteLine("Godina je PRIJESTUPNA!");
            }
            else
            {
                Console.WriteLine("Godina NIJE prijestupna.");
            }
            Console.ReadKey();
        }
    }
}
