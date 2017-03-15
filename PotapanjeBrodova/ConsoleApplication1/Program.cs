using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Polje : IEquatable<Polje>
    {
        public Polje(int redak, int stupac)
        {
            Redak = redak;
            Stupac = stupac;
        }

        public readonly int Redak;
        public readonly int Stupac;

        public bool Equals(Polje other)
        {
            return Redak == other.Redak && Stupac == other.Stupac;
        }
    }
}
