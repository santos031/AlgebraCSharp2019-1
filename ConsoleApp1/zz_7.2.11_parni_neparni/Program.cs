using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_7._2._11_parni_neparni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi brojeve:(0 za prekid unosa) ");
            List<int> brojevi = Unos();
            Ispis(Parni(brojevi), Neparni(brojevi));
            Console.Read();
        }

        static List<int> Unos()
        {
            List<int> listaBr = new List<int>();
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    break;
                }
                listaBr.Add(n);
            }
            return listaBr;
        }

        static List<int> Parni(List<int> listaBr)
        {
            List<int> parni = new List<int>();
            foreach (int b in listaBr)
            {
                if (b % 2 == 0)
                {
                    parni.Add(b);
                }
            }
            return parni;
        }

        static List<int> Neparni(List<int> listaBr)
        {
            List<int> neparni = new List<int>();
            foreach (int b in listaBr)
            {
                if (b % 2 != 0)
                {
                    neparni.Add(b);
                }
            }
            return neparni;
        }

        static void Ispis(List<int> p, List<int> n)
        {
            Console.Write("\nParni su: ");
            foreach (int b in p)
            {
                Console.Write(b + " ");
            }
            Console.Write("\n\nNeparni su: ");
            foreach (int b in n)
            {
                Console.Write(b + " ");
            }
        }
    }
}

