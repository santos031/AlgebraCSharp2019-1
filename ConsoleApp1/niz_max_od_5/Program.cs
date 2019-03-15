using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace niz_max_od_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]niz = unesiNizBrojeva();

            ispisiNizBrojeva(niz);

            Console.ReadKey();
        }

        public static int[]unesiNizBrojeva()
        {
            int[]niz = new int[5];

            Console.WriteLine("Unesite 5 brojeva:");

            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine("Unesite {0}. broj:", i);
                niz[i] = int.Parse(Console.ReadLine());
            }
            return niz;
        }

        public static void ispisiNizBrojeva(int[] niz)
        {

            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i] + ", ");
            }

            Console.WriteLine("Najveći je: " + VratiMaxBroj(niz));

        }



        public static int VratiMaxBroj(int[] niz)
        {
            int maxBroj = 0;

            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] > maxBroj)
                {
                    maxBroj = niz[i];
                }
            }
            return maxBroj;
        }
       
    }
}
