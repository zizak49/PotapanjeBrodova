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
    }
}
