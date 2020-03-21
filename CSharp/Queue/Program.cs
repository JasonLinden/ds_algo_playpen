using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new Queuex<int>(5);

            q.Enqueue(3);
            q.Enqueue(13);
            q.Enqueue(34);
            q.Enqueue(55);

            q.Dequeue();
            q.Dequeue();
            q.Dequeue();

            q.Enqueue(90);
            q.Enqueue(91);
            q.Enqueue(92);
            q.Enqueue(93);
            q.Enqueue(93);
            q.Enqueue(93);
        }
    }
}
