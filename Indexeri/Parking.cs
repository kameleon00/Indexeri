using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexeri
{
    class Parking
    {
        //Definisati klasu Parking sa nizom auta i preko indexera ubacitivati i ispisivati auta iz parkinga
        private Auto[] niz2 = new Auto[20];
        
        public Auto this [int pozicijaAuta]
        {
            get { return niz2[pozicijaAuta]; }
            set { niz2[pozicijaAuta] = value; }
        }
        /*Da bi sa nizom u indexiranoj klasi moglo da se radi direktno sa foreach iteracijom neophodno je
          da indexirana klasa implementira Ienumerable interface i metodu GetEnumerator.*/
    }
}
