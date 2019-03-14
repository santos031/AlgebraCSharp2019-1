using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._1.system_io
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molim upišite neki text");
            string upis = Console.ReadLine();

            //kreiranje handle-a
            FileStream fs1 = new FileStream("Proba.txt", FileMode.Create);

            //ubacivanje writera
            StreamWriter sw1 = new StreamWriter(fs1);

            sw1.WriteLine(upis);

            sw1.Flush();

            sw1.Close();
            fs1.Close();

            //čitanje iz datoteke Proba.txt
            FileStream fs2 = new FileStream("Proba.txt", FileMode.Open);
            StreamReader sr1 = new StreamReader(fs2);

            //ispis kreirane datoteke
            string procitano = sr1.ReadToEnd();
            Console.WriteLine("Ispis iz datoteke Proba.txt");
            Console.WriteLine(procitano);

            Console.ReadKey();
        }

       
    }
}
