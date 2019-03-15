using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_12._1._2_stoperica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pritisni za START");
            Console.ReadKey();
            DateTime start = DateTime.Now;

            Console.WriteLine("Pritisni za KRAJ");
            Console.ReadKey();
            DateTime kraj = DateTime.Now;
            TimeSpan interval = kraj.Subtract(start);

            Console.WriteLine("Prošlo je {0}:{1}:{2}:{3}", interval.Hours, interval.Minutes, interval.Seconds, interval.Milliseconds);
            Console.ReadKey();


        }
    }
}
