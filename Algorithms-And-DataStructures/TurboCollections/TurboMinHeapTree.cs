// BST to Min Heap
namespace TurboCollections
{
    public class TurboMinHeapTree
    {
        // Structure of a node in the binary search tree.
        public class Node
        {
            public int Data { get; set; }
            public Node? Left { get; set; }
            public Node? Right { get; set; }
        }

        public static Node GetNode(int data)
        {
            return new Node { Data = data };
        }

        public static List<int> Arr = new List<int>();
        private static int _i = -1;

        // Inorder traversal of the binary search tree.
        public static void InorderTraversal(Node? root)
        {
            if (root is null)
            {
                return;
            }

            InorderTraversal(root.Left);
            Arr.Add(root.Data);
            InorderTraversal(root.Right);
        }

        // Convert the binary search tree to a min heap.
        private static void BstToMinHeap(Node? root)
        {
            if (root is null)
            {
                return;
            }

            root.Data = Arr[++_i];
            BstToMinHeap(root.Left);
            BstToMinHeap(root.Right);
        }

        // Convert the binary search tree to a min heap.
        public static void ConvertToMinHeap(Node? root)
        {
            if (root is null)
            {
                throw new ArgumentNullException(nameof(root));
            }

            Arr.Clear();
            _i = -1;

            InorderTraversal(root);
            BstToMinHeap(root);
        }

        // Preorder traversal of the min heap.
        public static IEnumerable<int> PreorderTraversal(Node? root)
        {
            if (root is null)
            {
                yield break;
            }

            yield return root.Data;
            foreach (var data in PreorderTraversal(root.Left))
            {
                yield return data;
            }

            foreach (var data in PreorderTraversal(root.Right))
            {
                yield return data;
            }
        }
    }
}