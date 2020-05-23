namespace BST
{
    // The node class will contain the data representing tge objects being stored.
    public class BSTNode
    {
        // this could also be a POCO. ie Person object
        // this may make it clear that the node and data item are not the same thing.
        public int iData;
        public double fData;

        public BSTNode leftChild;
        public BSTNode rightChild;

        public void DisplayNode()
        {

        }
    }
}
