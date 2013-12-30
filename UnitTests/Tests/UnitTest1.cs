using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator aCalculator;

        [TestInitialize]
        public void Initialize()
        {
            aCalculator = new Calculator(100,-100);
        }

        [TestMethod]
        public void Add()
        {
            int result = aCalculator.Add(2, 2);
            Assert.AreEqual(4,result);
        }

        [TestMethod]
        public void Add2()
        {
            int result = aCalculator.Add(2, 5);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Substract()
        {
            int result = aCalculator.Substract(5, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void SubstractExcedingLowerLimit()
        {
            int result = aCalculator.Substract(5, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void SubstractWithNegativeResult()
        {
            int result = aCalculator.Substract(3, 5);
            Assert.AreEqual(-2, result);
        }
        

    }
}
