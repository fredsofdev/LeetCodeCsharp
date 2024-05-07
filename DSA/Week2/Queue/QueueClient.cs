using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Queue
{
    internal class QueueClient
    {
        public static void Run()
        {
            Console.WriteLine("Linked List Queue: - for dequeue");
            IQueue<string> stack = new LinkedListQueue();
            while (true)
            {
                string? input = Console.ReadLine();
                if (input == "-")
                {
                    if (stack.isEmpty()) continue;
                    Console.WriteLine($"=> {stack.dequeue()}");
                }
                else if (input == null) continue;
                else stack.enqueue(input);
            }
        }
    }
}
