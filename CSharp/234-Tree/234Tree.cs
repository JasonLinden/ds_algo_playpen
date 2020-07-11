using System;

namespace _234_Tree
{
    public class _234Tree
    {
        private _234Node root = new _234Node(); // Make the root item

        public int Find(long key)
        {
            var currNode = root;
            int childNumber;

            while (true)
            {
                if ((childNumber = currNode.FindItem(key)) != -1)
                    return childNumber;
                else if (currNode.IsLeaf())
                    return -1;
                else
                    currNode = GetNextChild(currNode, key);
            }
        }

        public void Insert(long dValue)
        {
            var currNode = root;
            var newItem = new _234DataItem(dValue);

            while (true)
            {
                if (currNode.IsFull())
                {
                    // Split this node
                    Split(currNode);

                    currNode = GetNextChild(currNode.GetParent(), dValue);
                }
                else if (currNode.IsLeaf()) // Insert here
                {
                    break;
                }
                else // go deeper - curNode is not full and is not leaf
                    currNode = GetNextChild(currNode, dValue);
            }

            currNode.InsertItem(newItem);
        }

        private void Split(_234Node currNode)
        {
            _234DataItem itemB;
            _234DataItem itemC;

            _234Node parent;
            _234Node child2;
            _234Node child3;

            int itemIndex;

            itemC = currNode.RemoveItem();
            itemB = currNode.RemoveItem();

            child2 = currNode.DisconnectAChild(2);
            child3 = currNode.DisconnectAChild(3);

            var newRightNode = new _234Node();

            if (currNode == root)
            {
                root = new _234Node();
                parent = root;
                root.ConnectAChild(0, currNode);
            }
            else
            {
                parent = currNode.GetParent();
            }

            itemIndex = parent.InsertItem(itemB);
            int n = parent.GetNumItems();

            for (int i = n - 1; i > itemIndex; i--)
            {
                var temp = parent.DisconnectAChild(i);
                parent.ConnectAChild(i + 1, temp);
            }

            parent.ConnectAChild(itemIndex + 1, newRightNode);

            newRightNode.InsertItem(itemC);
            newRightNode.ConnectAChild(0, child2);
            newRightNode.ConnectAChild(1, child3);
        }

        // gets appropriate child of node during search for value
        private _234Node GetNextChild(_234Node currNode, long key)
        {
            int i;
            int numItems = currNode.GetNumItems();

            for (i = 0; i < numItems; i++)
            {
                if (key < currNode.GetItem(i).dData)
                    return currNode.GetChild(i);
            }

            return currNode.GetChild(i); // right most child
        }

        public void DisplayTree()
        {
            RecursivelyDisplayTree(root, 0, 0);
        }

        private void RecursivelyDisplayTree(_234Node node, int level, int child)
        {
            Console.Write($"level=${level} child=${child} ");

            node.DisplayNode();

            int numItems = node.GetNumItems();

            for (int i = 0; i < numItems + 1; i++)
            {
                var nextNode = node.GetChild(i);

                if (nextNode != null)
                    RecursivelyDisplayTree(nextNode, level + 1, i);
                else
                    return;
            }
        }
    }
}
