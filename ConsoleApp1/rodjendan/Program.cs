using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rodjendan
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public enum Spol
        {
            Muski,
            Zenski
        }

        public class Osoba
        {
            private Spol spol;
            public Spol Spol
            {
                get { return spol; }
                set { spol = value; }
            }
        }
    }
}
