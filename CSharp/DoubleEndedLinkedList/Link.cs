namespace DoubleEndedLinkedList
{
    public class Link
    {
        public Link(int data)
        {
            iData = data;
        }

        public int iData;
        public Link next;

        public void DisplayLink()
        {
            System.Console.WriteLine($"{ iData } ");
        }
    }
}
