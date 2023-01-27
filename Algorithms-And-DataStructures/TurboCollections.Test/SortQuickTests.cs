using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Diagnostics;

namespace TurboCollections.Test
{
    [TestFixture]
    public class SortQuickTests
    {/*
        [Test]
        public void TestQuickSort_WithIntegerValues()
        {
            var list = new List<int>(){666, 1, 2, 737, 9, 2, 6, 69, 13};
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SortQuick.QuickSort2Partitions(list.ToArray(), 0, list.Count - 1);
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.ElapsedMilliseconds} ms");
            
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                Assert.LessOrEqual(list[i], list[i + 1]);
            }
        }

        [Test]
        public void SelectionSort()
        {
            var listToSort = new List<int> { 666, 13, 1, 2, 69 };
            var listTarget = new List<int> { 1, 2, 13, 69, 666 };
            SortQuick.QuickSort2Partitions(listToSort.ToArray(), 0, listToSort.Count - 1);
            CollectionAssert.AreEqual(listTarget, listToSort);
        }

        [Test]
        public void QuickSortRandomizedList()
        {
            var random = new Random();
            var randomlist = new int[random.Next(1, 1000)];
            for (var i = 0; i < randomlist.Length; i++)
            {
                randomlist[i] = random.Next(1, 100);
            }

            var listToSort = new List<int>(randomlist);
            Console.WriteLine("List to Sort");
            foreach (var t in listToSort)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine();
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            SortQuick.QuickSort2Partitions(listToSort.ToArray(), 0, listToSort.Count - 1);
            stopwatch.Stop();
            var elapsed = stopwatch.Elapsed;

            // Verify that the list is sorted by comparing adjacent elements
            for (var i = 1; i < listToSort.Count; i++)
            {
                Assert.That(listToSort[i-1], Is.LessThanOrEqualTo(listToSort[i]));
            }

            Console.WriteLine();
            Console.WriteLine("Sorted");
            foreach (var t in listToSort)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Elapsed time: {elapsed}");
        }

    */}
}
