using System;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;

namespace TurboCollections.Tests
{
    public class TurboSortTests
    {
        private List<int> _defaultList = new List<int> { 3, 1, 2, 4, 5 };
        private List<int> _expectedSortedList = new List<int> { 1, 2, 3, 4, 5 };

        [Test]
        public void SelectionSort_SortsList()
        {
            var stopwatch = Stopwatch.StartNew();
            var actual = TurboSort.SelectionSort(_defaultList);
            stopwatch.Stop();
            var elapsed = stopwatch.Elapsed;
            
            CollectionAssert.AreEqual(_expectedSortedList, actual);
            Console.WriteLine($"Elapsed time: {elapsed}");
        }
    }
}