using System;

namespace RecursiveBinarySearch
{
    public class BinSearch
    {
        int[] _array;
        int _numElems;

        public BinSearch(int size)
        {
            _numElems = 0;
            _array = new int[size];
        }

        public int Find(int searchValue)
        {
            Array.Sort(_array);
            return BinSearchRecursive(searchValue, 0, _array.Length - 1);
        }

        public void Insert(int val)
        {
            _array[_numElems++] = val;
        }

        // Remember this is performed on a ordered array
        private int BinSearchRecursive(int searchValue, int lower, int upper)
        {
            int currIn = (lower + upper) / 2;

            // this is the base case.
            if (_array[currIn] == searchValue)
                return currIn;

            if (lower > upper)
                return _numElems;

            if (_array[currIn] < searchValue) // it is in the upper half
                return BinSearchRecursive(searchValue, currIn + 1, upper);
            else // it is in the lower half
                return BinSearchRecursive(searchValue, lower, currIn - 1);
        }
    }
}
