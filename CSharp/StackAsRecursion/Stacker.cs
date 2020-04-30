namespace StackAsRecursion
{
    class Stacker<T> where T : class
    {
        private readonly T[] _arr;
        private readonly int _maxSize;
        private int _top;

        public Stacker(int max)
        {
            _arr = new T[max];
            _maxSize = max;
            _top = -1;
        }

        public void Push(T value)
        {
            _arr[++_top] = value; // increment top and then access/index item;
        }

        public T Pop()
        {
            return _arr[_top--]; // access item. them decrement top;
        }

        internal bool IsEmpty()
        {
            return _top == -1;
        }

        public T Peek()
        {
            return _arr[_top];
        }
    }
}
