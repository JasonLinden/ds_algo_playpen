using System;

namespace DoublyLinkedList
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

        public void InsertFirst(int data)
        {
            var newLink = new Link(data);

            if (IsEmpty())
            {
                _last = newLink;
            }
            else
            {
                _first.previous = newLink;
            }

            newLink.next = _first;
            _first = newLink;
        }

        internal Link GetFirst()
        {
            return _first;
        }

        public void InsertLast(int data)
        {
            var newLink = new Link(data);

            if (IsEmpty())
            {
                _first = newLink;
            }
            else
            {
                // This can only happen if the list is not empty
                _last.next = newLink;
                newLink.previous = _last;
            }

            _last = newLink; // This will alwasy happen, whether the list is empty or not.
        }

        public bool InsertAfter(int key, int data)
        {
            var current = _first;

            while (current.iData != key)
            {
                current = current.next;

                if (current == null)
                    return false;
            }

            var newLink = new Link(data);

            if (current == _last)
            {
                newLink.next = current.next;
                _last = newLink;
            }
            else
            {
                // Next
                newLink.next = current.next;
                current.next.previous = newLink;
            }

            // Previous
            newLink.previous = current;
            current.next = newLink;

            return true;
        }

        public Link DeleteFirst()
        {
            var temp = _first;

            if (_first.next == null) // Only item
            {
                _last = null;
            }
            else
            {
                _first.next.previous = _first.previous;
            }

            _first = _first.next;

            return temp;
        }

        public Link DeleteLast()
        {
            var temp = _last;

            if (_first.next == null)
            {
                _first = null;
            }
            else
            {
                _last.previous.next = null;
            }

            _last = _last.previous;

            return temp;
        }

        public Link DeleteKey(int key)
        {
            var current = _first;

            while (current.iData != key)
            {
                current = current.next;
                if (current == null)
                    return null;
            }

            if (current == _first)
                _first = current.next;
            else
            {
                current.previous.next = current.next;
            }

            if (current == _last)
                _last = current.previous;
            else
            {
                current.next.previous = current.previous;
            }

            return current;
        }

        public void TraverseForward()
        {
            Console.WriteLine("List (First to Last): ");

            var current = _first;

            while (current != null)
            {
                current.DisplayLink();
                current = current.next;
            }

            Console.WriteLine("");
        }

        public void TraverseBackward()
        {
            Console.WriteLine("List (Last to First): ");

            var current = _last;

            while (current != null)
            {
                current.DisplayLink();
                current = current.previous;
            }

            Console.WriteLine("");
        }

        public Iterator GetIterator()
        {
            return new Iterator(this);
        }
    }

    public class Link
    {
        public Link(int data)
        {
            iData = data;
        }

        public int iData;
        public Link next;
        public Link previous;

        public void DisplayLink()
        {
            Console.Write($"{iData} ");
        }
    }
}
