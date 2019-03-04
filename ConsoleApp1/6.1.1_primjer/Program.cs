using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._1_primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaracija niza
            int?[] niz = new int?[3];
            //Inicijalizacija niza 
            niz[0] = 55;
            //niz[2] = null;
            niz[2] = 77;
            niz[1] = 22;

            try
            {
                for (int i = 0; i < niz.Length; i++)
                {
                    if (niz[i] == null)
                    {
                        throw new Exception("Niz sadrži neinicijaliziranu vrijednost na indexu" + i);
                    }
                    Console.WriteLine(i + ": " + niz[i] + niz[5]);
                    //ispis unazad - ((i+1) + ": " + niz[i]);
                    //iz knjige - ("{0}. elem. niza: {1}", i, niz[i]);
                }
            }
            catch(IndexOutOfRangeException ioorex)
            {
                Console.WriteLine("Pokušali ste dohvatiti nepostojeći član niza" + ioorex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
