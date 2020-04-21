using System;

namespace RecursiveBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new BinSearch(10);

            a.Insert(145);
            a.Insert(415);
            a.Insert(4515);
            a.Insert(45);
            a.Insert(4587);
            a.Insert(475);
            a.Insert(425);
            a.Insert(452);
            a.Insert(4545);
            a.Insert(4655);

            var res = a.Find(4545);
            Console.WriteLine(res);

            Console.Read();
        }
    }
}
