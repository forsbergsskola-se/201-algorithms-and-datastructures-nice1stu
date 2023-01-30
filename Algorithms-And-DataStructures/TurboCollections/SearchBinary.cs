namespace TurboCollections;

public class SearchBinary
{
    public int BinarySearchDisplay(int[] arr, int key)
    {
        int minNum = 0;
        int maxNum = arr.Length - 1;
    
        while (minNum <= maxNum) {
            int mid = (minNum + maxNum) / 2;
            if (key == arr[mid]) {
                return mid;
            } else if (key < arr[mid]) {
                maxNum = mid - 1;
            } else {
                minNum = mid + 1;
            }
        }
        return -1;
    }
}