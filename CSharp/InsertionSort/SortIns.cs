namespace InsertionSort
{
    public class SortIns
    {
        private readonly int[] _arr;
        private int _numItems;

        public SortIns(int max)
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
            for (int i = 1; i < _numItems; i++)
            {
                var temp = _arr[i];
                var counter = i;

                while (counter > 0 && _arr[counter - 1] >= temp)
                {
                    _arr[counter] = _arr[counter - 1];
                    --counter;
                };

                _arr[counter] = temp;
            }
        }
    }
}
