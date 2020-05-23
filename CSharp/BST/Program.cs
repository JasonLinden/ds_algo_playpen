using System;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            var theTree = new BSTTree();

            theTree.Insert(50, 4.5);
            theTree.Insert(25, 4.7);
            theTree.Insert(75, 4.9);

            theTree.Find(50);
        }
    }
}
