using NUnit.Framework;
using TurboCollections;

[TestFixture]
public class TurboQuickSortTests
{
    [Test]
    public void TestQuickSort()
    {
        int[] myArray = { 9, 5, 2, 7, 4, 1, 6, 3, 8 };
        int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        TurboQuickSort.quickSort(myArray, 0, myArray.Length - 1);
        CollectionAssert.AreEqual(expected, myArray);
    }

}