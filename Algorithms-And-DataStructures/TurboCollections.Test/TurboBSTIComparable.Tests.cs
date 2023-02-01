using NUnit.Framework;

namespace TurboCollections.Test;

[TestFixture]
public class TurboBSTIComparable_Tests
{
    [Test]

    public void SearchWhenValueisPresentReturnTrue()
    {
        var tree = new TurboBSTIComparable<int>();

        tree._root = new TurboBSTIComparable<int>.Node(5);
        tree._root.Left = new TurboBSTIComparable<int>.Node(3);
        tree._root.Right = new TurboBSTIComparable<int>.Node(7);
        tree._root.Left.Left = new TurboBSTIComparable<int>.Node(2);
        tree._root.Left.Right = new TurboBSTIComparable<int>.Node(4);
        tree._root.Right.Right = new TurboBSTIComparable<int>.Node(9);

        for (int i = 1; i <= 9; i++)
        {
            var result = tree.Search(i);
            Console.WriteLine("Searching for " + i + ": " + result);
            Assert.That(result, Is.EqualTo(i == 2 || i == 3 || i == 4 || i == 5 || i == 7 || i == 9));
        }
    }

    [Test]

    public void SearchWhenValueisNotPresentReturnFalse()
    {
        var tree = new TurboBSTIComparable<int>();

        tree._root = new TurboBSTIComparable<int>.Node(5);
        tree._root.Left = new TurboBSTIComparable<int>.Node(3);
        tree._root.Right = new TurboBSTIComparable<int>.Node(7);

        for (int i = 1; i <= 9; i++)
        {
            var result = tree.Search(i);
            Console.WriteLine("Searching for " + i + ": " + result);
            Assert.That(result, Is.EqualTo(i == 3 || i == 5 || i == 7));
        }
    }
    
    [Test]
    public void InsertMethodShouldInsertValueIntoTheTree()
    {
        var tree = new TurboBSTIComparable<int>();

        tree.Insert(5);
        tree.Insert(3);
        tree.Insert(7);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(9);

        for (int i = 1; i <= 9; i++)
        {
                var result = tree.Search(i);
                Console.WriteLine("Searching for " + i + ": " + result);
                Assert.That(result, Is.EqualTo(i == 2 || i == 3 || i == 4 || i == 5 || i == 7 || i == 9));
        }
    }
    
    [Test]
    public void RemoveMethodRemovesNodeWithGivenValue()
    {
        var tree = new TurboBSTIComparable<int>();

        tree._root = new TurboBSTIComparable<int>.Node(5);
        tree._root.Left = new TurboBSTIComparable<int>.Node(3);
        tree._root.Right = new TurboBSTIComparable<int>.Node(7);
        tree._root.Left.Left = new TurboBSTIComparable<int>.Node(2);
        tree._root.Left.Right = new TurboBSTIComparable<int>.Node(4);
        tree._root.Right.Right = new TurboBSTIComparable<int>.Node(9);

        tree.Remove(3);
        for (int i = 1; i <= 9; i++)
        {
            var result = tree.Search(i);
            Console.WriteLine("Searching for " + i + ": " + result);
            Assert.That(result, Is.EqualTo(i == 2 || i == 4 || i == 5 || i == 7 || i == 9));
        }
    }

}