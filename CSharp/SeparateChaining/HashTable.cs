using SortedLinkedList;
using System;

namespace SeparateChaining
{
    public class HashTable
    {
        private SortedLinkedList.LinkedList[] _hashArray;
        private int _arraySize;

        public HashTable(int size)
        {
            _arraySize = size;
            _hashArray = new SortedLinkedList.LinkedList[size];

            FillArray();
        }

        private void FillArray()
        {
            for (int i = 0; i < _arraySize; i++)
            {
                _hashArray[i] = new SortedLinkedList.LinkedList();
            }
        }

        public Link Find(int key)
        {
            int hashValue = HashFunc(key);
            return _hashArray[hashValue].FindByKey(key);
        }

        public void Inset(Link item)
        {
            int key = item.Data;
            int hashValue = HashFunc(key);

            _hashArray[hashValue].Insert(item.Data);
        }

        public void Delete(int key)
        {
            int hashValue = HashFunc(key);

            // TODO => Implement delete logic here
        }

        private int HashFunc(int key)
        {
            return key % _arraySize;
        }

        public void DisplayTable()
        {
            for (int i = 0; i < _arraySize; i++)
            {
                System.Console.WriteLine($"{i}. ");
                _hashArray[i].DisplayList();
            }
        }
    }
}
