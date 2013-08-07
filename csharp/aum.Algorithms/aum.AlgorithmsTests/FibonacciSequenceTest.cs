using Microsoft.VisualStudio.TestTools.UnitTesting;
using aum.Algorithms;

namespace aum.AlgorithmsTests
{
    [TestClass]
    public class FibonacciSequenceTest
    {
        [TestMethod]
        public void ShouldReturnTheRightFibonacciNumberBasedOnIndex()
        {
            FibonacciSequence fibonacciSequence = new FibonacciSequence();
            Assert.AreEqual(0, fibonacciSequence.GetByIndex(0));
            Assert.AreEqual(1, fibonacciSequence.GetByIndex(1));
            Assert.AreEqual(1, fibonacciSequence.GetByIndex(2));
            Assert.AreEqual(2, fibonacciSequence.GetByIndex(3));
            Assert.AreEqual(3, fibonacciSequence.GetByIndex(4));
            Assert.AreEqual(5, fibonacciSequence.GetByIndex(5));
            Assert.AreEqual(8, fibonacciSequence.GetByIndex(6));
            Assert.AreEqual(13, fibonacciSequence.GetByIndex(7));
            Assert.AreEqual(21, fibonacciSequence.GetByIndex(8));
            Assert.AreEqual(34, fibonacciSequence.GetByIndex(9));
            Assert.AreEqual(55, fibonacciSequence.GetByIndex(10));
            Assert.AreEqual(89, fibonacciSequence.GetByIndex(11));
            Assert.AreEqual(144, fibonacciSequence.GetByIndex(12));
            Assert.AreEqual(233, fibonacciSequence.GetByIndex(13));
            Assert.AreEqual(377, fibonacciSequence.GetByIndex(14));
            Assert.AreEqual(610, fibonacciSequence.GetByIndex(15));
            Assert.AreEqual(987, fibonacciSequence.GetByIndex(16));
            Assert.AreEqual(1597, fibonacciSequence.GetByIndex(17));
            Assert.AreEqual(2584, fibonacciSequence.GetByIndex(18));
        }
    }
}