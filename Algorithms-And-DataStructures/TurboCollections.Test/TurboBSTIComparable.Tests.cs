namespace TurboCollections.Test;

[TestFixture]
public class TurboBstiComparableTests
{
    [Test]

    public void SearchWhenValueisPresentReturnTrue()
    {
        var tree = new TurboBstiComparable<int>();

        tree.Root = new TurboBstiComparable<int>.Node(5);
        tree.Root.Left = new TurboBstiComparable<int>.Node(3);
        tree.Root.Right = new TurboBstiComparable<int>.Node(7);
        tree.Root.Left.Left = new TurboBstiComparable<int>.Node(2);
        tree.Root.Left.Right = new TurboBstiComparable<int>.Node(4);
        tree.Root.Right.Right = new TurboBstiComparable<int>.Node(9);

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
        var tree = new TurboBstiComparable<int>();

        tree.Root = new TurboBstiComparable<int>.Node(5);
        tree.Root.Left = new TurboBstiComparable<int>.Node(3);
        tree.Root.Right = new TurboBstiComparable<int>.Node(7);

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
        var tree = new TurboBstiComparable<int>();

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
        var tree = new TurboBstiComparable<int>();

        tree.Root = new TurboBstiComparable<int>.Node(5);
        tree.Root.Left = new TurboBstiComparable<int>.Node(3);
        tree.Root.Right = new TurboBstiComparable<int>.Node(7);
        tree.Root.Left.Left = new TurboBstiComparable<int>.Node(2);
        tree.Root.Left.Right = new TurboBstiComparable<int>.Node(4);
        tree.Root.Right.Right = new TurboBstiComparable<int>.Node(9);

        tree.Remove(3);
        for (int i = 1; i <= 9; i++)
        {
            var result = tree.Search(i);
            Console.WriteLine("Searching for " + i + ": " + result);
            Assert.That(result, Is.EqualTo(i == 2 || i == 4 || i == 5 || i == 7 || i == 9));
        }
    }

    [Test]
    public void GetInOrderEnumerator_ReturnsInOrderElements()
    {
        var tree = new TurboBstiComparable<int>();
        tree.Insert(3);
        tree.Insert(1);
        tree.Insert(4);
        tree.Insert(2);
        tree.Insert(3);
        tree.Insert(5);
        tree.Insert(6);
        tree.Insert(7);

        var inOrder = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        var enumerator = tree.GetInOrderEnumerator();

        int i = 0;
        while (enumerator.MoveNext())
        {
            Assert.That(enumerator.Current, Is.EqualTo(inOrder[i]));
            i++;
        }
    }


    [Test]
    public void GetEnumeratorReturnReverseOrderTraversal()
    {
        var tree = new TurboBstiComparable<int>();
        tree.Insert(3);
        tree.Insert(1);
        tree.Insert(4);
        tree.Insert(2);
        tree.Insert(3);
        tree.Insert(5);
        tree.Insert(6);
        tree.Insert(7);

        var expected = new[] { 7, 6, 5, 4, 3, 2, 1 };
        var actual = tree.ToArray();

        CollectionAssert.AreEqual(expected, actual);
    }
}