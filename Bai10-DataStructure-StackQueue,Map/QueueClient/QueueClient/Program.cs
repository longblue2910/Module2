using System;

namespace QueueClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue(4);
            queue.Enqueue(4);
            queue.Dequeue();
            queue.Enqueue(56);
            queue.Enqueue(2);
            queue.Enqueue(67);
            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue(24);
            queue.Dequeue();
            queue.Enqueue(98);
            queue.Enqueue(45);
            queue.Enqueue(23);
            queue.Enqueue(435);
        }
    }
}
