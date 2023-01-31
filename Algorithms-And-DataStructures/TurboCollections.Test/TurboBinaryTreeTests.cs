namespace TurboCollections.Test;

[TestFixture]
public class BinaryTreeTests
{
    [Test]
    public void TestInsertInCorrectOrdertoBuildTree()
    {
        
        //Binary Tree
        //                  A(3) Root
        //                 /    \
        //             B(1)      C(4) Leaf / Parent
        //            /   \      /  \
        //        D(0)   E(2)  F(3)  G(6)    Left / Child        
        
        BinaryTree tree = new BinaryTree();
        tree.Insert(3);
        tree.Insert(1);
        tree.Insert(4);
        tree.Insert(3);
        tree.Insert(2);
        tree.Insert(0);
        tree.Insert(6);
        
        Assert.That(tree.Root, Is.Not.Null);
        Assert.That(tree.Root.Data, Is.EqualTo(3));
        Assert.That(tree.Root.Left.Data, Is.EqualTo(1));
        Assert.That(tree.Root.Left.Left.Data, Is.EqualTo(0));
        Assert.That(tree.Root.Left.Right.Data, Is.EqualTo(2));
        Assert.That(tree.Root.Right.Data, Is.EqualTo(4));
        Assert.That(tree.Root.Right.Left.Data, Is.EqualTo(3));
        Assert.That(tree.Root.Right.Right.Data, Is.EqualTo(6));
        
    }
    
    [Test]
    public void TestInsertAscendingDataOrdertoBuildTree()
    {
        //Binary Tree
        //                      0
        //                   /     \
        //                          1
        //                           \
        //                            2
        //                             \
        //                              3
        //                               \
        //                                4
        
        BinaryTree tree = new BinaryTree();
        tree.Insert(0);
        tree.Insert(1);
        tree.Insert(2);
        tree.Insert(3);
        tree.Insert(4);

        Assert.That(tree.Root, Is.Not.Null);
        Assert.That(tree.Root.Data, Is.EqualTo(0));
        Assert.That(tree.Root.Right.Data, Is.EqualTo(1));
        Assert.That(tree.Root.Right.Right.Data, Is.EqualTo(2));
        Assert.That(tree.Root.Right.Right.Right.Data, Is.EqualTo(3));
        Assert.That(tree.Root.Right.Right.Right.Right.Data, Is.EqualTo(4));
        Assert.IsNull(tree.Root.Left);
    }
    
    /*[Test]
    public void InsertionTest()
    {
        BinaryTree tree = new BinaryTree();
        Random rnd = new Random();
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 100);
            tree.Insert(arr[i]);
        }

        Array.Sort(arr);

        Assert.That(tree.Root.Data, Is.EqualTo(arr[0]));

        for (int i = 1; i < arr.Length; i++)
        {
            int nodeValue = arr[i];
            bool found = FindNode(tree.Root, nodeValue);
            Assert.IsTrue(found);
        }
    }

    private bool FindNode(BinaryTree.Node node, int value)
    {
        if (node == null)
        {
            return false;
        }

        if (node.Data == value)
        {
            return true;
        }

        if (value < node.Data)
        {
            return FindNode(node.Left, value);
        }
        else
        {
            return FindNode(node.Right, value);
        }
    }*/
}