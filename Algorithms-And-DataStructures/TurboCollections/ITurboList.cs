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
    
    public class TurboLinkedList<T> : IEnumerable<T> // ICollection
    {
        // 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
    
        private class Node {
            public T Value;
            public Node? Next;

            public Node(T value, Node? next)
            {
                Value = value;
                Next = next;
            }
        }
    
        public int Count { get; private set; }

        private Node? _firstNode;
        private Node? _lastNode;

        public void Add(T item)
        {
            if (_lastNode == null)
            {
                _firstNode = _lastNode = new Node(item, null);
            }
            else
            {
                _lastNode = _lastNode.Next = new Node(item, null);
            }
            Count++;
        }

        public T Get(int index)
        {
            if (index < 0) throw new IndexOutOfRangeException();
            if (index >= Count) throw new IndexOutOfRangeException();
            Node current = _firstNode!; // validated through index checks above
            for (int i = 0; i < index; i++)
            {
                current = current.Next!; // validated through index checks above
            }

            return current.Value;
        }

        public void Set(int index, T value)
        {
            if (index >= Count) throw new IndexOutOfRangeException();
            Node current = _firstNode!;
            for (int i = 0; i < index; i++) // 2
            {
                current = current.Next!;
            }
        
            current.Value = value;
        }

        public void Clear()
        {
            _firstNode = _lastNode = null;
            Count = 0;
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            Node currentNode = _firstNode;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(item))
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }

        public int IndexOf(T item)
        {
            Node currentNode = _firstNode;
            for (int i = 0; i < Count; i++)
            {
                if (currentNode.Value.Equals(item))
                {
                    return i;
                }

                currentNode = currentNode.Next;
            }

            return -1;
        }

        public void Remove(int index)
        {
            if (index >= Count) throw new IndexOutOfRangeException();
            Node current = _firstNode!;
            Node? previous = null;
            for (int i = 0; i < index; i++)
            {
                previous = current;
                current = current.Next!;
            }

            if (previous != null)
                previous.Next = current.Next;

            if (_firstNode == current)
                _firstNode = current.Next;

            if (_lastNode == current)
                _lastNode = previous;

            Count--;
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

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new Enumerator(_firstNode);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        class Enumerator : IEnumerator<T>
        {
            private readonly Node? _firstNode;
            private Node? _currentNode;

            public Enumerator(Node? firstNode)
            {
                _firstNode = firstNode;
            }
            public bool MoveNext()
            {
                _currentNode = _currentNode == null ? _firstNode : _currentNode.Next;
                return _currentNode != null;
            }

            public void Reset()
            {
                _currentNode = null;
            }

            public T Current
            {
                get
                {
                    if (_currentNode == null) throw new InvalidOperationException();
                    return _currentNode.Value;
                }
            }

            object? IEnumerator.Current => Current;

            public void Dispose() { }
        }
    
        // 2000 (0-2000)
        // 1000 (0-1000) (1000-2000)
        // 500 (0-500)
        // 250
        // 125
        // 62
        // 31
        // 15
        // 7
        // 3
        // 2
        // 1
        public T this[int index]
        {
            get => Get(index);
            set => Set(index, value);
        }
    }
}