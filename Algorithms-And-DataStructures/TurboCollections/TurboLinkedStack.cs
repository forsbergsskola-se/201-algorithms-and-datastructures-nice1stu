﻿using System.Collections;

public class TurboLinkedStack<T> : IEnumerable<T> {
    public class Node
    {
        public T Value;
        public Node Previous;
    }

    public Node LastNode;

    public void Push(T item) {
        Node newNode = new Node { Value = item, Previous = LastNode };
        LastNode = newNode;
    }


    public T Peek()
    {
        return LastNode.Value;
    }

    public T Pop()
    {
        if(LastNode == null)
            throw new InvalidOperationException("The stack is empty.");
        var last = LastNode;
        LastNode = last.Previous;
        return last.Value;
    }

    public void Clear() {
        LastNode = null;
    }


    public int Count {
        get{
            // Here, you need to do a while loop over all nodes
            // Similar to the previous PrintAllNodes Function
            // But instead of Printing Nodes, you just count how many Nodes you have visited
            // Similar to this:
            int count = 0;
            while(false/* remove false and replace with correct condition...*/){
                count++;
            }
            return count;
        }
    }

    public IEnumerator<T> GetEnumerator() {
        // This one is a bonus and a bit more difficult.
        // You need to create a new class named Enumerator.
        // You find the details below.
        var enumerator = new Enumerator(){
            CurrentNode = null,
            // This might look confusing. But remember? Last In. First Out.
            FirstNode = LastNode
        };
        return enumerator;
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    class Enumerator : IEnumerator<T> {
        public Node CurrentNode;
        public Node FirstNode;

        public bool MoveNext(){
            throw new NotImplementedException();
            // if we don't have a current node, we start with the first node
            if(CurrentNode == null){
                CurrentNode = FirstNode;
            } else {
                // Assign the Current Node's Previous Node to be the Current Node.
            }
            // Return, whether there is a CurrentNode. Else, we have reached the end of the Stack, there's no more Elements.
        }

        public T Current {
            get{
                throw new NotImplementedException();
                // Return the Current Node's Value.
            }
        }

        // This Boiler Plate is necessary to correctly implement `IEnumerable` interface.
        object IEnumerator.Current => Current;

        public void Reset() {
            // Look at Move. How can you make sure that this Enumerator starts over again?
        }

        public void Dispose()
        {
            // This function is not needed right now.
        }
    }
}