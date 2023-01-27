public static class SortQuick
{
    public static void QuickSort<T>(List<T> arr) where T : IComparable<T>
    {
        Sort(arr, 0, arr.Count - 1);
    }

    private static void Sort<T>(List<T> arr, int low, int high) where T : IComparable<T>
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);
            Sort(arr, low, pivotIndex);
            Sort(arr, pivotIndex + 1, high);
        }
    }

    private static int Partition<T>(List<T> arr, int low, int high) where T : IComparable<T>
    {
        T pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (arr[j].CompareTo(pivot) <= 0)
            {
                i++;
                Swap(arr, i, j);
            }
        }
        Swap(arr, i + 1, high);
        return i;
    }

    private static void Swap<T>(List<T> arr, int i, int j)
    {
        T temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}