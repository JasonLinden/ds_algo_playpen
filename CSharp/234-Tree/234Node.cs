using System;

namespace _234_Tree
{
    // The Node class contains two arrays: childArray and itemArray.The first is four cells
    // long and holds references to whatever children the node might have.The second is
    // three cells long and holds references to objects of type DataItem contained in the
    // node.

    // It is important to remember that items in the itemArray (data items) need to be ordered to restore the search tree principles.
    public class _234Node
    {
        // We can also store the number of items as well as the parent node' reference. This is a small price to pay in terms of storage space with
        // a potentially big help when dealing with logic.

        // Various small utility routines are provided in the Node class to manage the connections to child and parent and to check if the node is full and if it is a leaf.However,
        // the major work is done by the findItem(), insertItem(), and removeItem() routines,
        // which handle individual items within the node.

        private const int ORDER = 4;
        private int numItems;
        private _234Node parent;

        private _234Node[] childArray = new _234Node[ORDER];
        private _234DataItem[] itemArray = new _234DataItem[ORDER - 1];

        public void ConnectAChild(int childNumber, _234Node child)
        {
            childArray[childNumber] = child;


            if (child != null)
            {
                child.parent = this;
            }
        }

        public _234Node DisconnectAChild(int childNum)
        {
            var temp = childArray[childNum];

            childArray[childNum] = null;

            return temp;
        }

        public _234Node GetChild(int childNum)
        {
            return childArray[childNum];
        }

        public _234Node GetParent()
        {
            return parent;
        }

        public bool IsLeaf()
        {
            return childArray[0] == null;
        }

        //return index of item if found, otherwise return -1
        public int FindItem(long key)
        {
            // Loop over data items in this node
            for (int i = 0; i < ORDER - 1; i++)
            {
                if (itemArray[i].dData == key)
                    return i;
                else if (itemArray[i] == null)
                    break;
            }

            return -1;
        }

        internal int GetNumItems()
        {
            return numItems;
        }

        public int InsertItem(_234DataItem newItem)
        {
            numItems++;
            long newKey = newItem.dData;

            for (int i = ORDER - 2; i >= 0; i--)
            {
                if (itemArray[i] == null)
                    continue;
                else
                {
                    var thisKey = itemArray[i].dData;

                    if (newKey < thisKey)
                        itemArray[i + 1] = itemArray[i];
                    else
                    {
                        itemArray[i + 1] = newItem;
                        return i + 1;
                    }
                }
            }

            itemArray[0] = newItem;
            return 0;
        }

        public _234DataItem RemoveItem() // remove the largest item
        {
            var temp = itemArray[numItems - 1];
            itemArray[numItems - 1] = null;

            numItems--;

            return temp;
        }

        public void DisplayNode()
        {
            for (int i = 0; i < numItems; i++)
            {
                itemArray[i].DisplayItem();
            }

            Console.WriteLine("/");
        }

        internal bool IsFull()
        {
            return numItems == (ORDER - 1);
        }

        public _234DataItem GetItem(int index)
        {
            return itemArray[index];
        }
    }
}
