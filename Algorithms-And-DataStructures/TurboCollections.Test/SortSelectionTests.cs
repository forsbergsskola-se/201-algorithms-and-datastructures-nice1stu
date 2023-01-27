using System.Diagnostics;

namespace TurboCollections.Test;

public class SortSelectionTests
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
            SortSelection.SelectionSort(listToSort);
            stopwatch.Stop();
            var elapsed = stopwatch.Elapsed;

            // Verify that the list is sorted by comparing adjacent elements
            for (int i = 1; i < listToSort.Count; i++)
            {
                Assert.That(listToSort[i-1], Is.LessThanOrEqualTo(listToSort[i]));
            }

            for (int i = 0; i < listToSort.Count; i++)
            {
                Console.Write(listToSort[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Elapsed time: {elapsed}");
        }
    }