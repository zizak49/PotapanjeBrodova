﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class Mreža
    {
        public Mreža(int redaka, int stupaca)
        {
            Redaka = redaka;
            Stupaca = stupaca;
            polja = new Polje[redaka, stupaca];
            for (int r = 0; r < redaka; ++r)
            {
                for (int s = 0; s < stupaca; ++s)
                    polja[r, s] = new Polje(r, s);
            }
        }

        public IEnumerable<Polje> DajSlobodnaPolja()
        {
            List<Polje> p = new List<Polje>();
            for (int r = 0; r < Redaka; ++r)
            {
                for (int s = 0; s < Stupaca; ++s)
                {
                    if (polja[r, s] != null)
                        p.Add(polja[r, s]);
                }
            }
            return p;
        }

        public void UkloniPolje(int redak, int stupac)
        {
            polja[redak, stupac] = null;
        }

        public void UkloniPolje(Polje p)
        {
            UkloniPolje(p.Redak, p.Stupac);
        }

        public IEnumerable<IEnumerable<Polje>> DajNizoveSlobodnihPolja(int duljinaNiza)
        {
            List<IEnumerable<Polje>> nizovi = DajNizoveSlobodnihPoljaUHorizontalnomSmjeru(duljinaNiza);
            nizovi.AddRange(DajNizoveSlobodnihPoljaUVertikalnomSmjeru(duljinaNiza));
            return nizovi;
        }

        IEnumerable<int> DajNizBrojeva(int maxVrijednost)
        {
            for (int i = 0; i < maxVrijednost; ++i)
                yield return i;
        }

        private List<IEnumerable<Polje>> DajNizoveSlobodnihPolja(int duljinaNiza, IEnumerable<int> vanjskiIndeks, IEnumerable<int> nutarnjiIndeks, Func<int, int, Polje> dohvatPolja)
        {
            List<IEnumerable<Polje>> nizovi = new List<IEnumerable<Polje>>();
            foreach (int i in vanjskiIndeks)
            {
                RedFiksneDuljine<Polje> red = new RedFiksneDuljine<Polje>(duljinaNiza);
                foreach (int j in nutarnjiIndeks)
                {
                    Polje polje = dohvatPolja(i, j);
                    if (polje == null)
                        red.Clear();
                    else
                    {
                        red.Enqueue(polje);
                        if (red.Count == duljinaNiza)
                            nizovi.Add(new List<Polje>(red));
                    }
                }
            }
            return nizovi;
        }

        private List<IEnumerable<Polje>> DajNizoveSlobodnihPoljaUHorizontalnomSmjeru(int duljinaNiza)
        {
            return DajNizoveSlobodnihPolja(duljinaNiza, DajNizBrojeva(Redaka), DajNizBrojeva(Stupaca), (i, j) => polja[i, j]);
        }

        private List<IEnumerable<Polje>> DajNizoveSlobodnihPoljaUVertikalnomSmjeru(int duljinaNiza)
        {
            return DajNizoveSlobodnihPolja(duljinaNiza, DajNizBrojeva(Stupaca), DajNizBrojeva(Redaka), (i, j) => polja[j, i]);
        }

        private Polje[,] polja;

        public readonly int Redaka;
        public readonly int Stupaca;
    }
}
