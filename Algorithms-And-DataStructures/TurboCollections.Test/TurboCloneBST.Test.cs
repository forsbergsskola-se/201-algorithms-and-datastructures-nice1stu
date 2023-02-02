namespace TurboCollections.Test;

[TestFixture]
public class TurboCloneBstTests
{
    [Test]
    public void CloneTreeWithValidBstShouldReturnClonedBst()
    {
        BST bst = new BST();
        bst.root = new global::Node(5);
        bst.root.left = new global::Node(2);
        bst.root.right = new global::Node(8);

        BST clonedBst = new BST();
        clonedBst.root = bst.CloneTree(bst.root);

        Assert.AreEqual(bst.root.data, clonedBst.root.data);
        Assert.AreEqual(bst.root.left.data, clonedBst.root.left.data);
        Assert.AreEqual(bst.root.right.data, clonedBst.root.right.data);
    }

    [Test]
    public void CloneTreeWithEmptyBST_ShouldReturnNull()
    {
        BST bst = new BST();
        BST clonedBst = new BST();
        clonedBst.root = bst.CloneTree(bst.root);

        Assert.IsNull(clonedBst.root);
    }
    
    [Test]
    public void RemoveNode_ShouldRemoveNodeFromClonedTreeButNotFromOriginalTree()
    {
        BST originalBst = new BST();
        originalBst.root = new global::Node(4);
        originalBst.root.left = new global::Node(2);
        originalBst.root.right = new global::Node(5);
        originalBst.root.left.left = new global::Node(1);
        originalBst.root.left.right = new global::Node(3);
        originalBst.root.right.right = new global::Node(6);

        BST clonedBst = new BST();
        clonedBst.root = originalBst.CloneTree(originalBst.root);

        clonedBst.RemoveNode(5);

        Assert.IsTrue(NodeExists(originalBst.root, 5));
        Assert.IsFalse(NodeExists(clonedBst.root, 5));
        Assert.IsTrue(NodeExists(clonedBst.root, 1));
        Assert.IsTrue(NodeExists(clonedBst.root, 2));
        Assert.IsTrue(NodeExists(clonedBst.root, 3));
        Assert.IsTrue(NodeExists(clonedBst.root, 4));
        Assert.IsTrue(NodeExists(clonedBst.root, 6));
    }

    private bool NodeExists(global::Node node, int value)
    {
        if (node == null)
        {
            return false;
        }
        if (node.data == value)
        {
            return true;
        }
        return NodeExists(node.left, value) || NodeExists(node.right, value);
    }
}