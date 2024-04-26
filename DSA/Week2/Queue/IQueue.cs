using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Queue
{
    internal interface IQueue<T>
    {
        void enqueue(T item);
        T dequeue();
        bool isEmpty();
    }
}
