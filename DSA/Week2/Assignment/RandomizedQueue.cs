using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Assignment
{
    internal class RandomizedQueue<Item> : IEnumerable<Item>
    {
        private ListItem first;
        private ListItem last;

        private int count;  
        class ListItem
        {
            public Item item { get; set; }
            public ListItem next { get; set; }
        }

        public bool isEmpty()
            => first == null || last == null;

        // return the number of items on the randomized queue
        public int size() => count;

        // add the item
        public void enqueue(Item item)
        {
            ListItem oldItem = last;
            last = new ListItem();
            last.item = item;
            if (isEmpty()) first = last;
            else oldItem.next = last;
            count++;
        }

        // remove and return a random item
        public Item dequeue()
        {
            Item item = first.item;
            first = first.next;
            if(isEmpty()) last = null;
            count--;
            return item;
        }

        // return a random item (but do not remove it)
        public Item sample()
        {
            Random random = new Random();
            int target = random.Next(0, count);
            IEnumerator<Item> iter = this.GetEnumerator();
            for (int i = 0; i <= target; i++) iter.MoveNext();
            return iter.Current;
        }

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
            Console.WriteLine("RandomQueue: - for dequeue, = for random");
            RandomizedQueue<int> stack = new RandomizedQueue<int>();
            while (true)
            {
                string? inputString = Console.ReadLine();

                if (inputString == "-")
                {
                    if (stack.isEmpty()) continue;
                    Console.WriteLine($"=> {stack.dequeue()}");
                }
                else if (inputString == "=")
                {
                    if (stack.isEmpty()) continue;
                    Console.WriteLine($"=> {stack.sample()}");
                }
                else if (inputString == null) continue;
                else if (int.TryParse(inputString, out int input))
                    stack.enqueue(input);
                stack.print();
            }
        }

        public void print()
        {
            foreach (Item item in this)
            {
                Console.Write(item + " ");
            }
        }
    }
}
