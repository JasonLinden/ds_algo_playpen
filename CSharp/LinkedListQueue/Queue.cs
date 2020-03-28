namespace LinkedListQueue
{
    public class Queue
    {
        private LinkedList theList; 

        public Queue()
        {
            theList = new LinkedList();
        }

        public void Enqueue(int data)
        {
            theList.InsertLast(data);
        }

        public int Dequeue()
        {
            return theList.DeleteFirst().Data;
        }

        public bool IsEmpty()
        {
            return theList.IsEmpty();
        }
    }
}
