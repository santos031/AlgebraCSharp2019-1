using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_8._3._1_vozila
{
    class Automobili : System.Collections.CollectionBase
    {
        public int Add(Automobil automobil)
        {
            return InnerList.Add(automobil);
        }

        public void Remove(Automobil automobil)
        {
            InnerList.Remove(automobil);
        }

        public Automobil this[int index]
        {
            get
            {
                return (Automobil)InnerList[index];
            }
        }
    }
}
