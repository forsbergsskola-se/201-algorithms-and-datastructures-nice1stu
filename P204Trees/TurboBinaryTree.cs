//Binary Tree
//              A(0)
//            /      \
//          B(1)    C(2)
//         /    \       \
//       D(3)  E(4)    F(6)
using System;

namespace P204Trees
{
    class BinaryTree
    {
        static void Main(string[] args)
        {
            Node root = new Node(30);
            Node n1 = new Node(15);
            Node n2 = new Node(45);
            Node n3 = new Node(6);
            Node n4 = new Node(41);
            Node n5 = new Node(54);

            root.left = n1;
            root.right = n2;
            n1.right = n3;
            n2.left = n4;
            n2.right = n5;
        }
    }

    class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int value)
        {
            this.value = value;
        }
    }
}