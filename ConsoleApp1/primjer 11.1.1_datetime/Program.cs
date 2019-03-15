using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primjer_11._1._1_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datum1 = new DateTime(2015, 1, 1);
            DateTime datum2 = new DateTime(2016, 8, 1);

            if (datum1 < datum2)
            {
                Console.WriteLine(datum1.ToString() + "je manji od datuma " + datum2.ToString());
                //Console.WriteLine("01.01.2015. je manji od 01.08.2016.");
            }
            // else
            // {
            //Console.WriteLine("01.08.2016.  je manji od 01.01.2015. ");
            //}

            Console.WriteLine("Trenutno je " + DateTime.Now);
            Console.WriteLine("Trenutno je " + DateTime.Today);

            //skraceni zapis -  (uvijet)? true:false
            Console.WriteLine((DateTime.IsLeapYear(2019) )? "Ovo je prijestupna godina? " : "Ovo nije prijestupna godina");

            Console.WriteLine("Danas je: " + DateTime.Today.DayOfWeek);

            Console.WriteLine(datum1 + "datum + 7 dana" + DateTime.Today.Add(TimeSpan 7)  );

            Console.ReadKey();
        }
    }
}
