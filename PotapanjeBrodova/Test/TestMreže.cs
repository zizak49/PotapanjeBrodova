using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Linq;

namespace Test
{
    [TestClass]
    public class TestMreže {

        [TestMethod]
        public void Mreža_DajSlobodnaPoljaVracaSvaPoljaZaPocetnuMrezu()
        {
            Mreža m = new Mreža(5,5);
            m.UkloniPolje(1, 1);
            Assert.AreEqual(25, m.DajSlobodnaPolja().Count());

        }

        [TestMethod]
        public void Mreža_DajSlobodnaPoljaVraca24PoljaZaMrzu5x5Nakon1Uklonjenog()
        {
            Mreža m = new Mreža(5,5);
            m.UkloniPolje(1, 1);
            m.UkloniPolje(4, 4);
            Assert.AreEqual(24, m.DajSlobodnaPolja());
            Assert.IsFalse(m.DajSlobodnaPolja().Contains(new Polje(1, 1)));
            Assert.IsFalse(m.DajSlobodnaPolja().Contains(new Polje(4, 4)));
        }

        [TestMethod]
        public void Mreža_UkloniPoljeBacaIznimuZaNepostojeciRredak()
        {
            try
            {
                Mreža m = new Mreža(5, 5);
                m.UkloniPolje(6, 1);
                Assert.Fail();
            }
            catch (IndexOutOfRangeException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
            
        }

        [TestMethod]
        public void Mreža_UkloniPoljeBacaIznimuZaNepostojeciStupac()
        {
            try
            {
                Mreža m = new Mreža(5, 5);
                m.UkloniPolje(1, 6);
                Assert.Fail();
            }
            catch (IndexOutOfRangeException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Mreža_DajNizovePoljaVraća3NizaZaBrodoveuHorz5()
        {
           Mreža m = new Mreža(1, 5);
           Assert.AreEqual (3,m.DajNizoveSlobodnihPolja(3).count());
        }

        [TestMethod]
        public void Mreža_DajNizovePoljaVraća3NizaZaBrodoveuHorzduljune4()
        {
            Mreža m = new Mreža(1, 4);
            Assert.AreEqual(3, m.DajNizoveSlobodnihPolja(5).count());
        }

        [TestMethod]
        public void Mreža_DajNizovePoljaVraća3NizaZaBrodoveuVertikalno5()
        {
            Mreža m = new Mreža(5, 1);
            Assert.AreEqual(3, m.DajNizoveSlobodnihPolja(3).count());
        }

        [TestMethod]
        public void Mreža_DajNizovePoljaVraća3NizaZaBrodoveuVertikalnozduljune4()
        {
            Mreža m = new Mreža(4, 1);
            Assert.AreEqual(3, m.DajNizoveSlobodnihPolja(5).count());
        }

    }
    }

