using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week4
{
    internal static class HeapSort
    {
        public static void sort(IComparable[] pq)
        {
            int N = pq.Length;
            for (int k = N / 2; k >= 0; k--) 
                sink(pq, k, N);

            while(N >= 0)
            {
                pq.exch(0, N++);
                sink(pq, 0, N);
            }
        }

        private static void sink(IComparable[] pq, int k, int N)
        {
            while(2*k <= N)
            {
                int j = 2 * k;
                if(j < N && pq.less(j, j + 1)) j++;
                if (!pq[k].less(j)) break;
                pq.exch(k, j);
                k = j;
            }
        }
         
        private static bool less(this IComparable[] a, int i, int j)
        {
            // Converted from 1-based to 0-based indexing
            return a[i-1].CompareTo(a[j-1]) < 0;
        }

        private static void exch(this IComparable[] a, int i, int j)
        {
            // Converted from 1-based to 0-based indexing
            IComparable hold = a[i-1];
            a[i-1] = a[j-1];
            a[j-1] = hold;    
        }
    }
}
