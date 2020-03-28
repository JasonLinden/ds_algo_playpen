namespace DoubleEndedLinkedList
{
    class LinkedList
    {
        Link _first;
        Link _last;

        public LinkedList()
        {
            _first = null;
            _last = null;
        }

        public bool IsEmpty()
        {
            return _first == null;
        }

        public void InsertFirst(int data)
        {
            var newLink = new Link(data);
            newLink.next = _first;

            if (IsEmpty()) // if the list is empty, set last to equal the same link
                _last = newLink;

            _first = newLink;
        }

        public void InsertLast(int data)
        {
            var newLink = new Link(data);

            if (IsEmpty()) // if the list is empty, set first to equal the same link
                _first = newLink;
            else
                _last.next = newLink; // Only if the list is not empty. in that case _last will never bre null.

            _last = newLink;
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
                System.Console.WriteLine($"{current.iData} ");
                current = current.next;
            }

            System.Console.WriteLine();
        }
    }
}
