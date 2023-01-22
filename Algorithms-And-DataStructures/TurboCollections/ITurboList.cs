using System;
using System.Collections;
using System.Collections.Generic;

namespace TurboCollections;


public interface ITurboList<T> : IEnumerable<T>
{
    // returns the current amount of items contained in the list.
    int Count { get; }
    // adds one item to the end of the list.
    void Add(T item);
    // gets the item at the specified index. If the index is outside the correct range, an exception is thrown.
    T Get(int index);
    // replaces the item at the specified index. If the index is outside the correct range, an exception is thrown.
    void Set(int index, T value);
    // removes all items from the list.
    void Clear();
    // removes one item from the list. If the 4th item is removed, then the 5th item becomes the 4th, the 6th becomes the 5th and so on.
    void RemoveAt(int index);
    // --------------- optional ---------------
    // returns true, if the given item can be found in the list, else false.
    bool Contains(T item);
    // returns the index of the given item if it is in the list, else -1.
    int IndexOf(T item);
    // removes the first instance of the specified item from the list, if it can be found. Works similar to RemoveAt.
    void Remove(T item);
    // adds multiple items ad the end of this list at once. Works similar to Add.
    void AddRange(IEnumerable<T> items);
    // --------------- important, but difficult ---------------
    // gets the iterator for this collection. Used by IEnumerable<T>-Interface to support foreach.
}

public class ITurboList
{
    
    public class TurboLinkedList<T> : ITurboList<T>
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

        private int count;
        public int Count
        {
            get { return count; }
        }

        public void Add(T value)
        {
            Node newNode = new Node { Value = value };
            if (FirstNode == null)
            {
                FirstNode = newNode;
            } else
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

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            Node currentNode = FirstNode;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }

            return currentNode.Value;
        }

        public void Set(int index, T value)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            Node currentNode = FirstNode;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Value = value;
        }

        public void Clear()
        {
            FirstNode = null;
            count = 0;
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<T> items)
        {
            throw new NotImplementedException();
        }

        // ...

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
}