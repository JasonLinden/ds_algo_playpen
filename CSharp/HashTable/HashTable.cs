using System;
using System.Collections.Generic;

namespace Hash
{
    public class HashTable
    {
        private DataItem[] _hashArray;
        private int _hashSize;
        private DataItem _nonItem; // For deleted items
        private Dictionary<int, long> _numCollisions = new Dictionary<int, long>();

        public HashTable(int size)
        {
            _hashSize = size;
            _hashArray = new DataItem[size];
            _nonItem = new DataItem(-1); // deleted item key is -1
        }

        public void DisplayTable()
        {
            Console.WriteLine("Table:");
            for (int i = 0; i < _hashSize; i++)
            {
                if (_hashArray[i] != null)
                    Console.Write(_hashArray[i].GetKey() + " ");
                else
                    Console.Write("** ");

                Console.WriteLine("");
            }
        }

        public int HashFunc(int key)
        {
            return key % _hashSize;
        }

        public int HashFunc2(int key)
        {
            return 7 - (key % 7);
        }

        public DataItem Find(int key)
        {
            int hashVal = HashFunc(key);
            int stepSize = HashFunc2(key);

            while (_hashArray[hashVal] != null)
            {
                if (_hashArray[hashVal].GetKey() == key)
                {
                    return _hashArray[hashVal];
                }

                hashVal += stepSize;
                hashVal %= _hashSize;
            }

            return null;
        }

        public void Insert(DataItem item)
        {
            int key = item.GetKey();
            int hashValue = HashFunc(key); // Get the index.
            int stepSize = HashFunc2(key); // Get the step size IF hashValue is used by another value.

            while (_hashArray[hashValue] != null &&
                _hashArray[hashValue].GetKey() != -1)
            {
                _numCollisions.Add(hashValue, key);
                hashValue += stepSize;
                hashValue %= _hashSize;
            }

            _hashArray[hashValue] = item;
        }

        public DataItem Delete(int key)
        {
            int hashVal = HashFunc(key);
            int stepSize = HashFunc2(key);

            while (_hashArray[hashVal] != null)
            {
                if (_hashArray[hashVal].GetKey() == key)
                {
                    DataItem temp = _hashArray[hashVal];
                    _hashArray[hashVal] = _nonItem;
                    return temp;
                }

                hashVal += stepSize;
                hashVal %= _hashSize;
            }

            return null;
        }
    }
}
