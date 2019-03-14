using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recenica_naopako
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite rečenicu");
            string recenica = Console.ReadLine();

            Console.WriteLine(Naopako(recenica));

            Console.ReadKey();
        }

        public static string Naopako(string recenica) //metoda ispisuje recenicu naopako
        {
            char[] charArray = recenica.ToCharArray();
            Array.Reverse(charArray);
            //Array.Split(charArray);
            return new string(charArray);
        }

        public static string Zamjena(string recenica) //metoda zamjenjuje razmake sa _
        {
            recenica = recenica.Replace(" ", "_");
            return recenica;
        }
    }
}
