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
    
    public void Insert(T value)
    {
        _root = InsertRec(_root, value);
    }

    private Node InsertRec(Node? root, T value)
    {
        if (root == null)
        {
            root = new Node(value);
            return root;
        }

        if (value.CompareTo(root.Key) < 0)
        {
            root.Left = InsertRec(root.Left, value);
        }
        else if (value.CompareTo(root.Key) > 0)
        {
            root.Right = InsertRec(root.Right, value);
        }

        return root;
    }

    public void Remove(T value)
    {
        _root = RemoveRec(_root, value);
    }

    private Node? RemoveRec(Node? root, T value)
    {
        if (root == null) return root;

        if (value.CompareTo(root.Key) < 0)
        {
            root.Left = RemoveRec(root.Left, value);
            return root;
        }

        if (value.CompareTo(root.Key) > 0)
        {
            root.Right = RemoveRec(root.Right, value);
            return root;
        }

        if (root.Left == null)
        {
            return root.Right;
        }
        if (root.Right == null)
        {
            return root.Left;
        }

        T min = MinValue(root.Right);
        root.Key = min;
        root.Right = RemoveRec(root.Right, min);
        return root;
    }

    private T MinValue(Node? root)
    {
        T minValue = root!.Key;
        while (root!.Left != null)
        {
            minValue = root.Left.Key;
            root = root.Left;
        }
        return minValue;
    }

}