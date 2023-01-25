using System.Diagnostics;

namespace TurboCollections.Test
{
    [TestFixture]
    public class SortQuickTests
    {
        [Test]
        public void TestQuickSort_WithIntegerValues()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var list = new List<int>();
            list.Add(666);
            list.Add(1);
            list.Add(2);
            list.Add(737);
            list.Add(9);
            list.Add(2);
            list.Add(6);
            list.Add(69);
            list.Add(13);

            SortQuick.QuickSort(list);
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
        public void TestQuickSort_WithStringValues()
        {
            var list = new List<string>();
            list.Add("apple");
            list.Add("banana");
            list.Add("cherry");
            list.Add("date");
            list.Add("elderberry");
            list.Add("fig");

            SortQuick.QuickSort(list);
            
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


            for (int i = 0; i < list.Count - 1; i++)
            {
                Assert.LessOrEqual(String.CompareOrdinal(list[i], list[i + 1]),0);
            }
        }

        [Test]

        public void SelectionSort()
        {
            List<int> listToSort = new List<int> { 666, 13, 1, 2, 69 };
            TurboLinkedList<int> listTarget = new TurboLinkedList<int> { 1, 2, 13, 69, 666 };
            SortQuick.QuickSort(listToSort);
            CollectionAssert.AreEqual(listTarget, listToSort);
        }

        [Test]
        public void QuickSortRandomizedList()
        {
            Random random = new Random();
            int[] randomlist = new int[random.Next(1, 1000)];
            for (int i = 0; i < randomlist.Length; i++)
            {
                randomlist[i] = random.Next(1, 100);
            }

            List<int> listToSort = new List<int>(randomlist);
            Console.WriteLine("List to Sort");
            for (int i = 0; i < listToSort.Count; i++)
            {
                Console.Write(listToSort[i] + " ");
            }
            Console.WriteLine();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SortQuick.QuickSort(listToSort);
            stopwatch.Stop();
            var elapsed = stopwatch.Elapsed;

            // Verify that the list is sorted by comparing adjacent elements
            for (int i = 1; i < listToSort.Count; i++)
            {
                Assert.That(listToSort[i-1], Is.LessThanOrEqualTo(listToSort[i]));
            }

            Console.WriteLine();
            Console.WriteLine("Sorted");
            for (int i = 0; i < listToSort.Count; i++)
            {
                Console.Write(listToSort[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Elapsed time: {elapsed}");
        }

    }
}