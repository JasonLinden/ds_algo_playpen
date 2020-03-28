using System;

namespace LinkedListQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue();

            Console.WriteLine($"{queue.IsEmpty()}");

            queue.Enqueue(55); // First in
            queue.Enqueue(65);
            queue.Enqueue(75);
            queue.Enqueue(85);
            queue.Enqueue(95);

            queue.Dequeue(); // First out
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine($"{queue.Dequeue()} should equal 95");
        }
    }
}
