﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
     public class TerminatorPolja
    {
        public TerminatorPolja(Mreža mreža)
        {
            this.mreža = mreža;
        }
        public void UkloniPolja(IEnumerable<Polje> polja)
        {
            //
            //mreže.UkloniPolje(r, s);
        }
        private Mreža mreža;
    }
}
