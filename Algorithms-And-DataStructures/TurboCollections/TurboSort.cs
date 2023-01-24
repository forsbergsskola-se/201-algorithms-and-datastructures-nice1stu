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
        
        //Bubble Sort - a comparison-based algorithm in which each pair of adjacent elements is compared and the elements are swapped if they are not in order.
        public static List<int> BubbleSort(List<int> input)
        {
            int temp;
            for (int i = 0; i < input.Count - 1; i++)
            {
                for (int j = 0; j < input.Count - i - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
            }
            return input;
        }
    }
}

