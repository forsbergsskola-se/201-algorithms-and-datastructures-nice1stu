using System.Diagnostics;
using NUnit.Framework;

namespace TurboCollections.Tests
{
    [TestFixture]
    public class TurboSortTests
    {
        private TurboLinkedList<int> _defaultList = new TurboLinkedList<int> { 13, 666, 2, 69, 1 };
        private List<int> _expectedSortedList = new List<int> { 1, 2, 13, 69, 666 };
        
            [Test]
        public void bubbleSort_SortsList()
        {
            var stopwatch = Stopwatch.StartNew();
            TurboSort<int>.bubbleSort(_defaultList);
            stopwatch.Stop();
            var elapsed = stopwatch.Elapsed;

            Assert.That(_defaultList, Is.EqualTo(_expectedSortedList).AsCollection);
            Console.WriteLine($"Elapsed time: {elapsed}");
        }
    }
}