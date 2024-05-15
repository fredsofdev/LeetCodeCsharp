﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week4
{
    internal class MaxPQ<Key> where Key : IComparable
    {
        private Key[] pq;
        private int N = 0;
        public MaxPQ(int capacity)
        { pq = new Key[capacity]; }

        public int Count => N;
        public bool IsEmpty() => N == 0;
        public void Insert(Key key)
        {
            pq[++N] = key;
            swim(N);
        }
        public Key DelMax()
        {
            Key max = pq[1];
            exch(1, N--);
            sink(1);
            pq[N + 1] = default;
            return max;
        }

        public Key PeakMax()=> pq[1];
        

        private void sink(int k)
        {
            while (2*k <= N)
            {
                int j = 2 * k;
                if(j < N && less(j, j+1))j++; //Find larger child
                if (!less(k, j)) break;
                exch(k, j);
                k = j;
            }
        }
        private void swim(int k)
        {
            while(k/2 > 0)
            {
                int j = k / 2;
                if(!less(j, k)) break;
                exch(j, k);
                k = j;
            }
        }

        private void exch(int i, int j)
        {
            Key hold = pq[i];
            pq[i] = pq[j];
            pq[j] = hold;
        }

        private bool less(int i, int j)
           => pq[i].CompareTo(pq[j]) < 0;

        public void Print()
        {
            int count = 1;
            while(count <= N)
                Console.Write(pq[count++] + ", ");
        }

        public static void Run()
        {
            Console.WriteLine("PQueue: - for peak, = for remove max");
            MaxPQ<int> queue = new MaxPQ<int>(15);
            while (true)
            {
                string? inputString = Console.ReadLine();

                if (inputString == "-")
                {
                    if (queue.IsEmpty()) continue;
                    Console.WriteLine($"=> {queue.PeakMax()}");
                }
                else if (inputString == "=")
                {
                    if (queue.IsEmpty()) continue;
                    Console.WriteLine($"=> {queue.DelMax()}");
                }
                else if (inputString == null) continue;
                else if (int.TryParse(inputString, out int input))
                    queue.Insert(input);
                queue.Print();
            }
        }
    }
}
