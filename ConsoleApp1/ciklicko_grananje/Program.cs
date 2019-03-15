using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciklicko_grananje
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unos prrirodnih brojeva, dok se ne upise 0 i izracunava njihovu sumu i prosjek
            int broj = 1;
            int suma = 0;
            
            while (broj != 0)
            {
                Console.WriteLine("Unesite prirodan broj");
                broj = int.Parse(Console.ReadLine());

                suma += broj; 
            }

            Console.WriteLine("Suma unesenih brojeva iznosi" +  suma.ToString() + " a prosjek im je"  + (int)suma / broj);
            Console.ReadKey();
        }
        
    }
}
