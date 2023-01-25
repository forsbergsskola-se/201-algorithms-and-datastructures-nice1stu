using System.Diagnostics;

namespace TurboCollections.Test;

public class SortSelectionTests
    {
        private List<int> _defaultList = new List<int> { 13, 666, 2, 69, 1 };
        private List<int> _expectedSortedList = new List<int> { 1, 2, 13, 69, 666 };

        [Test]
        public void SelectionSort_SortsList()
        {
            var stopwatch = Stopwatch.StartNew();
            var actual = SortSelection.selectionSort(_defaultList);
            stopwatch.Stop();
            var elapsed = stopwatch.Elapsed;
            
            Assert.That(actual, Is.EqualTo(_expectedSortedList).AsCollection);
            Console.WriteLine($"Elapsed time: {elapsed}");
        }
        
        [Test]
        public void QuickSortRandomizedList()
        {
            Random random = new Random();
            int[] randomlist = new int[random.Next(1, 1000)];
            for (int i = 0; i < randomlist.Length; i++)
            {
                randomlist[i] = random.Next(1, 1000);
            }

            List<int> listToSort = new List<int>(randomlist);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SortSelection.selectionSort(listToSort);
            stopwatch.Stop();

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
            Console.WriteLine(stopwatch.Elapsed);
        }
    }