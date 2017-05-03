﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class Flota : IGađani
    {
        public void DodajBrod(IEnumerable<Polje> polja)
        {
            brodovi.Add(new Brod(polja));
        }

        public int BrojBrodova
        {
            get { return brodovi.Count; }
        }

        public RezultatGađanja Gađaj(Polje polje)
        {
            foreach (Brod brod in brodovi)
            {
                var rezultat = brod.Gađaj(polje);
                if (rezultat != RezultatGađanja.Promašaj)
                    return rezultat;
            }
            return RezultatGađanja.Promašaj;
        }

        public List<Brod> brodovi = new List<Brod>();
    }
}