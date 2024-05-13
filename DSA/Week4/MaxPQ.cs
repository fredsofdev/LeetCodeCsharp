using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week4
{
    internal class MaxPQ<Key> where Key : IComparable
    {
        private Key[] pq;
        private int N;
        public MaxPQ(int capacity)
        { pq = new Key[capacity]; }

        public bool IsEmpty() => N == 0;
        public void Insert(Key key)
        {
            pq[N++] = key;
            swim(N);
        }
        public Key delMax()
        {
            Key max = pq[N];
            exch(1, N--);
            sink(1);
            pq[N + 1] = default;
            return max;
        }

        private void sink(int k)
        {
            while (2*k <= N)
            {
                int j = 2 * k;
                if(j < N && less(j, j+1))j++;
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
    }
}
