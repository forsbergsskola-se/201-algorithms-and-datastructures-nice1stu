using System.Collections;

namespace TurboCollections;

public interface ITurboQueue2<T> : IEnumerable<T>
{
    // returns the current amount of items contained in the stack.
    //int Count { get; }
    // adds one item to the back of the queue.
    void Enqueue(T item);
    // returns the item in the front of the queue without removing it.
    T Peek();
    // returns the item in the front of the queue and removes it at the same time.
    T Dequeue();
    // removes all items from the queue.
    void Clear();
}

public class TurboQueue<T> : ITurboQueue2<T>
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
    // Add last node.
    Node LastNode;

    public void Enqueue(T value)
    {
        Node newNode = new Node { Value = value };
        if (LastNode == null)
        {
            FirstNode = newNode;
            LastNode = newNode;
            
        } else
        {
            LastNode.Next = newNode;
            LastNode = newNode;
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
        LastNode = null;
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
        while (currentNode != null) {
            yield return currentNode.Value;
            currentNode = currentNode.Next;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}