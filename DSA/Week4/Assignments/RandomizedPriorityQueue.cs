using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week4.Assignments
{
    internal class RandomizedPriorityQueue<Key> where Key : IComparable
    {
        private Key[] pq;
        private int N = 0;
        public RandomizedPriorityQueue(int capacity)
        { pq = new Key[capacity]; }

        public int Count => N;
        public bool IsEmpty() => N == 0;
        public void Insert(Key key)
        {
            pq[++N] = key;
            swim(N);
        }
        public Key DelRandom()
        {
            Key max = pq[1];
            exch(1, N--);
            sink(1);
            pq[N + 1] = default;
            return max;
        }

        public Key Sample() => pq[1];


        private void sink(int k)
        {
            while (2 * k <= N)
            {
                int j = 2 * k;
                if (j < N && more(j, j + 1)) j++; //Find smallest child
                if (!more(k, j)) break;
                exch(k, j);
                k = j;
            }
        }
        private void swim(int k)
        {
            while (k / 2 > 0)
            {
                int j = k / 2;
                if (!more(j, k)) break;
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

        private bool more(int i, int j)
        {
            Random r = new Random();
            return r.Next(0,1)==0;
        }

        public void Print()
        {
            int count = 1;
            while (count <= N)
                Console.Write(pq[count++] + ", ");
        }

        public static void Run()
        {
            Console.WriteLine("RandomQueue: - for sample, = for remove ren");
            RandomizedPriorityQueue<int> queue = new RandomizedPriorityQueue<int>(15);
            while (true)
            {
                string? inputString = Console.ReadLine();

                if (inputString == "-")
                {
                    if (queue.IsEmpty()) continue;
                    Console.WriteLine($"=> {queue.Sample()}");
                }
                else if (inputString == "=")
                {
                    if (queue.IsEmpty()) continue;
                    Console.WriteLine($"=> {queue.DelRandom()}");
                }
                else if (inputString == null) continue;
                else if (int.TryParse(inputString, out int input))
                    queue.Insert(input);
                queue.Print();
            }
        }
    }
}
