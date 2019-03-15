using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            //zz 6.2.1.naopako
            int broj = 0;
            ArrayList arrList = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Unesite {0}. broj:", i);
                broj = int.Parse(Console.ReadLine());
                arrList.Add(broj);
            }
            
            for (int i = arrList.Count - 1; i >= 0; i--)
            {
                Console.Write(arrList[i] + ", ");
            }
            Console.ReadKey();
        }
    }
}
