using NUnit.Framework;

namespace TurboCollections.Tests;

[TestFixture]
public class TurboBstTests
{
    [Test]
    public void Insert_AddsNodeToTree()
    {
        TurboBST tree = new TurboBST();
        tree.Insert(10);
        tree.Insert(20);
        tree.Insert(30);
        tree.Insert(40);
        tree.Insert(50);


        Assert.That(tree.Search(10), Is.True);
        Assert.That(tree.Search(20), Is.True);
        Assert.That(tree.Search(30), Is.True);
        Assert.That(tree.Search(40), Is.True);
        Assert.That(tree.Search(50), Is.True);
    }

    [Test]
    public void Delete_RemovesNodeFromTree()
    {
        TurboBST tree = new TurboBST();
        tree.Insert(10);
        tree.Insert(20);
        tree.Insert(30);
        tree.Insert(40);
        tree.Insert(50);

        tree.Delete(20);
        
        Assert.That(tree.Search(10), Is.True);
        Assert.That(tree.Search(20), Is.False);
        Assert.That(tree.Search(30), Is.True);
        Assert.That(tree.Search(40), Is.True);
        Assert.That(tree.Search(50), Is.True);
    }

    [Test]
    public void Search_ReturnsTrueForExistingNode()
    {
        TurboBST tree = new TurboBST();
        tree.Insert(10);
        tree.Insert(20);
        tree.Insert(30);
        tree.Insert(40);
        tree.Insert(50);

        Assert.That(tree.Search(10), Is.True);
        Assert.That(tree.Search(30), Is.True);
        Assert.That(tree.Search(50), Is.True);
        Assert.That(tree.Search(60), Is.False);

    }

    [Test]
    public void Insert_AddsRandomNodeToTree()
    {
        TurboBST tree = new TurboBST();

        Random random = new Random();
        int[] values = new int[100];

        for (int i = 0; i < values.Length; i++)
        {
            values[i] = random.Next(1, 101);
        }

        Console.WriteLine("Random values:");
        foreach (int value in values)
        {
            Console.Write($"{value} ");
            tree.Insert(value);
        }

        Console.WriteLine("");
        foreach (int value in values)
        {
            Assert.That(tree.Search(value), Is.True, $"Value {value} was not found in the tree");
        }

        int lastValue = values[values.Length - 1];
        Console.WriteLine("Deleting value: " + lastValue);
        tree.Delete(lastValue);

        Assert.That(tree.Search(lastValue), Is.False, $"Value {lastValue} was found in the tree after deletion");

        Console.WriteLine("Remaining values:");
        foreach (int value in values)
        {
            if (value == lastValue) continue;
            Console.Write($"{value} ");
        }
    }

    [Test]
    public void PrintInOrder_WithElements_PrintsElementsInAscendingOrder()
    {
        // Arrange
        TurboBST tree = new TurboBST();
        tree.Insert(100);
        tree.Insert(20);
        tree.Insert(200);
        tree.Insert(10);
        tree.Insert(30);
        tree.Insert(150);
        tree.Insert(300);
        
        tree.PrintInOrder();
    }
    
    [Test]
    public void PrintPreOrder_WithElements_PrintsElementsInAscendingOrder()
    {
        // Arrange
        TurboBST tree = new TurboBST();
        tree.Insert(100);
        tree.Insert(20);
        tree.Insert(200);
        tree.Insert(10);
        tree.Insert(30);
        tree.Insert(150);
        tree.Insert(300);
        
        tree.PrintPreOrder();
    }

    [Test]
    public void PrintPostOrder_WithElements_PrintsElementsInAscendingOrder()
    {
        // Arrange
        TurboBST tree = new TurboBST();
        tree.Insert(100);
        tree.Insert(20);
        tree.Insert(200);
        tree.Insert(10);
        tree.Insert(30);
        tree.Insert(150);
        tree.Insert(300);
        
        tree.PrintPostOrder();
    }
    
    [Test]
    public void PrintReverseOrder_WithElements_PrintsElementsInAscendingOrder()
    {
        // Arrange
        TurboBST tree = new TurboBST();
        tree.Insert(100);
        tree.Insert(20);
        tree.Insert(200);
        tree.Insert(10);
        tree.Insert(30);
        tree.Insert(150);
        tree.Insert(300);
        
        tree.PrintReverseOrder();
    }
}