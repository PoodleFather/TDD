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
            five.Times(2);
            //Assert
            Assert.AreEqual(10,five.Amount);

            five.Times(3);
            Assert.AreEqual(15, five.Amount);

        }
    }
}
