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
    //int Count;
    // adds one item to the back of the queue.
    void Enqueue(T item);
    // returns the item in the front of the queue without removing it.
    T Peek();
    // returns the item in the front of the queue and removes it at the same time.
    T Dequeue();
    // removes all items from the queue.
    void Clear();
}

public class TurboLinkedQueue<T> : ITurboQueue<T> {
    // This class is VERY similar to the TurboLinkedStack
    class Node {
        public T Value;
        // But we store the Next Node for each Node instead.
        public Node Next;
        public Node Previous { get; set; }
    }
    // Also, we store the first instead of the last Node. First Come, First Serve.

    public void Enqueue(T item)
    {
        Node newNode = new Node { Value = item, Previous = FirstNode };
        FirstNode = newNode;
    }

    public T Peek()
    {
        throw new NotImplementedException();
    }

    public T Dequeue()
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    Node FirstNode { get; set; }
    // Everything else is super similar to the TurboLinkedStack!
    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
