namespace PriorityQueue
{
    public class PriorityQ
    {
        private readonly int _maxSize;
        private int _nItems;
        private readonly int[] _arr;

        public PriorityQ(int maxSize)
        {
            _arr = new int[maxSize];
            _maxSize = maxSize;
            _nItems = 0;
        }

        // This is the slow insertion approach. 
        // The faster appraoach is using the heap as the underlying data structure.
        public void Enqeue(int value)
        {
            if (_nItems == 0)
                _arr[_nItems++] = value;
            else
            {
                int i;

                // Here we basically loop from the top of the array or 'front'
                // which holds the lowest value but highest priority.
                // We check if our new item is greater than current item, if it is then we move the current item up one and check the next item.
                for (i = _nItems - 1; i >= 0; i--)
                {
                    if (value > _arr[i])
                    {
                        _arr[i + 1] = _arr[i];
                        continue;
                    }

                    break;
                }

                _arr[i + 1] = value;
                _nItems++;
            }
        }

        public int Dequeue()
        {
            return _arr[--_nItems];
        }

        public int Peek()
        {
            return _arr[_nItems - 1];
        }

        public bool IsFull()
        {
            return _nItems == _maxSize;
        }

        public bool IsEmpty()
        {
            return _nItems == 0;
        }
    }
}
