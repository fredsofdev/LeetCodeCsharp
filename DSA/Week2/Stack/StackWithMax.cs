using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Stack
{
    internal class StackWithMax : IStack<int>
    {
        private ListItem first = null;

        class ListItem
        {
            public int value { get; set; }
            public ListItem next { get; set; }
        }

        public bool isEmpty() { return first == null; }

        public int pop()
        {
            ListItem item = first;
            first = first.next;
            return item.value;
        }

        public void push(int item)
        {
            ListItem oldItem = first;

            first = new ListItem();
            first.value = item;
            first.next = oldItem;
        }

        public int max() => compare(first);
        
        private int compare(ListItem item)
        {
            if (item == null) return 0;
            return Math.Max(item.value, compare(item.next));
        }
    }
}
