using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexeri
{
    class Korpa : IEnumerable
    {
        //Definisati klasu Korpa sa nizom artikala i preko indeksera ubacivati i ispisivati artikle iz korpe.
        private Artikal[] art = new Artikal[4];

        public Artikal this [int pozicijaArt]
        {
            get { return art[pozicijaArt]; } set { art[pozicijaArt] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            return art.GetEnumerator();
        }
    }
}

