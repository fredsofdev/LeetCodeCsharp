using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    public class MyHashSet
    {
        private Dictionary<int, int> list = new();
        public MyHashSet()
        {

        }

        public void Add(int key)
        {
            if (!list.ContainsKey(key)) list.Add(key, 0);
        }

        public void Remove(int key)
        {
            if (list.ContainsKey(key)) list.Remove(key);
        }

        public bool Contains(int key)
        {
            return list.ContainsKey(key);
        }
    }
}
