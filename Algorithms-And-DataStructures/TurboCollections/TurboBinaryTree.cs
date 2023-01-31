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
            switch (Root)
            {
                case null:
                    Root = new Node(data);
                    break;
                default:
                    InsertNode(data, Root);
                    break;
            }
        }

        private void InsertNode(int data, Node node)
        {
            if (data < node.Data)
            {
                switch (node.Left)
                {
                    case null:
                        node.Left = new Node(data);
                        break;
                    default:
                        InsertNode(data, node.Left);
                        break;
                }
            }
            else
            {
                switch (node.Right)
                {
                    case null:
                        node.Right = new Node(data);
                        break;
                    default:
                        InsertNode(data, node.Right);
                        break;
                }
            }
        }
    }
}
