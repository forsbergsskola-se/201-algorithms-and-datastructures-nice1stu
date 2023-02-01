namespace TurboCollections;

public class TurboBST 
{
    public class Node
    {
        public int Key;
        public Node? Left;
        public Node? Right;
 
        public Node(int item)
        {
            Key = item;
            Left = Right = null;
        }
    }

    private Node? _root;

    public TurboBST() { _root = null; }
    
    public bool Search(int value)
    {
        return SearchRec(_root, value);
    }

    private bool SearchRec(Node? root, int value)
    {
        if (root == null) return false;
        if (root.Key == value) return true;

        if (value < root.Key) return SearchRec(root.Left, value);
        return SearchRec(root.Right, value);
    }

    public void Insert(int key) { _root = InsertRec(_root, key); }
    
    Node? InsertRec(Node? root, int key)
    {
        if (root == null)
            return new Node(key);
        
        if (key < root.Key)
            root.Left = InsertRec(root.Left, key);
        else if (key > root.Key)
            root.Right = InsertRec(root.Right, key);
        
        return root;
    }
    
    void Inorder() { InorderRec(_root); }

    public static void InorderRec(Node? root)
    {
        if (root == null) return;
        InorderRec(root.Left);
        Console.Write(root.Key + " ");
        InorderRec(root.Right);
    }

    public void Delete(int key)
    {
        _root = DeleteRec(_root, key);
    }

    Node? DeleteRec(Node? root, int key)
    {
        if (root == null) return null;

        if (key >= root.Key)
        {
            if (key <= root.Key)
            {
                if (root.Left == null) return root.Right;

                if (root.Right == null) return root.Left;

                var min = MinValue(root.Right);
                root.Key = min;
                root.Right = DeleteRec(root.Right, min);
            }
            else
                root.Right = DeleteRec(root.Right, key);
        }
        else
            root.Left = DeleteRec(root.Left, key);

        return root;
    }

    int MinValue(Node? root)
    {
        int min = root.Key;
        while (root.Left != null)
        {
            min = root.Left.Key;
            root = root.Left;
        }
        return min;
    }

    public void PrintInOrder() //InOrder
    {
        InorderRec(_root);
    }
    
    public static void PreorderRec(Node? root) //PreOrder
    {
        if (root == null) return;
        Console.Write(root.Key + " ");
        PreorderRec(root.Left);
        PreorderRec(root.Right);
    }
    
    public void PrintPreOrder() //InOrder
    {
        PreorderRec(_root);
    }
    
    public static void PostorderRec(Node? root) //PreOrder
    {
        if (root == null) return;
        PostorderRec(root.Left);
        PostorderRec(root.Right);
        Console.Write(root.Key + " ");
    }
    
    public void PrintPostOrder() //InOrder
    {
        PostorderRec(_root);
    }
    
    public static void ReverseorderRec(Node? root) //PreOrder
    {
        if (root == null) return;
        InorderRec(root.Right);
        Console.Write(root.Key + " ");
        InorderRec(root.Left);
    }
    
    public void PrintReverseOrder() //InOrder
    {
        ReverseorderRec(_root);
    }
}