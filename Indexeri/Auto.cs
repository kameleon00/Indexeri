using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexeri
{
    class Auto
    {
        private string marka;
        private int godiste;

        public Auto (string m, int g)
        {
            marka = m;
            godiste = g; 
        }

        public override string ToString()
        {
            return marka + " " + godiste;
        }
    }
}
