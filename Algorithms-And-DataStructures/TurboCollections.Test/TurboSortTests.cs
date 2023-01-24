﻿using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace TurboCollections.Tests
{
    public class TurboSortTests
    {
        private List<int> _defaultList = new List<int> { 13, 666, 2, 69, 1 };
        private List<int> _expectedSortedList = new List<int> { 1, 2, 13, 69, 666 };

        [Test]
        public void SelectionSort_SortsList()
        {
            var stopwatch = Stopwatch.StartNew();
            var actual = TurboSort.SelectionSort(_defaultList);
            stopwatch.Stop();
            var elapsed = stopwatch.Elapsed;
            
            Assert.That(actual, Is.EqualTo(_expectedSortedList).AsCollection);
            Console.WriteLine($"Elapsed time: {elapsed}");
        }
        
        [Test]
        public void BubbleSort_SortsList()
        {
            var stopwatch = Stopwatch.StartNew();
            var actual = TurboSort.BubbleSort(_defaultList);
            stopwatch.Stop();
            var elapsed = stopwatch.Elapsed;

            Assert.That(actual, Is.EqualTo(_expectedSortedList).AsCollection);
            Console.WriteLine($"Elapsed time: {elapsed}");
        }
    }
}