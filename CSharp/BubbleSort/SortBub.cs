namespace BubbleSort
{
    public class SortBub
    {
        private readonly int[] _arr;
        private int _numItems;

        public SortBub(int max)
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
            // A bubblesort will look backwards over the length of the array to bubble the tallest bugger.
            // We decrement in order to ignore the last value which of course is the greatest.
            for (int i = _numItems; i > 1; i--)
            {
                // Each iteration within an array will compare two items, 
                // If the item on the left is greater than the item on the right then we swap them.
                // This ensures after a full iteration of i the tallest item is bubbled to the right.
                for (int j = 0; j < i - 1; j++)
                {
                    if (_arr[j] > _arr[j + 1])
                        SwapItems(j);
                }
            }
        }

        private void SwapItems(int j)
        {
            var taller = _arr[j];
            _arr[j] = _arr[j + 1];
            _arr[j + 1] = taller;
        }
    }
}
