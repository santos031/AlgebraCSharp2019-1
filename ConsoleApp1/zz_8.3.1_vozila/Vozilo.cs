using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_8._3._1_vozila
{
    class Vozilo
    {
        public string naziv;
        public string Naziv { get => naziv; set => naziv = value; }
        
        private string boja;
        public string Boja { get => boja; set => boja = value; }
        
        private int ks;
        public int Ks { get => ks; set => ks = value; }

        public double KStoKW(double ks)
        {
            return ks * 0.736;
        }
    }
}
