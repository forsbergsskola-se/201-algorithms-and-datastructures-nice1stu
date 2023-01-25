using System;
using System.Collections.Generic;

namespace TurboCollections
{
    public static partial class TurboSort
    {
        public static void SelectionSort(TurboLinkedList<int> list)
        {
            int n = list.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = 1; j < n; j++)
                {
                    if (list[j] < list[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    (list[min], list[i]) = (list[i], list[min]);
                }
            }

        }
    }
}