using System;
using System.Collections;

namespace Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            DataItem dataItem;
            int key;
            int size;
            int n;
            int keysPerCell = 10;

            Console.WriteLine("Enter size of hash table:");
            size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter initial number of items:");
            n = int.Parse(Console.ReadLine());

            HashTable theTable = new HashTable(size);

            Hashtable hashtable = new Hashtable(size);

            hashtable.Add("awe", theTable);
            hashtable.Add(1, "aweawr");

            foreach(var item in hashtable.Values)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < n; i++)
            {
                key = Math.Abs(new Random().Next() * 2 * size);

                dataItem = new DataItem(key);
                theTable.Insert(dataItem);
            }

            while (true)
            {
                Console.WriteLine("Enter first letter of ");
                Console.WriteLine("show, insert, delete, or find: ");

                char choice = char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 's':
                        theTable.DisplayTable();
                        break;
                    case 'i':
                        Console.WriteLine("Enter key value to insert: ");
                        key = int.Parse(Console.ReadLine());
                        dataItem = new DataItem(key);
                        theTable.Insert(dataItem);
                        break;
                    case 'd':
                        Console.WriteLine("Enter key value to delete: ");
                        key = int.Parse(Console.ReadLine());
                        theTable.Delete(key);
                        break;
                    case 'f':
                        Console.WriteLine("Enter key value to find: ");
                        key = int.Parse(Console.ReadLine());
                        dataItem = theTable.Find(key);

                        if (dataItem != null)
                        {
                            Console.WriteLine("Found: " + key);
                        }
                        else
                        {
                            Console.WriteLine("Could not find: " + key);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
