namespace SimpleAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new BinarySearch(10);

            a.Insert(10);
            a.Insert(443);
            a.Insert(4);
            a.Insert(7);
            a.Insert(96);
            a.Insert(10334);
            a.Insert(55);
            a.Insert(102);
            a.Insert(1034);
            a.Insert(19);

            a.Search(7);
        }
    }
}
