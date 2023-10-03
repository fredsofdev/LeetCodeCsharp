using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    public class MyHashMap
    {
        class Node
        {
            public int Key;
            public int Value;

            public Node(int key, int value) { this.Key = key; this.Value = value; }
        }

        private Node[] buckets;
        private int size;
        public MyHashMap()
        {
            size = 1000_001;
            buckets = new Node[size];
        }

        public void Put(int key, int value)
        {
            int hashKey = GetHash(key);
            if(buckets[hashKey] == null)
            {
                buckets[hashKey] = new Node(key, value);
                return;
            }
            Node current = buckets[hashKey];
            if (current.Key != key) return;
            current.Value = value;
        }

        public int Get(int key)
        {
            int hashKey = GetHash(key);
            Node current = buckets[hashKey];
            if(current == null) return -1;
            return current.Value;
        }

        public void Remove(int key)
        {
            int hashKey = GetHash(key);
            buckets[hashKey] = null;
        }

        private int GetHash(int key) => key % size;
    }

    public class MyHashMap2
    {
        class Node
        {
            public int Key;
            public int Value;
            public Node? Next;

            public Node(int key, int value)
            {
                Key = key;
                Value = value;
                Next = null;
            }
        }

        private Node[] buckets;
        private int size;

        public MyHashMap2()
        {
            size = 1000;
            buckets = new Node[size];
        }

        public void Put(int key, int value)
        {
            int hashKey = GetHash(key);

            if(buckets[hashKey] == null)
            {
                buckets[hashKey] = new Node(key, value);
            }
            else
            {
                Node current = buckets[hashKey];
                while (true)
                {
                    if (current.Key == key)
                    {
                        current.Value = value;
                        return;
                    }
                    if (current.Next == null) break;
                    current = current.Next;
                }
                current.Next = new Node(key, value);
            }
        }

        public int Get(int key)
        {
            int hashKey = GetHash(key);

            Node? current = buckets[hashKey];

            while (true)
            {
                if (current == null) return -1;
                if(current.Key != key)
                {
                    current = current.Next;
                    
                }
                else return current.Value;
            }

        }

        public void Remove(int key)
        {
            int hashKey = GetHash(key);
            Node? current = buckets[hashKey];
            Node? prev = null;

            while (current != null)
            {
                if(current.Key == key)
                {
                    if(prev == null)
                    {
                        buckets[hashKey] = current.Next;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }
                    return;
                }
                prev = current;
                current = current.Next;
            }
        }

        private int GetHash(int key) => key % size;
    }


}
