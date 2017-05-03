using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PotapanjeBrodova
{
    public enum TaktikaGađanja
    {
        Nasumično,
        Kružno,
        Linijsko
    }
    public class Topništvo
    {
        private Mreza mreža;
        private List<int> duljineBrodova;


        public TaktikaGađanja TaktikaGađanja { get; private set; }
        public Topništvo(int redak, int stupac, IEnumerable<int> duljineBrodova)
        {
            mreža = new Mreza(redak, stupac);
            this.duljineBrodova = new List<int>(duljineBrodova);
            TaktikaGađanja = TaktikaGađanja.Nasumično;
        }
        public void ObradiGađanje(RezultatGađanja rezultat)
        {
            if (rezultat == RezultatGađanja.Promašaj)
                return;
            if (rezultat == RezultatGađanja.Pogodak)
            {
                switch (TaktikaGađanja)
                {
                    case TaktikaGađanja.Nasumično:
                        PromjeniTaktikuUKružno();
                        return;
                    case TaktikaGađanja.Kružno:
                        PromjeniTaktikuULinijsko();
                        return;
                    case TaktikaGađanja.Linijsko:
                        return;
                    default:
                        Debug.Assert(false);
                        break;

                }
            }
            Debug.Assert(rezultat == RezultatGađanja.Potopljen);
            PromjeniTaktikuUNasumično();

        }
        void PromjeniTaktikuUKružno()
        {
            TaktikaGađanja = TaktikaGađanja.Kružno;
        }
        void PromjeniTaktikuULinijsko()
        {
            TaktikaGađanja = TaktikaGađanja.Linijsko;
        }
        void PromjeniTaktikuUNasumično()
        {
            TaktikaGađanja = TaktikaGađanja.Nasumično;
        }
    }
}
