using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5._3._5_djeljivi_s3_uzpromjenu
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                Console.WriteLine("Unesi prvi broj intervala");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesi drugi broj intervala");
                int n = int.Parse(Console.ReadLine());
                if (n < a)
                {
                    throw new Exception("Nepravilan interval");
                }
                for (int i = a; i < n; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.Write("\n{0} ", i);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadKey();
            }
            
        }
    }
}
