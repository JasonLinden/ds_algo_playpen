namespace LinkedListStack
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

        public void InsertFirst(int data)
        {
            var newLink = new Link(data);
            newLink.next = _first;

            _first = newLink;
        }

        public Link DeleteFirst()
        {
            var temp = _first;
            _first = _first.next;

            return temp;
        }
    }
}
