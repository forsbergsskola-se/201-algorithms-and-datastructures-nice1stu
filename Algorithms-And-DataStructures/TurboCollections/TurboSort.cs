using System;
using System.Collections.Generic;

namespace TurboCollections
{
    public static partial class TurboSort<T> where T : IComparable
    {
        public static void bubbleSort(TurboLinkedList<T> list)
        {
            if (list == null || list.Count == 0) return;
            LinkedListNode<T> currentNode = list.First;
            LinkedListNode<T> nextNode = currentNode.Next;
            for (int i = 0; i < list.Count - 1; i++)
            {
                currentNode = list.First;
                nextNode = currentNode.Next;
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (currentNode.Value.CompareTo(nextNode.Value) > 0)
                    {
                        T temp = currentNode.Value;
                        currentNode.Value = nextNode.Value;
                        nextNode.Value = temp;
                    }

                    currentNode = currentNode.Next;
                    nextNode = nextNode.Next;
                }
            }
        }
    }
}