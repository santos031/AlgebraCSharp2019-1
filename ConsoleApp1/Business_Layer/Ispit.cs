using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
   
        public class Ispit
        {
            private string naziv = "Matematika";
            private string v;

            public Ispit(string v)
            {
                this.Naziv = v;
            }

            public string Naziv { get => naziv; set => naziv = value; }
        }
    }