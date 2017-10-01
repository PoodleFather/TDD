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
            //Act
            Dollar product = five.Times(2);
            
            //Assert
            Assert.AreEqual(10, product.Amount);
            //Act
            product = five.Times(3);
            //Assert
            Assert.AreEqual(15, product.Amount);
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
