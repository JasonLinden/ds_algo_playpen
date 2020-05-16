using System;

namespace Quicksort
{
    class Program
    {
        static int[] _theArray;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            _theArray = new int[16];

            var r = new Random();

            for (int i = 0; i < 16; i++)
            {
                _theArray[i] = r.Next(500);
            }

            QuickSort(0, _theArray.Length - 1);
        }

        static void QuickSort(int left, int right)
        {
            // base case
            if (right - left <= 0)
                return;
            else
            {
                int pivot = MedianOf3(left, right);

                var partition = Partition(left, right, pivot);
                QuickSort(left, partition - 1);
                QuickSort(partition + 1, right);
            }
        }

        public static int Partition(int left, int right, int pivot)
        {
            // we want to start one index to the left and to the right.
            int leftPrt = left - 1;
            int rightPrt = right;

            // Keep going until paths cross
            while (true)
            {
                while (_theArray[++leftPrt] < pivot)
                    ;

                while (rightPrt > 0 && // This is so it doesnt go off the end of the array.
                    _theArray[--rightPrt] > pivot)
                    ;

                if (leftPrt >= rightPrt)
                    break;
                else
                    // Once we get to this point we can be sure that the two values need to be swapped.
                    Swap(leftPrt, rightPrt);
            }

            // We do this to restore the pivot in the leftmost index within the right subarray.
            Swap(leftPrt, right);

            return leftPrt;
        }

        private static void Swap(int leftPrt, int rightPrt)
        {
            int temp = _theArray[leftPrt];
            _theArray[leftPrt] = _theArray[rightPrt];
            _theArray[rightPrt] = temp;
        }

        private static int MedianOf3(int left, int right)
        {
            var centre = (left + right) / 2;

            if (_theArray[left] > _theArray[centre])
                Swap(left, centre);

            if (_theArray[left] > _theArray[right])
                Swap(left, right);

            if (_theArray[centre] > _theArray[right])
                Swap(centre, right);

            Swap(centre, right);
            return _theArray[right];
        }

        private static void InsertionSort(int left, int right)
        {
            for (int i = left + 1; i < right; i++)
            {
                var temp = _theArray[i];
                var inner = i;

                while (inner > left && _theArray[inner - 1] >= temp)
                {
                    _theArray[inner] = _theArray[inner - 1];
                    --inner;
                }

                _theArray[inner] = temp;
            }
        }
    }
}
