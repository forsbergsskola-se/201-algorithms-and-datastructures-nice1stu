namespace TurboCollections;

public class TurboBSTIComparable<T> where T:IComparable<T>
{
    public class Node
    {
        public T Key;
        public Node? Left;
        public Node? Right;

        public Node(T item)
        {
            Key = item;
            Left = Right = null;
        }
    }

    public Node? _root;

    public TurboBSTIComparable()
    {
        _root = null;
    }

    public bool Search(T value)
    {
        return SearchRec(_root, value);
    }

    private bool SearchRec(Node? root, T value)
    {
        if (root == null) return false;
        if (root.Key.CompareTo(value) == 0) return true;

        if (value.CompareTo(root.Key) < 0) return SearchRec(root.Left, value);
        return SearchRec(root.Right, value);
    }
}