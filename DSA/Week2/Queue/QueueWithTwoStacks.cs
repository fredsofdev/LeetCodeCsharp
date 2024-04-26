using DSA.Week2.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Queue
{
    internal class QueueWithTwoStacks : IQueue<string>
    {
        private readonly IStack<string> enqueueStack;
        private readonly IStack<string> dequeueStack;

        public QueueWithTwoStacks()
        {
            this.dequeueStack = new LinkedListStack();
            this.enqueueStack = new LinkedListStack();
        }

        public string dequeue()
        {
            if (dequeueStack.isEmpty())
                Transfer();
            
            if (dequeueStack.isEmpty()) 
                throw new InvalidOperationException("Queue is empty");

            return dequeueStack.pop();
        }

        public void enqueue(string item)
        {
            enqueueStack.push(item);
        }

        public bool isEmpty()
        {
            return enqueueStack.isEmpty() && dequeueStack.isEmpty();
        }

        private void Transfer()
        {
            while (!enqueueStack.isEmpty()) 
                dequeueStack.push(enqueueStack.pop());
        }


    }
}
