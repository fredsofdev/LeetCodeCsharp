using DSA.Week2.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week3.Assignment
{
    internal class MergingWithHalfAux
    {
        private static void merge(IComparable[] a, int lo, int mid, int hi)
        {
            var aux = new IComparable[mid-lo+1];
            for(int l = 0; l < aux.Length; l++)
            {
                aux[l] = a[lo+l];
            }

            int i = 0, j = mid + 1;


            for (int k = lo; k <= hi; k++)
            {
                if (i >= aux.Length) a[k] = a[j++];
                else if (j > hi) a[k] = aux[i++];
                else if (aux[i].less(a[j])) a[k] = aux[i++];
                else a[k] = a[j++];
            }
        }

        private static void sort(IComparable[] a, int lo, int hi)
        {
            if (lo >= hi) return;
            int mid = lo + (hi - lo) / 2;
            sort(a, lo, mid);
            sort(a,  mid + 1, hi);
            merge(a,  lo, mid, hi);
        }

        public static void Sort(IComparable[] a)
        {
            sort(a, 0, a.Length - 1);
        }


        public static void Run()
        {
            Console.WriteLine("MeragSort With HalfAux");
            string[] a = new string[] { "e", "e", "e", "f", "g", "h", "a", "a", "a", "b", "c", "d" };
            Console.Write("Before Sort: ");
            foreach (string i in a) Console.Write(i + " ");
            Console.WriteLine();
            Sort(a);
            Console.Write("After Sort: ");
            foreach (string i in a) Console.Write(i + " ");
        }
    }
}
