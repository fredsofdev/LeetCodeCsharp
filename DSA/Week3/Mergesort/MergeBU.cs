using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week3.Mergesort
{
    internal class MergeBU
    {

        public static void Sort(IComparable[] a)
        {
            int N = a.Length;
            var aux = new IComparable[N];
            for (int sz = 1; sz < N; sz = sz + sz)
                for (int lo = 0; lo < N - sz; lo += sz + sz)
                    Merge.merge(a, aux, lo, lo + sz - 1, Math.Min(lo + sz + sz - 1, N - 1));
        }
    }
}
