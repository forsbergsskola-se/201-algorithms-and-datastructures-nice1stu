namespace TurboCollections;

class BinarySearchTree 
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
    
    BinarySearchTree() { _root = null; }
    
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

    void Insert(int key) { _root = InsertRec(_root, key); }
    
    Node? InsertRec(Node? root, int key)
    {
        if (root != null && key < root.Key)
            root.Left = InsertRec(root.Left, key);
        else if (root != null && key > root.Key)
            root.Right = InsertRec(root.Right, key);
        
        return root;
    }
    
    void Inorder() { InorderRec(_root); }

    public static void InorderRec(Node? root)
    {
        InorderRec(root?.Left);
        if (root == null) return;
        Console.Write(root.Key + " ");
        InorderRec(root.Right);
    }
    
    void Delete(int key)
    {
        _root = DeleteRec(_root, key);
    }

    Node? DeleteRec(Node? root, int key)
    {
        switch (root)
        {
            case null:
                return null;
        }

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


    public static void Main(String[] args)
    {
        BinarySearchTree tree = new BinarySearchTree();
 
        /* Let us create following BST
              50
           /     \
          30      70
         /  \    /  \
       20   40  60   80 */
       /* tree.Insert(50);
        tree.Insert(30);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(70);
        tree.Insert(60);
        tree.Insert(80);*/
 
        // Print inorder traversal of the BST
        //tree.Inorder();
    }
}