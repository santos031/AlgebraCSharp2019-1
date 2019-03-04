using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._1._1_primjer_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = -1;
            ArrayList arr = new ArrayList();

            Console.WriteLine("Unesi broj, za kraj unesi 0.");

            while (broj != 0)
            {
                broj = int.Parse(Console.ReadLine());
                arr.Add(broj);
            }

            //arr.Add(3.14);
            //System.InvalidCastException, object[double]

            //ispis
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
                //ispisuje unesene brojeve do 0
            }
            foreach (int brojcic in arr)
            //ako izostavimo INT ne prolazi u slucaju da unosimo nesto bez metode ToString
            {
                Console.Write(" "+brojcic);
            }
            Console.ReadKey();
        }
    }
}
