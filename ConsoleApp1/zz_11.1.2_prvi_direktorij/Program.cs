using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zz_11._1._2_prvi_direktorij
{
    class Program
    {
        private static string dir;

        static void Main(string[] args)
        {
            Console.WriteLine("Unesite putanju:");
            string putanja = Console.ReadLine();

            if (!Directory.Exists(putanja))
            {
                Console.WriteLine("nepostojeća putanja");
            }
            else
            {
                string dir = (from di in Directory.GetDirectories(putanja)
                              orderby Path.GetDirectoryName(di) descending
                              select di).FirstOrDefault();
            }

            if (!string.IsNullOrEmpty(dir))
            {
                Console.WriteLine("Pronađen direktorij: " + Path.GetFileName(dir));
            }
            else
            {
                Console.WriteLine("Nepostojeći direktorij");
            }
        }       
    }
        
}
