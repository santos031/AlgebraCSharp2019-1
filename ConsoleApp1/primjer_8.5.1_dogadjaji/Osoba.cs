using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primjer_8._5._1_dogadjaji
{
    public class Osoba
    {
        //deklaracija dogadjaja
        public delegate void NaPromjenuImenaDelegat(object sender, EventArgs e); //pokazivac eventa
        public event NaPromjenuImenaDelegat NaPromjenuImena;

        //polje
        private string ime;

        //svojstvo
        public string Ime
        {
            get { return ime; }
            set
            {
                ime = value;
                if (NaPromjenuImena != null)
                {
                    NaPromjenuImena(this, new EventArgs()); //this se odnosi na Osobu  //EventArgs - lista eventa
                }
            }
        }
    }
}