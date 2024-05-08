using DSA.Week2.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week3.Quicksort
{
    internal class QuickSort
    {
        private static int partition(IComparable[] a, int lo, int hi)
        {
            int i = lo, j = hi+1;
            while (true)
            {
                while (a[++i].less(a[lo]))
                    if (i == hi) break;
                while (a[lo].less(a[--j]))
                    if (j == lo) break;

                if (i >= j) break;
                a.exch(i, j);   
            }

            a.exch(lo, j);
            return j;
        }

        public static void Sort(IComparable[] a)
        {
            Shuffle.shuffle(a);
            sort(a, 0, a.Length - 1);
        }

        private static void sort(IComparable[] a, int lo, int hi)
        {
            if(hi <= lo) return;
            int j = partition(a, lo, hi);
            sort(a, lo, j-1);
            sort(a, j+1, hi);
        }


        public static void Run()
        {
            Console.WriteLine("Quick Sort");
            string[] a = { "c", "k", "y", "f", "q", "s", "x", "r", "a", "n", "e", "m", "g", "z", "h", "o", "i", "b", "w", "d", "j", "v", "u", "t", "l", "p" };
            Console.Write("Before Sort: ");
            Console.Write(string.Join(" ", a));
            Console.WriteLine();
            Sort(a);
            Console.Write("After Sort: ");
            Console.Write(string.Join(" ", a));
        }
    }
}
