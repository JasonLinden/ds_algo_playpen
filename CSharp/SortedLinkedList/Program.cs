using System;

namespace SortedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var thelist = new LinkedList();

            thelist.Insert(55);
            thelist.Insert(455);
            thelist.Insert(3055);
            thelist.Insert(595);
            thelist.Insert(575);
            thelist.Insert(2555);
            thelist.Insert(555);

            thelist.DisplayList();
        }
    }
}
