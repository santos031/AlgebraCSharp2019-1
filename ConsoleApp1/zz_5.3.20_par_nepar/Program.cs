using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5._3._20_par_nepar
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0;
            int nepar = 0;
            int broj = -1;

            while(broj != 0)
            {
                Console.WriteLine("Unesite prirodan broj: ");
                broj = int.Parse(Console.ReadLine());

                if (broj != 0)
                {
                    if (broj % 2 == 0)
                    {
                        par++;
                    }
                    else
                    {
                        nepar++;
                    }
                }
            }
            Console.WriteLine("Parni brojevi: " + par.ToString());
            Console.WriteLine("Neparni brojevi: " + nepar.ToString());
            Console.ReadKey();

        }
    }
}
