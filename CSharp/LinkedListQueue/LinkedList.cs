namespace LinkedListQueue
{
    public class LinkedList
    {
        private Link _first;
        private Link _last;

        public LinkedList()
        {
            _first = null;
            _last = null;
        }

        public bool IsEmpty()
        {
            return _first == null;
        }

        // A queue will follow the first in first out approach where new items will be inserted last at the back of the queue
        // and new items will be removed from the front of the queue.

        public void InsertLast(int data)
        {
            var newLink = new Link(data);

            if (IsEmpty())
                _first = newLink;
            else
                _last.next = newLink;

            _last = newLink;
        }

        public Link DeleteFirst()
        {
            var temp = _first;
            if (_first.next == null) // if the is only one item in the list
                _last = null;

            _first = _first.next;

            return temp;
        }
    }

    public class Link
    {
        public Link(int data)
        {
            Data = data;
        }

        public int Data;
        public Link next;
    }
}
