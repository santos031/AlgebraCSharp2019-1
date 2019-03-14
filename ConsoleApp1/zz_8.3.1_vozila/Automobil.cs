using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_8._3._1_vozila
{
    class Automobil : Vozilo
    {
        double ccm;
        public double Ccm { get => ccm; set => ccm = value; }

        public override string ToString()
        {
            return string.Format("Naziv: {0} \n Boja: {1} \n Ks: {2} \n KW: {3}", Naziv, Boja, Ks, KStoKW() );
        }
    }
}
