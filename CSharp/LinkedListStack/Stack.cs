namespace LinkedListStack
{
    public class Stack
    {
        private LinkedList theList;

        public Stack()
        {
            theList = new LinkedList();
        }

        public void Push(int data)
        {
            theList.InsertFirst(data);
        }

        public int Pop()
        {
            return theList.DeleteFirst().iData;
        }

        public bool IsEmpty()
        {
            return theList.IsEmpty();
        }
    }
}
