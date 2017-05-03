using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotapanjeBrodova
{
    public interface IPucač
    {
        Polje Gađaj();
        void ObradiGađanje(RezultatGađanja rezultat);
    }
}
