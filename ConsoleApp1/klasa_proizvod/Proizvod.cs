using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasa_proizvod
{
    class Proizvod
    {
        public delegate void NaIzracunCijeneDelegat(object sender, EventArgs e);
        public event NaIzracunCijeneDelegat NaIzracunCijene;

        private string naziv = "";
        public string Naziv { get => naziv; set => naziv = value; }

        private double osnovnaCijena;
        public double OsnovnaCijena { get => osnovnaCijena; set => osnovnaCijena = value; }

        private double marza;
        public double Marza
        {
            get => marza;
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new Exception("Netocna vrijednost marze");
                }
                else
                {
                    value = marza;
                }
            }
        }

        

        public double IzacunajCijenu()
        {
            if (NaIzracunCijene != null)
            {
                NaIzracunCijene(this, new EventArgs());
            }
            double cijena = 0;
            cijena = OsnovnaCijena + (OsnovnaCijena * marza);
            return cijena;
           
        }
    }
}
