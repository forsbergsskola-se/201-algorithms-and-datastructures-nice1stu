using System;
using System.Collections.Generic;

namespace TurboCollections
{
    public class SortBubble
    {
        //Bubble Sort - a comparison-based algorithm in which each pair of adjacent elements is compared and the elements are swapped if they are not in order.
        public static List<int> bubbleSort(List<int> input)
        {
            int temp;
            for (int i = 0; i < input.Count - 1; i++)
            {
                for (int j = 0; j < input.Count - i - 1; j++)
                {
                    if (input[j] <= input[j + 1]) continue;
                    temp = input[j];
                    input[j] = input[j + 1];
                    input[j + 1] = temp;
                }
            }
            return input;
        }
    }
}