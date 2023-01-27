using System.Diagnostics;

namespace TurboCollections.Tests
{/*
    [TestFixture]
    public class TurboSortTests
    {

        [Test]
        public void SelectionSort_SortsList()
        {
            List<int> _defaultList = new List<int> { 13, 666, 2, 69, 1 };
            List<int> _expectedSortedList = new List<int> { 1, 2, 13, 69, 666 };
            var stopwatch = Stopwatch.StartNew();
            SortSelection.SelectionSort(_defaultList);
            stopwatch.Stop();
            var elapsed = stopwatch.Elapsed;
            
            Assert.That(_defaultList, Is.EqualTo(_expectedSortedList).AsCollection);
            Console.WriteLine($"Elapsed time: {elapsed}");
        }
        
        [Test]
        public void SelectionSortWorksForRandomUnorderedInput()
        {
            [Test]
            void SelectionSortWorksForRandomUnorderedInput()
            {
                var consecutiveData = Enumerable.Range(0, Random.Shared.Next(100, 200));
                var randomData = consecutiveData.Select(_ => Random.Shared.Next(0, 100)).ToArray();
                TurboLinkedList<int> list = new TurboLinkedList<int>();
                list.AddRange(randomData);

                Assert.That(list, Is.EquivalentTo(randomData));
                Assert.That(list, Is.Ordered);
            }
        }
    }*/
}