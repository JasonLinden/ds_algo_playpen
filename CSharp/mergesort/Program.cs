using System;

namespace mergesort
{
    class Program
    {
        static void Main(string[] args)
        {
            var unsortedArray = new int[] { 4, 65, 23, 55, 78, 3424, 56, 77, 2, 50, 89, 12 };

            MergeSort(unsortedArray, 0, unsortedArray.Length - 1);

            Console.ReadLine();
        }

        static void MergeSort(int[] array, int lowerBound, int upperBound)
        {
            // The base case occurs when the range contains only one element
            if (lowerBound == upperBound)
                return;
            else
            {
                int mid = (lowerBound + upperBound) / 2;

                // left hand side array
                MergeSort(array, lowerBound, mid);

                // right side of the array.
                MergeSort(array, mid + 1, upperBound);

                // Once we get here we have two sorted arrays ready to be merge.
                Merge(array, lowerBound, mid, upperBound);
            }
        }

        private static void Merge(int[] array, int lowerBound, int mid, int upperBound)
        {
            int leftTrackingIndex = 0;
            int rightTrackingIndex = 0;
            int lower = lowerBound;

            // create two temp arrays from the ranges.
            int left = mid - lowerBound + 1;
            int[] leftArray = new int[left];

            int right = upperBound - mid;
            int[] rightArray = new int[right];

            // Fill the temp arrays with data from original array
            // loop of the range and insert from lower to mid range
            for (int i = 0; i < left; i++)
            {
                leftArray[i] = array[lowerBound + i];
            }

            // loop of the range and insert from mid + 1 to upper range
            for (int i = 0; i < right; i++)
            {
                rightArray[i] = array[mid + 1 + i];
            }

            // while loop to run from 0 until the size of the temp arrays
            while (leftTrackingIndex < left && rightTrackingIndex < right)
            {
                // insert from the lowerbound and work up, sorting from left to right.
                if (leftArray[leftTrackingIndex] < rightArray[rightTrackingIndex])
                    array[lower++] = leftArray[leftTrackingIndex++];
                else
                    array[lower++] = rightArray[rightTrackingIndex++];
            }

            // if the left array is not empty
            while (leftTrackingIndex < left)
            {
                array[lower++] = leftArray[leftTrackingIndex++];
            }

            while (rightTrackingIndex < right)
            {
                array[lower++] = rightArray[rightTrackingIndex++];
            }
        }

        static void Merge(int[] final, int[] arrayB, int[] arrayC)
        {
            int sizeB = arrayB.Length;
            int sizeC = arrayC.Length;

            int aIndex = 0;
            int bIndex = 0;
            int cIndex = 0;

            // while loop for both arrays.
            // this loop will end if we reach the last index of one of the arrays
            while (bIndex < sizeB && cIndex < sizeC)
            {
                if (arrayB[bIndex] < arrayC[cIndex])
                    final[aIndex++] = arrayB[bIndex++];
                else
                    final[aIndex++] = arrayC[cIndex++];
            }

            // while loop if C is empty
            while (bIndex < sizeB)
            {
                final[aIndex++] = arrayB[bIndex++];
            }

            // while loop if C is empty
            while (cIndex < sizeC)
            {
                final[aIndex++] = arrayC[cIndex++];
            }
        }
    }
}
