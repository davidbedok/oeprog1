using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo;

namespace DiceGameTest
{
    [TestClass]
    public class CalculatorTest
    {

        [TestMethod]
        public void Sample_test_method()
        {
            double i = Math.PI * Math.E * 5;
            Assert.AreEqual(42, i, 3, "The number " + i + " is not close enough for the meaning of life!");
        }

        [TestMethod]
        public void Integer_division_shuold_be_working()
        {
            int result = Calculator.CalculateIntegerDivision(42, 10);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Integer_division_shuold_be_working2()
        {
            int result = Calculator.CalculateIntegerDivision(75564242, 4357);
            Assert.AreEqual(75564242 / 4357, result);
        }

        [TestMethod]
        public void Integer_division_shuold_be_working_in_the_special_case()
        {
            int result = Calculator.CalculateIntegerDivision(42, 6);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_by_zero_should_failed()
        {
            int result = Calculator.CalculateIntegerDivision(42, 0);
            Assert.Fail("Divide by zero didn't cause failure!");
        }

    }
}
