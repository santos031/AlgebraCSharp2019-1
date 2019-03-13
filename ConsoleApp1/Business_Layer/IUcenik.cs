using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    internal interface IUcenik
    {
        double Prosjek();
        string ToString();
        void PrijaviIspit(Ispit ispit);
    }
}