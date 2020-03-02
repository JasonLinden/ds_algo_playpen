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
            // i++ means 'tell me the value of i, then increment'
            // ++i means 'increment i, then tell me the value'

            _arr[_numItems++] = value;
        }

        // The idea is to work through the array and partition the array into sorted on the left
        // and unsorted on the right.

        // We take out the left most unsorted item and compare it with the sorted partition (right of the item).
        // This enables us to find where the item needs to go.

        public void SortArray()
        {
            for (int i = 1; i < _numItems; i++)
            {
                var temp = _arr[i];
                var inner = i;

                while(inner > 0 && _arr[inner - 1] > temp)
                {
                    _arr[inner] = _arr[inner - 1];
                    inner--;
                }

                _arr[inner] = temp;
            }
        }
    }
}
