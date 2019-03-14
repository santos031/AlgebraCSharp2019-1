using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10._1._2_path_file_directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapa u kojoj se izvršava naš program:");
            Console.WriteLine(Environment.CurrentDirectory); // Enviroment je static klasa, a CurrentDirectory je svojstvo

            Console.WriteLine("Postoji li file Proba.txt u izvršnoj mapi");
            
            //Path klasa
            string mojaPutanja = Path.Combine(Environment.CurrentDirectory, "Proba.txt"); //Path.Combine spaja klasu sa fileom
            
            //File klasa
            Console.WriteLine(File.Exists(mojaPutanja));
            
            //Directory klasa
            if (!Directory.Exists("Proba")) //Directory je static klasa, a Exists je metoda
            {
                //Ako ne postoji folder Proba, kreiram ga
                Directory.CreateDirectory("Proba");  //CreateDirectory je metoda
            }
           
            //Ispisujem sve foldere na C-u
            Console.WriteLine("Direktoriji na C:");
            string[] sDirs = Directory.GetDirectories(@"C:\"); // [] niz
            foreach (string sDir in sDirs)
            {
                Console.WriteLine(sDir);     //ispiši red po red koje si našao
            }

            //Ispisujem sve fileove na C:
            Console.WriteLine("Datoteke na C:");
            string[] sFiles = Directory.GetFiles(@"C:\"); //@ služi kod ispisa pathova kako bi \ bio vidljiv u ispisu
            foreach (string sFile in sFiles)
            {
                Console.WriteLine("\nsFile:");
                Console.WriteLine(sFile); //ispisuje cijeli path svakog filea

                Console.WriteLine("\nsPath.getfilename: ");
                Console.WriteLine(Path.GetFileName(sFile));

                Console.WriteLine("\nsPath.getextension: ");
                Console.WriteLine(Path.GetExtension(sFile));

                Console.WriteLine("\nsFile.getcreationtime: ");
                Console.WriteLine(File.GetCreationTime(sFile));

                // Console.WriteLine(File.SetCreationTime(sFile, DateTime. .....));
            }

            Console.ReadKey();
        }

    }
}
