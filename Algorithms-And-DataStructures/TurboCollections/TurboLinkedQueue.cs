using System.Collections;

namespace TurboCollections;

public interface ITurboQueue<T> : IEnumerable<T>
    {
        public class Node
        {
            public T Value;
            public Node Previous;
        }

        // returns the current amount of items contained in the stack.
        //int count;
        // adds one item to the back of the queue.
        public void Enqueue(T item)
        {
            Node newNode = new Node { Value = item, Previous = FirstNode };
            FirstNode = newNode;
        }

        Node FirstNode { get; set; }

        // returns the item in the front of the queue without removing it.
        T Peek();
        // returns the item in the front of the queue and removes it at the same time.
        T Dequeue();
        // removes all items from the queue.
        void Clear();
    }
