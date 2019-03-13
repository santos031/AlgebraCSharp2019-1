using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1._1_17.manipulacija
{
    class Program
    {
        static void Main(string[] args)
        {
            string recenica = "Danas je suncan dan, zato vam Dobar dan!";
            string rijec = "dan";
            char slovo = 'n';

            int brojac = 0;
            for (int i = 0; i < recenica.Length; i++)
            {
                if (recenica[i] == slovo)
                {
                    brojac++;
                }
            }
            Console.WriteLine("9.1.1. Znak u rijeci");
            Console.WriteLine("Znak {0} pojavljuje se u recenici '{1}' ----> {2} puta", slovo, recenica, brojac);

            // recenica = recenica.ToLower(); - ovime mjenjam recenicu u mala slova i cuvam je u novoj verziji
            string[] nizrijeci = recenica.Split(' ', ',', '!');
            brojac = 0;
            for (int i = 0; i < nizrijeci.Length; i++)
            {
                if (nizrijeci[i].ToLower() == rijec)
                {
                    brojac++;
                }
            }

            Console.WriteLine("9.1.2. Rijec u recenici");
            Console.WriteLine("Rijec '{0}' pojavljuje se u recenici '{1}' ----> {2} puta", rijec, recenica, brojac);



            Console.WriteLine("9.1.3. Rijeci u novi red");

            for (int i = 0; i < nizrijeci.Length; i++)
            {
                Console.WriteLine(nizrijeci[i]);               
            }

            Console.WriteLine("9.1.4. Brojanje rijeci");

            nizrijeci = recenica.Split(' ');

            Console.WriteLine("U recenici '{0}' ima {1} rijeci.", recenica, nizrijeci.Length); //broji i znakove ukoliko se ne napise prethodni red

            Console.ReadKey();
        }
    }
}
