using System.Diagnostics;
using NUnit.Framework;
using System;

namespace TurboCollections.Test;

public class SortSelectionTests
    {

        [Test]
        public void SelectionSort_SortsList()
        {
            List<int> _defaultList = new List<int> { 13, 666, 2, 69, 1 };
            List<int> _expectedSortedList = new List<int> { 1, 2, 13, 69, 666 };
            var stopwatch = Stopwatch.StartNew();
            List<int> resultList = SortSelection.SelectionSort(_defaultList);
            stopwatch.Stop();
            var elapsed = stopwatch.Elapsed;
        
            Assert.That(resultList, Is.EqualTo(_expectedSortedList).AsCollection);
            Console.WriteLine($"Elapsed time: {elapsed}");
        }
    
        [Test]
        public void QuickSortRandomizedList()
        {
            Random random = new Random();
            int[] randomlist = new int[random.Next(1, 100)];
            for (int i = 0; i < randomlist.Length; i++)
            {
                randomlist[i] = random.Next(1, 100);
            }

            List<int> listToSort = new List<int>(randomlist);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<int> sortedList = SortSelection.SelectionSort(listToSort);
            stopwatch.Stop();
            var elapsed = stopwatch.Elapsed;

            // Verify that the list is sorted by comparing adjacent elements
            for (int i = 1; i < sortedList.Count; i++)
            {
                Assert.That(sortedList[i-1], Is.LessThanOrEqualTo(sortedList[i]));
            }

            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.Write(sortedList[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Elapsed time: {elapsed}");
        }
    }
