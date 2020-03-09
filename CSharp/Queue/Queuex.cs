namespace Queue
{
    public class Queuex<T>
    {
        private readonly T[] _arr;
        private int _head;
        private int _rear;
        private readonly int _maxSize;

        public Queuex(int maxSize)
        {
            _arr = new T[maxSize];
            _maxSize = maxSize;
            _head = 0;
            _rear = -1;
        }

        /*
         * | 1 |   |   |   | 
         * | 1 | 3 |   |   |
         * | 1 | 3 | 4 |   |
         * | 1 | 3 | 4 | 8 | <-- When we add a new item _rear will equal maxSize - 1, so we either thriw an error or wrap, wrapping will throw out the _head
         * | n | 3 | 4 | 8 | <-- Dequeue from the front, now we can wrap
         * | 9 | 3 | 4 | 8 | <-- now _head = index 1 (3) and _rear = index 0 (9), i.e. a broken sequence 
         * 
         * 
         */

        public void Enqueue(T value)
        {
            // * Find a better way to deal with wrap around - put in a check to see if we can infact wrap around
            if (_rear == _maxSize - 1)
                _rear = -1;

            _arr[++_rear] = value;
        }

        public T Dequeue()
        {
            var value = _arr[_head++];

            // * Find a better way to deal with wrap around
            if (_head == _maxSize - 1)
                _head = 0;

            return value;
        }

        public T Peek()
        {
            return _arr[_head];
        }
    }
}
