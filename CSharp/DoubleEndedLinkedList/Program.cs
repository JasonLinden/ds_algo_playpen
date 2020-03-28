using System;

namespace DoubleEndedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var theList = new DoubleEndedLinkedList.LinkedList();

            theList.InsertFirst(22);
            theList.InsertFirst(44);
            theList.InsertFirst(66);

            theList.InsertLast(11);
            theList.InsertLast(33);
            theList.InsertLast(55);

            theList.DisplayList();

            theList.DeleteFirst();
            theList.DeleteFirst();

            theList.DisplayList();

            Console.ReadKey();
        }
    }
}
