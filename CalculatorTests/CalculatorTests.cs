using System.Runtime.InteropServices;
using NUnit.Framework;

namespace CalculatorTests
{
    public class Tests
    {
        Calculator cal;

        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
        }

        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(30, cal.Add(10, 20));
        }

        [Test]
        public void TestSubtract()
        {
            Assert.AreEqual(10, cal.Subtract(20, 10));
        }

        [Test]
        public void TestMultiply()
        {
            Assert.AreEqual(50, cal.Multiply(10, 5));
        }

        [Test]
        public void TestDivide()
        {
            Assert.AreEqual(5, cal.Divide(20, 4));
        }

        [Test]
        public void TestDivideByZero()
        {
            Assert.Throws<System.DivideByZeroException>(() => cal.Divide(10, 0));
        }
    }
}