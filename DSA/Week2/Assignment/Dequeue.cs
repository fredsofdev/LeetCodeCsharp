using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Assignment
{
    internal class Dequeue<Item> : IEnumerable<Item>
    {
        private ListItem first;
        private ListItem last;
        private int count;
        class ListItem
        {
            public Item item { get; set; }
            public ListItem prev { get; set; }
            public ListItem next { get; set; }
        }

        // is the deque empty?
        public bool isEmpty()
        {
            return first == null || last == null;
        }

        // return the number of items on the deque
        public int size() => count;

        

        // add the item to the front
        public void addFirst(Item item)
        {
            ListItem oldItem = first;
            first = new ListItem();
            first.item = item;
            if (isEmpty()) last = first;
            else
            {
                oldItem.prev = first;
                first.next = oldItem;
            }
            count++;
        }

        // add the item to the back
        public void addLast(Item item)
        {
            ListItem oldItem = last;
            last = new ListItem();
            last.item = item;
            if (isEmpty()) first = last;
            else { 
                oldItem.next = last;
                last.prev = oldItem;
            }
            count++;
        }

        // remove and return the item from the front
        public Item removeFirst()
        {
            Item item = first.item;
            first = first.next;
            if (isEmpty()) last = null;
            else first.prev = null;
            count--;
            return item;
        }

        // remove and return the item from the back
        public Item removeLast()
        {
            Item item = last.item;
            last = last.prev;
            if (isEmpty()) first = null;
            else last.next = null;
            count--;
            return item;
        }

        // return an iterator over items in order from front to back
        public IEnumerator<Item> GetEnumerator()
        {
            ListItem iterator = first;
            while(iterator != null)
            {
                yield return iterator.item;
                iterator = iterator.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public static void Run()
        {
            Console.WriteLine("Dequeue");
            Dequeue<int> queue = new Dequeue<int>();
            queue.addFirst(5);
            queue.addLast(6);
            queue.addFirst(4);
            queue.addLast(7);
            queue.addFirst(3);
            queue.addLast(8);
            queue.addFirst(2);
            queue.addLast(9);
            queue.addFirst(1);
            queue.addLast(10);

            queue.print();
            Console.WriteLine("\nremoveLast");
            queue.removeLast();
            queue.print();
            Console.WriteLine("\nremoveLast");
            queue.removeLast();
            queue.print();
            Console.WriteLine("\nremoveFirst");
            queue.removeFirst();
            queue.print();
        }

        public void print()
        {
            foreach (Item item in this)
            {
                Console.Write(item+" ");
            }
        }

    }
}
