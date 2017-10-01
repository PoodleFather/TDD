using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.Currency;

namespace TDD.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMulitiplication()
        {
            //Arrange
            Dollar five = new Dollar(5);
            //Assert
            Assert.AreEqual(new Dollar(10), five.Times(2));
            Assert.AreEqual(new Dollar(15), five.Times(3));
        }
        [TestMethod]
        public void TestEquality()
        {
            //Assert
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
