namespace SimpleAlgos
{
    public class BinarySearch
    {
        private readonly int[] _arr;
        private int _nElems;

        public BinarySearch(int maxSize)
        {
            _arr = new int[maxSize];
            _nElems = 0;
        }

        public void Insert(int value)
        {
            // We can use the binary search algo to 
            // find where to place a new value.

            int lowerBound = 0;
            int upperBound = _nElems - 1;
            int j = 0;

            // We keep going until lower is greater than upper, this will be the index to insert.
            while (lowerBound <= upperBound)
            {
                // Select a value in the middle of our current array
                j = (lowerBound + upperBound) / 2;

                // If the value we want to add is bigger than the middle, 
                // move the lower range to the middle + 1
                // Essentially we are now looking at the upper part
                if (value > _arr[j])
                {
                    lowerBound = j + 1;
                    j++;
                }
                // If our new value is less than half, we must look in the looker part rather.
                else
                {
                    upperBound = j - 1;
                }
            }

            // we loop from the top of the array and move all the items up a 
            // place which are greater than our new value.
            for (int k = _nElems; k > j; k--)
                _arr[k] = _arr[k - 1];

            _arr[j] = value;
            _nElems++;
        }

        public int Search(int searchValue)
        {
            int upperBound = _nElems - 1;
            int lowerBound = 0;

            int curIn = 0;

            while (lowerBound <= upperBound)
            {
                curIn = (lowerBound + upperBound) / 2;

                if (_arr[curIn] == searchValue)
                    return curIn;

                if (_arr[curIn] < searchValue)
                {
                    lowerBound = curIn + 1;
                }
                else
                {
                    upperBound = curIn - 1;
                }
            }

            return _nElems;
        }
    }
}
