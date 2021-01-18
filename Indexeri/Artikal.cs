using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexeri
{
    class Artikal //Definisati klasu Artikal sa atributima naziv i cena.
    {
        private string naziv;
        private int cena;

        public Artikal (string naz, int cn)
        {
            naziv = naz;
            cena = cn;
        }

        public override string ToString()
        {
            return naziv + " " + cena;
        }
    }
}
