using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;

namespace Test
{
    [TestClass]
    public class TestRedaFinksneDuljine
    {
        [TestMethod]
        public void RedFinksneDuljine_DodavanjeJednogČlanaPovećavaDuljinuReda()
        {
            RedFiksneDuljine<Polje> r = new RedFiksneDuljine<Polje>(3);
            Assert.AreEqual(0, r.Count);
            r.Enqueue(new Polje(0, 0));
            Assert.AreEqual(1, r.Count);
        }

        [TestMethod]
        public void RedFinksneDuljine_DodavanjeČetvrtogČlanaNePovećavaRedDuljine3()
        {
            RedFiksneDuljine<Polje> r = new RedFiksneDuljine<Polje>(3);
            Assert.AreEqual(0, r.Count);
            r.Enqueue(new Polje(0, 0));
            r.Enqueue(new Polje(1, 0));
            r.Enqueue(new Polje(3, 0));
            Assert.AreEqual(3, r.Count);
            r.Enqueue(new Polje(3, 0));
            Assert.AreEqual(3, r.Count);
        }

        [TestMethod]
        public void Dodavanje4ČlanaIzbacuje1ČlanIzRedaDuljine3()
        {
            RedFiksneDuljine<Polje> r = new RedFiksneDuljine<Polje>(3);
            r.Enqueue(new Polje(0, 0));
            r.Enqueue(new Polje(1, 0));
            r.Enqueue(new Polje(3, 0));
            Assert.IsTrue(r.Contains(new Polje(0,0)));
            r.Enqueue(new Polje(3, 0));
            Assert.IsFalse(r.Contains(new Polje(0, 0)));
        }

        [TestMethod]
        public void BrisanjeUklanjaSveČlanoveIzReda()
        {
            RedFiksneDuljine<Polje> r = new RedFiksneDuljine<Polje>(3);
            r.Enqueue(new Polje(0, 0));
            r.Enqueue(new Polje(1, 0));
            r.Enqueue(new Polje(3, 0));
            r.Clear();
            Assert.AreEqual(0, r.Count);
        }
    }
}
