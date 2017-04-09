using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    [TestClass]
    public class TestTerminatoraPolja
    {
        private Mreža mreža;
        private TerminatorPolja terminator;

        [TestInitialize()]
        public void PripremiMrežuITerminatora()
        {
            mreža = new Mreža(10, 10);
            terminator = new TerminatorPolja(mreža);
        }

        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUSrediniMreže()
        {
            IEnumerable<Polje> polja = new Polje[] { new Polje(3, 3), new Polje(3, 4) };
            terminator.UkloniPolja(polja);
            Assert.AreEqual(88, mreža.DajSlobodnaPolja().Count());
            // dodaj provjeru da su izbačeni (3, 3) i (3, 4), (2, 2), (2, 5), (4, 2), (4, 5)
        }

        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUzGornjiRubMreže()
        {

        }

        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUGornjemLijevomKutuMreže()
        {

        }

        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUGornjemDesnomKutuMreže()
        {

        }

        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUDonjemDesnomKutuMreže()
        {

        }

        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUDonjemLijevomKutuMreže()
        {

        }
    }
}
