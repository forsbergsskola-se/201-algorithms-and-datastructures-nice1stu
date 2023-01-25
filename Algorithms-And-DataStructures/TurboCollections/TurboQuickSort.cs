using System;

namespace TurboCollections
{
    public class TurboQuickSort
    {
        public static int partitionFunc(int[] A, int left, int right, int pivot)
        {
            int leftPointer = left;
            int rightPointer = right - 1;

            while (true)
            {
                while (A[++leftPointer] < pivot) { }

                while (rightPointer > 0 && A[--rightPointer] > pivot) { }

                if (leftPointer < rightPointer)
                {
                    (A[leftPointer], A[rightPointer]) = (A[rightPointer], A[leftPointer]);
                }
                else
                {
                    break;
                }
            }

            (A[leftPointer], A[right]) = (A[right], A[leftPointer]);
            return leftPointer;
        }

        public static void quickSort(int[] A, int left, int right)
        {
            if (right - left > 0)
            {
                int pivot = A[right];
                int partition = partitionFunc(A, left, right, pivot);
                quickSort(A, left, partition - 1);
                quickSort(A, partition + 1, right);
            }
            else
                return;
        }

    }
}