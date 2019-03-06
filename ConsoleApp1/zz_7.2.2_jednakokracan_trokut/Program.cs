using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_7._2._2_jednakokracan_trokut
{
    class Program
    {
            static double Osnovica(double pov, double vis)
            {
                return (pov * 2) / vis;
            }

            static void Main(string[] args)
            {
                Console.Write("Unesi povrsinu trokuta: ");
                double pov = double.Parse(Console.ReadLine());
                Console.Write("Unesi visinu trokuta: ");
                double vis = double.Parse(Console.ReadLine());

                Console.Write("Osnovica je: " + Osnovica(pov, vis));
                Console.Read();
            }
        }
    }
