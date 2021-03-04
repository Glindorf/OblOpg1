using Microsoft.VisualStudio.TestTools.UnitTesting;
using OblOpg1;
using System;
using System.Collections.Generic;
using System.Text;

namespace OblOpg1.Tests
{
    [TestClass()]
    public class BeerTests
    {
        private Beer beer;

        [TestInitialize]
        public void init()
        {
            beer = new Beer(1, "RoastBeer", 12.0, 15.3);
        }

        /// <summary>
        /// Her testes Id 
        /// </summary>

        [TestMethod]
        public void IdTest()
        {
            Assert.AreEqual(1, beer.Id);
            beer.Id = 2;
            Assert.AreEqual(2, beer.Id);
        }

        /// <summary>
        /// Her testes navn. Det skal være på mindst fire characters, derfor tester jeg, at den kaster en exception ved kun tre.
        /// </summary>

        [TestMethod]
        public void NameTest()
        {
            Assert.AreEqual("RoastBeer", beer.Name);
            beer.Name = "Abcd";
            Assert.AreEqual("Abcd", beer.Name);
            Assert.ThrowsException<ArgumentException>(() => beer.Name = "Abc");
        }

        /// <summary>
        /// Her testet Price. Prisen skal være over 0,-. Derfor tester jeg 0 og -11, der begge er uden for det tilladte interval.
        /// </summary>

        [TestMethod]
        public void PriceTest()
        {
            beer.Price= 12;
            Assert.AreEqual(12, beer.Price);
            beer.Price = 111.5;
            Assert.AreEqual(111.5, beer.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Price = 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Price = -11);
        }

        /// <summary>
        /// Her tester jeg Abv (Alcohol by volume). Værdien skal være mellem 0 og 100, ellers kastes en Exception, derfor testes -1 og 101, der begge ligger lige uden for intervallet, der er tilladt.
        /// </summary>

        [TestMethod]
        public void AbvTest()
        {
            beer.Abv = 12.2;
            Assert.AreEqual(12.2, beer.Abv);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Abv = -1);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => beer.Abv = 101);
        }
    }
}