using System;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var pq = new PriorityQ(5);

            pq.Enqeue(5);
            pq.Enqeue(55);
            pq.Enqeue(511);
            pq.Enqeue(25);
            pq.Enqeue(665);

            while (!pq.IsEmpty())
            {
                Console.WriteLine(pq.Dequeue());
            }

            Console.ReadKey();
        }
    }
}
