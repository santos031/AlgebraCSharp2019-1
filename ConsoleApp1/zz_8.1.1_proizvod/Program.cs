using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_8._1._1_proizvod
{
    class Program
    {
        static void Main(string[] args)
        {
            Proizvod p1 = new Proizvod();

            Console.WriteLine("Unesite naziv proizvoda: ");
            p1.Naziv = Console.ReadLine();

            Console.WriteLine("Unesite cijenu proizvoda: ");
            p1.Cijena = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite maržu za proizvod: ");
            p1.Marza = double.Parse(Console.ReadLine());

            Console.WriteLine("Unesite porez na proizvod: ");
            p1.Porez = double.Parse(Console.ReadLine());

            Console.WriteLine("Maloprodajna cijena proizvoda iznosi {0}.", p1.MaloprodajnaCijena());

            Console.ReadKey();
        }
        
    }
}
