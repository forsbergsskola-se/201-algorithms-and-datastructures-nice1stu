using NUnit.Framework;

namespace TurboCollections
{
    [TestFixture]
    public class TurboFibonacciTests
    {
        [Test]
        public void TestFibonacciRecursive()
        {
            Assert.That(TurboFibonacci.FibonacciRecursive(0), Is.EqualTo(0));
            Assert.That(TurboFibonacci.FibonacciRecursive(1), Is.EqualTo(1));
            Assert.That(TurboFibonacci.FibonacciRecursive(2), Is.EqualTo(1));
            Assert.That(TurboFibonacci.FibonacciRecursive(3), Is.EqualTo(2));
            Assert.That(TurboFibonacci.FibonacciRecursive(4), Is.EqualTo(3));
            Assert.That(TurboFibonacci.FibonacciRecursive(40), Is.EqualTo(102334155));
        }
    }
}