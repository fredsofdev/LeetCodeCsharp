using DSA.Week2.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week3.Mergesort
{
    internal class MergeImproved
    {
        private static int CUTOFF = 2;
        private static void merge(IComparable[] a, IComparable[] aux, int lo, int mid, int hi)
        {
            for (int k = lo; k <= hi; k++)
            {
                aux[k] = a[k];
            }

            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++)
            {
                if (i > mid) a[k] = aux[j++];
                else if (j > hi) a[k] = aux[i++];
                else if (aux[j].less(a[i])) a[k] = aux[j++];
                else a[k] = aux[i++];
            }
        }

        private static void sort(IComparable[] a, IComparable[] aux, int lo, int hi)
        {
            //Merge sort is too expencieve for small arrays
            if (hi <= lo + CUTOFF - 1) 
            {
                InsertionSort.sort(a, lo, hi);
                return;
            }
            int mid = lo + (hi - lo) / 2;
            sort(a, aux, lo, mid);
            sort(a, aux, mid + 1, hi);
            //If last of first part and first of last part are sorted then whole part is sorted
            if (a[mid].less(a[mid + 1])) return; 
            
            merge(a, aux, lo, mid, hi);
        }

        public static void Sort(IComparable[] a)
        {
            IComparable[] aux = new IComparable[a.Length];
            sort(a, aux, 0, a.Length - 1);
        }
    }
}
