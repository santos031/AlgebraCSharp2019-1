using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_klasa_automobil
{
    class Automobil
    {
        public delegate void NaPromjenuGodineProizvodnjeDelegat(object sender, EventArgs e);
        public event NaPromjenuGodineProizvodnjeDelegat NaPromjenuGodineProizvodnje;

        public string naziv = "";
        public int godinaProizvodnje;
        public double osnovnaCijena;

        internal double Starost()
        {
            double starost = 0;
            double tekucaGodina = 2019;
            return tekucaGodina - starost;
        }

        static double UkupnaCijena()
        {
            double ukupnaCijena = 0;
            osnovnaCijena = unos

                if (osnovnaCijena <= 70000)
            {
                ukupnaCijena = osnovnaCijena * 1.3;
            }
            else if (osnovnaCijena > 70000 && osnovnaCijena < 100000)
            {
                ukupnaCijena = osnovnaCijena * 1.4;
            }
            else if (osnovnaCijena >= 100000)
            {
                ukupnaCijena = osnovnaCijena * 1.5;
            }
            return ukupnaCijena;
        }
    }   
    }
}
