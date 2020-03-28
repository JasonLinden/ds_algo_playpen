namespace SortedLinkedList
{
    public class LinkedList
    {
        private Link _first;

        public LinkedList()
        {
            _first = null;
        }

        public bool IsEmpty()
        {
            return _first == null;
        }

        // A queue will follow the first in first out approach where new items will be inserted last at the back of the queue
        // and new items will be removed from the front of the queue.
        public void Insert(int data)
        {
            var link = new Link(data);

            if (_first == null)
            {
                _first = link;
                return;
            }

            Link current = _first;
            Link previous = null;

            while (current != null && current.Data < data)
            {
                previous = current;
                current = current.next;
            }

            previous.next = link;
            link.next = current;
        }

        public Link DeleteFirst()
        {
            var temp = _first;
            _first = _first.next;

            return temp;
        }

        public void DisplayList()
        {
            var current = _first;

            while (current != null)
            {
                System.Console.Write($"{current.Data} ");
                current = current.next;
            }
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
