using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_8._3._1_vozila
{
    class Brod : Vozilo
    {
        public delegate void PromjenaIstisnineDelegat(object o, EventArgs e);
        public event PromjenaIstisnineDelegat NaPromjenuIstisnine;

        private double istisnina;
        public double Istisnina { get => istisnina; set => istisnina = value; 
        if (NaPromjenuIstisnine != null)
            {
            NaPromjenuIstisnine(this, EventArgs());
            }
        }
  
        

    }
}
