using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexeri
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------------------------------------------------------------
            // -------------------------------------------------------------------------------------------
            Console.WriteLine("==========================================================================");

            KlasaIndeksera obj = new KlasaIndeksera();
            obj[0] = "prvi";
            obj[1] = "drugi";
            obj[2] = "treci";
            obj[3] = "cetvrti";
            obj[4] = "peti";

            Console.WriteLine("-----------------");
            Console.WriteLine("Primer ideksera |");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(" | {0} | {1} | {2} | {3} | {4} | ", obj[0], obj[1], obj[2], obj[3], obj[4]);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("==========================================================================");
            // -------------------------------------------------------------------------------------------
            // -------------------------------------------------------------------------------------------

            Parking park = new Parking();
            park[0] = new Auto("Skoda", 2000);
            park[1] = new Auto("BMW", 2005);
            park[2] = new Auto("Audi", 2007);
            park[3] = new Auto("Yugo", 1998);

            Console.WriteLine("------------------");
            Console.WriteLine("Auto na parkingu |");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(" | {0} | {1} | {2} | {3} | ", park[0], park[1], park[2], park[3]);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("==========================================================================");
            // -------------------------------------------------------------------------------------------
            // -------------------------------------------------------------------------------------------

            ParkingIEnumerable parki = new ParkingIEnumerable();
            parki[0] = new Auto("Skoda", 2000);
            parki[1] = new Auto("BMW", 2005);
            parki[2] = new Auto("Audi", 2007);
            parki[3] = new Auto("Yugo", 1998);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Auto na parkingu IEnumerable |");
            Console.WriteLine("-------------------------------------------------");
            foreach(Auto a in parki)
            {
                Console.Write(" | {0}", a);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("==========================================================================");
            // -------------------------------------------------------------------------------------------
            // -------------------------------------------------------------------------------------------

            Korpa korp = new Korpa();
            korp[0] = new Artikal("Koka Kola", 99);
            korp[1] = new Artikal("Napolitanke", 75);
            korp[2] = new Artikal("Cokolada", 85);
            korp[3] = new Artikal("Pivo", 80);

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Artikal u korpi IEnumerable |");
            Console.WriteLine("---------------------------------------------------------");
            foreach(Artikal a in korp)
            {
                Console.Write(" | {0}", a);
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("==========================================================================");
            // -------------------------------------------------------------------------------------------
            // -------------------------------------------------------------------------------------------


            Console.ReadKey();
        }
    }
}
