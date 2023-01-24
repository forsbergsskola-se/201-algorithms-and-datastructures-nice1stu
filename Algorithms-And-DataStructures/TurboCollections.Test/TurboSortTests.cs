using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace TurboCollections.Tests
{
    public class TurboSortTests
    {
        private TurboLinkedList<int> _defaultList = new TurboLinkedList<int> { 3, 1, 2, 4, 5 };
        private List<int> _expectedSortedList = new List<int> { 1, 2, 3, 4, 5 };

        [Test]
        public void BubbleSort_SortsList()
        {
            var stopwatch = Stopwatch.StartNew();
            TurboSort.bubbleSort(ITurboList.TurboLinkedList<> T> list);
            stopwatch.Stop();
            var elapsed = stopwatch.Elapsed;

            Assert.That(_defaultList, Is.EqualTo(_expectedSortedList).AsCollection);
            Console.WriteLine($"Elapsed time: {elapsed}");
        }
    }
}