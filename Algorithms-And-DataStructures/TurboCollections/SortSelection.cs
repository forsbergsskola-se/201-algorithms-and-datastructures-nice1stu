namespace TurboCollections
{
    public static class SortSelection
    {
        //Selection Sort - Selection Sort is a sorting algorithm that finds the minimum value in the array for each iteration of the loop.
        public static List<int> SelectionSort(List<int> n)
        {
            for (int i = 0; i < n.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n.Count; j++)
                {
                    if (n[j] >= n[minIndex]) continue;
                    minIndex = j;
                }
                (n[i], n[minIndex]) = (n[minIndex], n[i]);
            }
            return n;
        }
    }
}