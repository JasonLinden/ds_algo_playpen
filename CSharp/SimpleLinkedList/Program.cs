using System;

namespace SimpleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var theList = new LinkedList();

            theList.InsertFirst(1);
            theList.InsertFirst(112);
            theList.InsertFirst(12);
            theList.InsertFirst(134);

            theList.DisplayList();

            var link = theList.FindByKey(1);

            if (link != null)
                Console.WriteLine("Found the mahdir " + link.iData);

            theList.DeleteByKey(1);
                
            theList.DeleteFirst();
            theList.DeleteFirst();

            theList.DisplayList();

            Console.ReadKey();
        }
    }
}
