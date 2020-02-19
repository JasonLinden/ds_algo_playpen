namespace SelectionSort
{
    public class SortSelec
    {
        private readonly int[] _arr;
        private int _numItems;

        public SortSelec(int max)
        {
            _numItems = 0;
            _arr = new int[max];
        }

        public void Insert(int value)
        {
            _arr[_numItems++] = value;
        }

        public void SortArray()
        {
            // Here we start at the left most item that is not sorted, IE the first iteration none will be sorted.
            // After the first iteration, we can safely assume that the value on the left of (i) are sorted.
            for (int i = 0; i < _numItems - 1; i++)
            {
                // As we move along we record the left most value that is not sorted.
                var smallest = i;

                // We go along the rest of the values and compare each with our current smallest value.
                // If an item of the right is smaller, then we set that value as the new smallest.
                for (int j = i + 1; j < _numItems; j++)
                {
                    // Compare
                    if (_arr[j] < _arr[smallest])
                        smallest = j;
                }

                // Once we have looked at every value, we swap the smallest value with the left most unsorted value (i)
                // Swap
                SwapItems(smallest, i);
            }
        }

        private void SwapItems(int smallest, int i)
        {
            var temp = _arr[i];
            _arr[i] = _arr[smallest];
            _arr[smallest] = temp;
        }
    }
}
