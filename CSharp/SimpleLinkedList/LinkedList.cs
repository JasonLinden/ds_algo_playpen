namespace SimpleLinkedList
{
    public class LinkedList
    {
        private Link _first;

        public LinkedList()
        {
            _first = null;
        }

        public void InsertFirst(int data)
        {
            var newLink = new Link(data)
            {
                next = _first // new link.next must equal what was first before.
            };
            _first = newLink; // first must now be the new item.
        }

        public Link DeleteFirst()
        {
            var temp = _first;
            _first = _first.next; // Set first to now equal the next link, essentially removing first.

            return temp;
        }

        public Link FindByKey(int key)
        {
            var current = _first;

            while (current.iData != key) // loop over linklist untill current link contains the key
            {
                if (current.next == null) return null;

                // If the current link data is not equal to the key then set current to the next link
                current = current.next;
            }

            // return found link
            return current;
        }

        public Link DeleteByKey(int key)
        {
            // There is a better way of doing this.
            // Perhaps we do not need the prev variable.

            var current = _first;
            var prev = _first;

            // if the first link contains the value
            if (current.iData == key)
            {
                _first = _first.next;

                return _first;
            }

            // Loop over the linked list until the current data is found
            while (current.iData != key)
            {
                if (current.next == null) return null;

                prev = current;
                current = current.next;
            }

            // Set the previous link to reference the current(deleted) next link in order to maintain the link
            prev.next = current.next;

            return current;
        }

        public bool IsEmpty()
        {
            return _first == null;
        }

        public void DisplayList()
        {
            var current = _first;

            while (current != null)
            {
                System.Console.WriteLine(current.iData);

                current = current.next;
            }
        }
    }
}
