using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Stack
{
    internal class LinkedListStack : IStack<string>
    {
        private ListItem first = null;

        class ListItem
        {
            public string value { get; set; }
            public ListItem next { get; set; }
        }

        public bool isEmpty() { return first == null; }

        public string pop()
        {
            ListItem item = first;
            first = first.next;
            return item.value;
        }

        public void push(string item)
        {
            ListItem oldItem = first;

            first = new ListItem();
            first.value = item;
            first.next = oldItem;
        }
    }
}
