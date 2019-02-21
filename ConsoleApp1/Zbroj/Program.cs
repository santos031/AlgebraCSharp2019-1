using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbroj
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklaracija varijabli
            int x, y;

            //definicija varijabli x iy
            x = 5;
            y = x + 3;

            //ispis u konzolu
            Console.WriteLine("broj x je:" + x);
            Console.WriteLine("broj y je:" + y);
            Console.WriteLine("njihov zbroj je :" + (x+y));

            //ne zatvaraj dok se ne stisne key/
            Console.ReadKey();
        }
    }
}
