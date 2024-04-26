using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Stack
{
    internal interface IStack<T>
    {
        void push(T item);
        T pop();
        bool isEmpty();
    }
}
