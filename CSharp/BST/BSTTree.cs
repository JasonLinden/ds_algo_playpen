using System;

namespace BST
{
    public class BSTTree
    {
        // This will act at the proxy to the tree
        // It houses all the relevant operation and also a reference to the root node.

        private BSTNode root;

        // This function can also be recursive
        public BSTNode Find(int key)
        {
            var current = root;

            while (current.iData != key)
            {
                if (key > current.iData)
                    _ = current.rightChild;
                else
                    _ = current.leftChild;

                return null;
            }

            return current;
        }

        public BSTNode FindRec(int key)
        {
            return Find(key, root);
        }

        private BSTNode Find(int key, BSTNode node)
        {
            if (key < node.iData)
                return Find(key, node.leftChild);
            else if (key > node.iData)
                return Find(key, node.rightChild);

            return null;
        }

        public void Insert(int id, double dd)
        {
            var node = new BSTNode
            {
                iData = id,
                fData = dd
            };

            if (root == null)
                root = node;
            else
            {
                var current = root;

                while (true)
                {
                    BSTNode parent = current;
                    if (id < current.iData) // search to the left
                    {
                        current = current.leftChild;

                        if (current == null) // end of tree
                        {
                            parent.leftChild = node; // set previous current (parent)'s left child to be new node
                            return;
                        }
                    }
                    else // go right
                    {
                        current = current.rightChild;

                        if (current == null)
                        {
                            parent.rightChild = node;
                            return;
                        }
                    }
                }
            }
        }

        public bool Delete(int id)
        {
            var current = root;
            var parent = root;
            var isLeftChild = true;

            while (current.iData != id)
            {
                parent = current;

                if (current.iData < id)
                {
                    isLeftChild = true;
                    current = current.leftChild;
                }
                else
                {
                    isLeftChild = false;
                    current = current.rightChild;
                }

                if (current == null) // not in the tree
                    return false;
            }

            // CASE 1 : LEAF NODE
            if (current.leftChild == null && current.rightChild == null)
            {
                if (current == root)
                    root = null;
                else if (isLeftChild)
                    parent.leftChild = null;
                else
                    parent.rightChild = null;
            }
            else if (current.leftChild == null) // this if will execute if the node to be deleted has a right child but no left
            {
                // basically if the node we want to delete has a right subtree then set parent node to now equal the 
                // right subtree rather than the current node (which is being deleted)

                if (current == root)
                    root = current.rightChild;
                else if (isLeftChild)
                    parent.leftChild = current.rightChild;
                else
                    parent.rightChild = current.rightChild;
            }
            else if (current.rightChild == null)
            {
                if (current == root)
                    root = current.leftChild;
                else if (isLeftChild)
                    parent.leftChild = current.leftChild;
                else
                    parent.rightChild = current.leftChild;
            }
            else  // two children, so replace with inorder successor
            {
                var successor = GetSuccessor(current);

                if (current == root)
                    root = successor;
                else if (isLeftChild)
                    parent.leftChild = successor;
                else
                    parent.rightChild = successor;

                // connect successor to current's left child
                successor.leftChild = current.leftChild;
            }

            return true;
        }

        public void InOrderTraverse(BSTNode node)
        {
            if (node != null)
            {
                InOrderTraverse(node.leftChild);

                Console.WriteLine($"Visit {node.iData}");

                InOrderTraverse(node.rightChild);
            }
        }

        public BSTNode Minumum()
        {
            var current = root;
            var parent = root;

            while (current != null)
            {
                parent = current;
                current = current.leftChild;
            }

            return parent;
        }

        // This function assumes that delNode does indeed have a right child, but we 
        // know this is true because we’ve already determined that the node to be deleted has two children.
        private BSTNode GetSuccessor(BSTNode nodeToDel)
        {
            // returns node with next-highest value after delNode // goes to right child, then right child’s left descendant
            var parent = nodeToDel;
            var successor = nodeToDel;

            var current = nodeToDel.rightChild;

            while (current != null)
            {
                parent = successor;
                successor = current;
                current = current.leftChild;
            }

            if (successor != nodeToDel.rightChild)
            {
                parent.leftChild = successor.rightChild; // Here we are moving right subtree of successor up a level
                successor.rightChild = nodeToDel.rightChild; // Here we are re assigning the subtree to the successor
            }

            return successor;
        }
    }
}
