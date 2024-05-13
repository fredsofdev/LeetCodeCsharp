using DSA.Week2.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week3.Quicksort
{
    internal class DuplicateQsort
    {
        private static void sort(IComparable[] a, int lo, int hi)
        {
            if (hi <= lo) return;
            int lt = lo, gt = hi;
            IComparable v = a[lo];
            int i = lo;
            while (i <= gt)
            {
                int cmp = a[i].CompareTo(v);
                if (cmp < 0) a.exch(lt++, i++);
                else if (cmp > 0) a.exch(i, gt--);
                else i++;
            }

            sort(a, lo, lt - 1);
            sort(a, gt + 1, hi);
        }

        public static void Sort(IComparable[] a)
        {
            sort(a, 0, a.Length - 1);
        }
    }
}
