using NUnit.Framework;
using CalculatorLibrary;
using System;

namespace CalculatorLibrary.Tests
{
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void Add_ReturnsCorrectResult()
        {
            double res = calc.Add(5, 3);
            Assert.AreEqual(8, res);
        }

        [Test]
        public void Subtract_ReturnsCorrectResult()
        {
            double res = calc.Subtract(10, 4);
            Assert.AreEqual(6, res);
        }

        [Test]
        public void Multiply_ReturnsCorrectResult()
        {
            double res = calc.Multiply(3, 4);
            Assert.AreEqual(12, res);
        }

        [Test]
        public void Divide_ReturnsCorrectResult()
        {
            double res = calc.Divide(10, 2);
            Assert.AreEqual(5, res);
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
        }

        [Test]
        public void Add_WithZero_ReturnsSameNumber()
        {
            double res = calc.Add(7, 0);
            Assert.AreEqual(7, res);
        }

        [Test]
        public void Subtract_WithZero_ReturnsSameNumber()
        {
            double res = calc.Subtract(7, 0);
            Assert.AreEqual(7, res);
        }
    }
}