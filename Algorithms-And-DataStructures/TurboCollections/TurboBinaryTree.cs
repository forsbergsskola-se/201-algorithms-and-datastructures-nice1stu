//Binary Tree
//                  A(0) Root
//                 /    \
//              B(1)    C(2) Leaf / Parentz
//             /   \        \
//          D(43)    E(4)    F(6)    Left / Child

namespace TurboCollections
{
    public class BinaryTree
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int data)
        {
            if (Root == null)
            {
                Root = new Node(data);
            }
            else
            {
                InsertNode(data, Root);
            }
        }

        private void InsertNode(int data, Node node)
        {
            if (data < node.Data)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(data);
                }
                else
                {
                    InsertNode(data, node.Left);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node(data);
                }
                else
                {
                    InsertNode(data, node.Right);
                }
            }
        }
    }
}
