using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexeri
{
    class KlasaIndeksera
    {
        // klasa koristi this pokazivac pri deklaraciji niza 

        private string[] niz = new string[5];

        public string this[int indeksniza]
        {
            get
            {
                return niz[indeksniza];
            }
            set
            {
                niz[indeksniza] = value;
            }

        }
    }
}
