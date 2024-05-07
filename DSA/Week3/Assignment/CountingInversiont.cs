using DSA.Week2.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week3.Assignment
{
    internal class CountingInversiont
    {

        public static void merge(IComparable[] a, ref int count,  int lo, int mid, int hi)
        {
            var aux = new IComparable[mid - lo + 1];
            for (int k = 0; k < aux.Length; k++)
            {
                aux[k] = a[lo + k];
            }

            int i = 0, j = mid+1;
            for (int k = lo; k <= hi; k++)
            {
                if (i >= aux.Length) a[k] = a[j++];
                else if (j > hi) a[k] = aux[i++];
                else if (a[j].less(aux[i]))
                {
                    count++;
                    a[k] = a[j++];
                }
                else a[k] = aux[i++];
            }
        }

        private static void sort(IComparable[] a, ref int count, int lo, int hi)
        {
            if (lo >= hi) return;
            int mid = lo + (hi - lo) / 2;
            sort(a,ref count, lo, mid);
            sort(a, ref count, mid + 1, hi);
            merge(a, ref count, lo, mid, hi);
        }

        public static int CountInversion(IComparable[] a)
        {
            int count = 0;
            sort(a, ref count, 0, a.Length - 1);
            return count;
        }

        public static void Run()
        {
            Console.WriteLine("Counting Inversions");
            string[] a = new string[] { "e", "e", "e", "f", "g", "h", "a", "a", "a", "b", "c", "d" };
            Console.Write("Before Sort: ");
            foreach (string i in a) Console.Write(i + " ");
            Console.WriteLine();
            int count = CountInversion(a);
            Console.WriteLine($"Inversion count: {count}");
            Console.Write("After Sort: ");
            foreach (string i in a) Console.Write(i + " ");
            Console.WriteLine();
        }

    }
}
