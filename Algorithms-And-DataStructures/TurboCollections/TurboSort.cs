using System;
using System.Collections.Generic;

namespace TurboCollections
{
    public class TurboSort
    {
        //Selection Sort - Selection Sort is a sorting algorithm that finds the minimum value in the array for each iteration of the loop.
        public static List<int> SelectionSort(List<int> input)
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
                int temp = input[i];
                input[i] = input[minIndex];
                input[minIndex] = temp;
            }
            return input;
        }
    }
}
