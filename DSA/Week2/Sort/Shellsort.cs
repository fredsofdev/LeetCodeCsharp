using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Sort
{
    internal class Shellsort
    {
        public static void sort(IComparable[] list)
        {
            int N = list.Length;
            int h = 0;
            while (h < N / 3) h = h * 3 + 1;

            while (h != 0)
            {
                for (int i = h; i < N; i++)
                {
                    for (int j = i; j >= h && list[j].less(list[j - h]); j -= h)
                        list.exch(j, j - h);
                }

                Console.Write($"h = {h}: ");
                foreach (IComparable i in list) Console.Write(i + " ");
                Console.WriteLine();
                h = h / 3;
            }
        }

        public static void SortTest()
        {
            Console.WriteLine("Shellsort Sort");
            string[] a = { "c", "k", "y", "f", "q", "s", "x", "r", "a", "n", "e", "m", "g", "z", "h", "o", "i", "b", "w", "d", "j", "v", "u", "t", "l", "p" };
            Console.Write("Before Sort: ");
            Console.Write(string.Join(" ", a));
            Console.WriteLine();
            sort(a);
            Console.Write("After Sort: ");
            Console.Write(string.Join(" ", a));
        }
    }
}
