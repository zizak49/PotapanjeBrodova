using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    [TestClass]
    public class TestBrodograditelja
    {
        [TestMethod]
        public void Brodograditelj_SloziFlotuVracaFlotuS_BrodovimaZadaneDuljine()
        {

            Brodograditelj b = new Brodograditelj();
            Mreža mreža = new Mreža(10, 10);
            IEnumerable<int> duljineBrodova = new int[] { 5, 4, 4, 3, 3, 3, 2, 2, 2, 2 };

            Flota f = b.SloziFlotu(mreža, duljineBrodova);
            Assert.AreEqual(duljineBrodova.Count(), f.BrojBrodova);
            // TODO: provjera ima li samo jedan broda duljine 5
            // TODO: provjera ima li samo dva broda duljine 4
            // TODO: provjera ima li samo tri broda duljine 3



        }
    }
}
