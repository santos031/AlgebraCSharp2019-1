using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zz_10._1._2_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs1 = new FileStream("NoviRed.txt", FileMode.Create);
            FileStream fs2 = new FileStream("SaZarezima.txt", FileMode.Create);

            StreamWriter sw1 = new StreamWriter(fs1);
            StreamWriter sw2 = new StreamWriter(fs2);

           for (int i = 1; i <= 100 ; i++)
            {
                if ((i % 3 == 0) || (i % 7 == 0));
                {
                    sw1.WriteLine(i);
                    sw2.Write(i + ", ");
                }
            }

            sw1.Flush();
            sw2.Flush();

            sw1.Close();
            sw2.Close();


            Console.ReadKey();
        }
    }
}
