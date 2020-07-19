namespace Hash
{
    public class DataItem
    {
        private int _data;

        public DataItem(int data)
        {
            _data = data;
        }

        public int GetKey()
        {
            return _data;
        }
    }
}
