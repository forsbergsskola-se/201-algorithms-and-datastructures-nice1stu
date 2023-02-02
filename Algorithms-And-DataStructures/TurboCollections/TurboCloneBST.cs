public class Node
{
    public int data;
    public Node left;
    public Node right;

    public Node(int data)
    {
        this.data = data;
        left = null;
        right = null;
    }
}

public class BST
{
    public Node root;

    public BST()
    {
        root = null;
    }

    public Node CloneTree(Node node)
    {
        if (node == null)
        {
            return null;
        }
        Node clone = new Node(node.data);
        clone.left = CloneTree(node.left);
        clone.right = CloneTree(node.right);
        return clone;
    }
}
