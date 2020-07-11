using System;

namespace _234_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var theTree = new _234Tree();

            theTree.Insert(50);
            theTree.Insert(40);
            theTree.Insert(60);
            theTree.Insert(30);
            theTree.Insert(70);

            while (true)
            {
                Console.WriteLine("Enter the first letter of");
                Console.WriteLine("show, insert or find: ");

                var charChoice = Console.ReadLine();

                switch (charChoice)
                {
                    case "s":
                        theTree.DisplayTree();
                        break;
                    case "i":
                        Console.WriteLine("Insert a number to insert ");
                        var insChoice = Console.ReadLine();
                        theTree.Insert(Convert.ToInt64(insChoice));
                        break;
                    case "f":
                        Console.WriteLine("Enter value to find: ");
                        var fChoice = Console.ReadLine();
                        int found = theTree.Find(Convert.ToInt64(fChoice));
                        if (found != -1)
                            Console.WriteLine("Found " + found);
                        else
                            Console.WriteLine("Could not find value " + fChoice);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
