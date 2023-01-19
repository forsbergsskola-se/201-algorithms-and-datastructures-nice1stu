//Reference TurboCollections
//Use TurboLinkedQueue
//The User repeatedly has the following options:

//[s]kip to next song: If there is another song in the queue, it prints $"Now Playing {songName}.". else, it says "No more songs in the Queue. Add new Songs to the Queue first."
//[a]dd new song to the queue: The application asks for a Song Name and then adds it to the Queue.

using System.Collections;

namespace TurboCollections;

public class SpotifySongQueue
{
    static void Main(string[] args)
    {

        public interface ITurboQueue<T> : IEnumerable<T>
        {
        // returns the current amount of items contained in the stack.
        int Count { get; }

        // adds one item to the back of the queue.
        void Enqueue(T item);

        // returns the item in the front of the queue without removing it.
        T Peek();

        // returns the item in the front of the queue and removes it at the same time.
        T Dequeue();

        // removes all items from the queue.
        void Clear();
        }

        public class TurboLinkedQueue<T> : ITurboQueue<T>
        {
            // This class is VERY similar to the TurboLinkedStack
            class Node
            {
                public T Value;
                // But we store the Next Node for each Node instead.
                public Node Next;
            }

            // Also, we store the first instead of the last Node. First Come, First Serve.
            Node FirstNode;

            public void Enqueue(T value)
            {
                Node newNode = new Node { Value = value };
                if (FirstNode == null)
                {
                    FirstNode = newNode;
                }
                else
                {
                    Node currentNode = FirstNode;
                    while (currentNode.Next != null)
                    {
                    currentNode = currentNode.Next;
                    }

                    currentNode.Next = newNode;
                }

                count++;
            }

            public T Peek()
            {
                return FirstNode.Value;
            }

            public T Dequeue()
            {
                T value = FirstNode.Value;
                FirstNode = FirstNode.Next;
                count--;
                return value;
            }

            public void Clear()
            {
                FirstNode = null;
                count = 0;
            }

            private int count;

            public int Count
            {
                get { return count; }
            }

            // Everything else is super similar to the TurboLinkedStack!
            public IEnumerator<T> GetEnumerator()
            {
                Node currentNode = FirstNode;
                while (currentNode != null)
                {
                    yield return currentNode.Value;
                    currentNode = currentNode.Next;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }

}