using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal static class ComparableExt
    {
        public static bool less(this IComparable v, IComparable w)
             => v.CompareTo(w) < 0;

        public static void exch(this IComparable[] a, int i, int j)
        {
            IComparable swap = a[i];
            a[i] = a[j];
            a[j] = swap;
        }

        public static bool isSorted(IComparable[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i].less(i - 1)) return false;
            }
            return true;
        }
    }
}
