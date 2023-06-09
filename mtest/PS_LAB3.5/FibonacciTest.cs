using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static PS_LAB3._5.Fibonacci;

namespace PS_LAB3._5
{
    [TestClass]
    public class FibonacciTest
    {
        private Fibonacci fibonacci;
        [TestInitialize]
        public void SetUp()
        {
            fibonacci = new Fibonacci();
        }
        [TestMethod]
        public void ValidParameter()
        {
            int expected = 2;
            int actual = fibonacci.CalcularFibonacci(3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NegativeParameter()
        {
            Assert.ThrowsException<ArgumentException>(() => { 
                fibonacci.CalcularFibonacci(-3); 
            });

        }
        [TestMethod]
        public void OverflowExeption()
        {
            /*int expected = 12356789111;
            int actual = fibonacci.CalcularFibonacci(100);
            Assert.AreEqual(expected, actual);
            */
            Assert.ThrowsException<ArgumentException>(() => {
                fibonacci.CalcularFibonacci(200);
            });
        }
        [TestMethod]
        public void DifferentAmountParameter()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                fibonacci.CalcularFibonacci(1, 200);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                fibonacci.CalcularFibonacci();
            });

        }
        [TestMethod]
        public void DecimalParameter()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                fibonacci.CalcularFibonacci(1.2);
            });
        }
        
        [TestMethod]
        public void StringParameter()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                fibonacci.CalcularFibonacci("PS");
            });
        }

        [TestMethod]
        public void NullParameter()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                int? n=null;
                fibonacci.CalcularFibonacci(n);

                int? n1 = 5;
                int expected = 5;
                int actual = fibonacci.CalcularFibonacci(n1);

                Assert.AreEqual(expected, actual);
            });
        }


        [TestMethod]
        public void ZeroParameter()
        {
            Assert.ThrowsException<ArgumentException>(() => {
                fibonacci.CalcularFibonacci(0);
            });
        }
        [TestMethod]
        public void LongTypeParameter()
        {
            long n = 13;
            Assert.ThrowsException<ArgumentException>(() => {
                fibonacci.CalcularFibonacci(n);
            });
        }
        [TestMethod]
        public void FloatTypeParameter()
        { 
            float n = 13;
            Assert.ThrowsException<ArgumentException>(() => {
                fibonacci.CalcularFibonacci(n);
            });
        }
    }

}
