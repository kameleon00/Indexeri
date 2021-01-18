using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexeri
{

    /*Da bi sa nizom u indexiranoj klasi moglo da se radi direktno sa foreach iteracijom neophodno je
        da indexirana klasa implementira Ienumerable interface i metodu GetEnumerator*/

    class ParkingIEnumerable : IEnumerable
    {
        private Auto[] autos = new Auto[4];
        
        public Auto this [int position]
        {
            get { return autos[position]; } set { autos[position] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            return autos.GetEnumerator();
        }
    }
}
