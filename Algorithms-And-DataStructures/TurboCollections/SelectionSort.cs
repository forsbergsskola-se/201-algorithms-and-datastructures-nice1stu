using System;
using System.Collections.Generic;

namespace TurboCollections
{
    public partial class SelectionSort
    {
        //Selection Sort - Selection Sort is a sorting algorithm that finds the minimum value in the array for each iteration of the loop.
        public static List<int> selectionSort(List<int> input)
        {
            for (int i = 0; i < input.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < input.Count; j++)
                {
                    if (input[j] < input[minIndex])
                    {
                        minIndex = j;
                    }
                }
                (input[i], input[minIndex]) = (input[minIndex], input[i]);
            }
            return input;
        }
    }
}