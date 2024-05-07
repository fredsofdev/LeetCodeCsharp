using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Queue
{
    internal class LinkedListQueue : IQueue<string>
    {
        private Node? first, last;

        class Node
        {
            public string value { get; set; }
            public Node next { get; set; }
        }

        public string dequeue()
        {
            if(first == null) return "";

            string value = first.value;
            first = first.next;
            if(isEmpty()) last = null;
            return value;
        }

        public void enqueue(string item)
        {
            Node oldlast = last;
            last = new Node();
            last.value = item;

            if (isEmpty()) first = last;
            else oldlast.next = last;
        }

        public bool isEmpty()
        {
            return first == null;
        }
    }
}
