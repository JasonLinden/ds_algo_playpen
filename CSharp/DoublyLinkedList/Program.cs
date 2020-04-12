using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var theList = new LinkedList();

            theList.InsertFirst(22); // 22
            theList.InsertFirst(44); // 44, 22
            theList.InsertFirst(66); // 66, 44, 22

            theList.InsertLast(11); // 66, 44, 22, 11
            theList.InsertLast(33); // 66, 44, 22, 11, 33
            theList.InsertLast(55); // 66, 44, 22, 11, 33, 55

            theList.TraverseForward(); // From 66 -> 55
            theList.TraverseBackward(); // From 55 -> 66

            theList.DeleteFirst(); // 44, 22, 11, 33, 55
            theList.DeleteLast(); // 44, 22, 11, 33
            theList.DeleteKey(11); // 44, 22, 33

            theList.TraverseForward(); // From 44 -> 33

            theList.InsertAfter(22, 77); // 44, 22, 77, 33
            theList.InsertAfter(33, 88); // 44, 22, 77, 33, 88

            theList.TraverseForward(); // From 44 -> 88

            // Using Iterator 
            foreach (var item in theList.GetIterator())
            {
                // Here we can loop over the list and perform opertaions a perticular link,
                // Rather than having to find the item using link.find();
                Console.WriteLine(item.iData);
            }

            Console.ReadKey();
        }
    }
}
