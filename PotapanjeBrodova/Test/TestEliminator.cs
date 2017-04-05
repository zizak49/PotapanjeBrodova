using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TestEliminator
    {
        private Mreža mreže;
        private TerminatorPolja terminator;
        [TestInitialize()]
        public void PripremimoMrežu() {
            mreže = new Mreža(10, 10);
            terminator = new TerminatorPolja(mreže);
        }
        [TestMethod]
        public void EliminatorPolja_UklanjaSvaPoljaOkoBrodaUsrediniMreže()
        {
            IEnumerable<Polje> polja = new Polje[] { new Polje(3, 3),new Polje(3,4) };   
            terminator.UkloniPolja(polja);
            Assert.AreEqual(88,mreže.DajSlobodnaPolja().Count());
            // dodaj provjeru dal su izbaceni (3,3) i (3,4), (2,2), (2,5), (4,2), (4,5)
        }

        [TestMethod]
        public void EliminatorPolja_UklanjaSvaPoljaOkoBrodaUz_GornjiRubMreze()
        {

        }

        [TestMethod]
        public void EliminatorPolja_UklanjaSvaPoljaOkoBrodaUz_GornjemLijevomKutuMreže()
        {

        }

        [TestMethod]
        public void EliminatorPolja_UklanjaSvaPoljaOkoBrodaUz_DoljnjemLijevomKutuMreže()
        {

        }
        [TestMethod]
        public void EliminatorPolja_UklanjaSvaPoljaOkoBrodaUz_GornjemDesnomKutuMreže()
        {

        }

        [TestMethod]
        public void EliminatorPolja_UklanjaSvaPoljaOkoBrodaUz_DoljnjemDesnomKutuMreže()
        {

        }
    }
}
