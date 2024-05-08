using DSA.Week2.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week3.Quicksort
{
    internal class QuickSelect
    {
        private static int partition(IComparable[] a, int lo, int hi)
        {
            int i = lo, j = hi + 1;
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

        public static IComparable Selection(IComparable[] a, int k)
        {
            Shuffle.shuffle(a);

            int lo=0, hi=a.Length - 1;
            while(hi > lo)
            {
                int j = partition(a, lo, hi);
                if (j < k) lo = j + 1;
                else if (j > k) hi = j - 1;
                else return a[k];
            }
            
            return a[k];
        }

        public static void Run()
        {
            Console.WriteLine("Quick Select");
            string[] a = { "c", "k", "y", "f", "q", "s", "x", "r", "a", "n", "e", "m", "g", "z", "h", "o", "i", "b", "w", "d", "j", "v", "u", "t", "l", "p" };
            Console.Write("List: ");
            Console.Write(string.Join(" ", a));
            Console.WriteLine();
            string found = Selection(a, a.Length - 2) as string;
            Console.WriteLine($"Kth Largest: {found}");
            Console.Write(string.Join(" ", a));
        }
    }
}
