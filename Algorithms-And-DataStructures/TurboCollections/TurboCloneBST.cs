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

    public Node RemoveNode(int value)
    {
        return RemoveNode(root, value);
    }

    private Node RemoveNode(Node node, int value)
    {
        if (node == null)
        {
            return null;
        }

        if (value < node.data)
        {
            node.left = RemoveNode(node.left, value);
        }
        else if (value > node.data)
        {
            node.right = RemoveNode(node.right, value);
        }
        else
        {
            if (node.left == null)
            {
                return node.right;
            }
            else if (node.right == null)
            {
                return node.left;
            }
            else
            {
                node.data = MinValue(node.right);
                node.right = RemoveNode(node.right, node.data);
            }
        }
        return node;
    }

    private int MinValue(Node node)
    {
        int minValue = node.data;
        while (node.left != null)
        {
            minValue = node.left.data;
            node = node.left;
        }
        return minValue;
    }
}
