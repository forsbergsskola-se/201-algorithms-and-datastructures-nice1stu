namespace TurboCollections;

public static class SortQuick
{
    /*public static void QuickSort<T>(List<T> arr) where T : IComparable<T>
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

    private static int Partition<T>(IList<T> arr, int low, int high) where T : IComparable<T>
    {
        var pivot = arr[high];
        var i = low - 1;
        for (var j = low; j < high; j++)
        {
            if (arr[j].CompareTo(pivot) > 0) continue;
            i++;
            Swap(arr, i, j);
        }
        Swap(arr, i + 1, high);
        return i;
    }

    private static void Swap<T>(IList<T> arr, int i, int j)
    {
        (arr[i], arr[j]) = (arr[j], arr[i]);
    }*/
    
    function partitionFunc(left, right, pivot)
    leftPointer = left
        rightPointer = right - 1

            while True do
    while A[++leftPointer] < pivot do
    //do-nothing            
    end while
		
    while rightPointer > 0 && A[--rightPointer] > pivot do
    //do-nothing         
    end while
		
    if leftPointer >= rightPointer
    break
    else                
    swap leftPointer,rightPointer
    end if
		
    end while 
	
    swap leftPointer,right
        return leftPointer
	
        end function

        procedure quickSort(left, right)

        if right-left <= 0
    return
    else     
    pivot = A[right]
    partition = partitionFunc(left, right, pivot)
    quickSort(left,partition-1)
    quickSort(partition+1,right)    
    end if		
   
    end procedure
}