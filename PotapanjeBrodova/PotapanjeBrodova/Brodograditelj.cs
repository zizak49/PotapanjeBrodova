using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class Brodograditelj
    {
        public Flota SloziFlotu(Mreža mreža,IEnumerable<int> duljineBrodova)
        {
            Flota flota = new Flota();
            TerminatorPolja terminator = new TerminatorPolja(mreža);

            foreach (int i in duljineBrodova) {
                var nizovi = mreža.DajNizoveSlobodnihPolja(i);
                
                int index= slučajni.Next(nizovi.Count());
                var niz=nizovi.ElementAt(index);
                flota.DodajBrod(niz);
                terminator.UkloniPolja(niz);
            }
            return flota;
         
        }
        // todo: obrati paznju da se nemugu svi brodovi sloziti
        private Random slučajni = new Random();

    }
}
