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
 

    public static void Main(String[] args)
    {
        BinarySearchTree tree = new BinarySearchTree();
 
        /* Let us create following BST
              50
           /     \
          30      70
         /  \    /  \
       20   40  60   80 */
        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(70);
        tree.Insert(60);
        tree.Insert(80);
 
        // Print inorder traversal of the BST
        tree.Inorder();
    }
}