using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Stack
{
    internal class ResizableArrayStack : IStack<string>
    {
        private int N = 0;
        private string[] array = new string[1];


        public bool isEmpty() => N == 0;

        public string pop()
        {
            string value = array[N - 1];
            array[--N] = null;
            if (N <= (array.Length / 4)) resize(array.Length / 2);
            return value;
        }

        public void push(string item)
        {
            array[N++] = item;
            if(N == array.Length) resize(array.Length * 2);
        }

        private void resize(int newSize)
        {
            Console.WriteLine($"Resized {array.Length} to {newSize}");
            string[] newArray = new string[newSize];

            for(int i = 0; i < N; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;   
        }
    }
}
