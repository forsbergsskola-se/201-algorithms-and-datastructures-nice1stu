namespace TurboCollections.Test;

[TestFixture]
public class TurboMinHeapTreeTests
{
    private TurboMinHeapTree.Node? _root;

    [SetUp]
    public void Setup()
    {
        _root = TurboMinHeapTree.GetNode(4);
        if (_root != null)
        {
            _root.Left = TurboMinHeapTree.GetNode(2);
            _root.Right = TurboMinHeapTree.GetNode(6);
            if (_root.Left != null)
            {
                _root.Left.Left = TurboMinHeapTree.GetNode(1);
                _root.Left.Right = TurboMinHeapTree.GetNode(3);
            }

            if (_root.Right != null) _root.Right.Left = TurboMinHeapTree.GetNode(5);
            if (_root.Right != null) _root.Right.Right = TurboMinHeapTree.GetNode(7);
        }
        
        /*                      4
                              /   \
                             2     6
                            / \   /  \
                           1   3 5    7
        */
    }

    [Test]
    public void ConvertToMinHeapUtilShouldConvertBstToMinHeap()
    {
        TurboMinHeapTree.ConvertToMinHeap(_root);
        var result = new List<int>();
        foreach (var i in TurboMinHeapTree.PreorderTraversal(_root))
        {
            result.Add(i);
        }

        var expected = new List<int> {1, 2, 3, 4, 5, 6, 7};
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void InorderTraversalShouldStoreNodesInAscendingOrder()
    {
        {
            TurboMinHeapTree.Arr.Clear();
            TurboMinHeapTree.InorderTraversal(_root);

            var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            Assert.That(TurboMinHeapTree.Arr, Is.EqualTo(expected));
        }
    }

    [Test]
    public void PreorderTraversalShouldReturnCorrectResult()
    {
        var result = new List<int>();
        foreach (var i in TurboMinHeapTree.PreorderTraversal(_root))
        {
            result.Add(i);
        }
        
        var expected = new List<int> {4, 2, 1, 3, 6, 5, 7};
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetNodeShouldReturnNewNodeWithData()
    {
        var node = TurboMinHeapTree.GetNode(10);
        
        Assert.That(node.Data, Is.EqualTo(10));
        Assert.IsNull(node.Left);
        Assert.IsNull(node.Right);
    }
}
