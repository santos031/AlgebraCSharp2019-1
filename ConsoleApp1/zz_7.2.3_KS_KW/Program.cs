using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_7._2._3_KS_KW
{
    class Program
    {
       static double KWtoKS(double kw)
            {
                return kw * 1.34102209;
            }

            static void Main(string[] args)
            {
                Console.Write("Unesi KW: ");
                double kw = double.Parse(Console.ReadLine());

                Console.Write("KS: " + KWtoKS(kw));
                Console.Read();
            }
        }
    }
