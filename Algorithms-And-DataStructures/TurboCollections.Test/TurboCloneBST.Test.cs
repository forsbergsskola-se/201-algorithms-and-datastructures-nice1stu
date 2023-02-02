using NUnit.Framework;

[TestFixture]
public class TurboCloneBSTTests
{
    [Test]
    public void CloneTreeWithValidBSTShouldReturnClonedBST()
    {
        BST bst = new BST();
        bst.root = new Node(5);
        bst.root.left = new Node(2);
        bst.root.right = new Node(8);

        BST clonedBST = new BST();
        clonedBST.root = bst.CloneTree(bst.root);

        Assert.AreEqual(bst.root.data, clonedBST.root.data);
        Assert.AreEqual(bst.root.left.data, clonedBST.root.left.data);
        Assert.AreEqual(bst.root.right.data, clonedBST.root.right.data);
    }

    [Test]
    public void CloneTree_WithEmptyBST_ShouldReturnNull()
    {
        BST bst = new BST();
        BST clonedBST = new BST();
        clonedBST.root = bst.CloneTree(bst.root);

        Assert.IsNull(clonedBST.root);
    }
}