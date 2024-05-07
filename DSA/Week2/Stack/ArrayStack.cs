using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Stack
{
    internal class ArrayStack : IStack<string>
    {
        private int N = 0;

        private string[] array;

        public ArrayStack(int capacity)
        {
            array = new string[capacity];
        }

        public bool isEmpty()=> N == 0;

        public string pop()
        {
            string value = array[N-1];
            array[--N] = null;
            return value;
        }

        public void push(string item)
        {
            array[N++] = item;
        }
    }
}
