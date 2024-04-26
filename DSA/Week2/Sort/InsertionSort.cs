using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Sort
{
    internal class InsertionSort
    {
        public static void sort(IComparable[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                for(int j = i; j > 0; j--)
                {
                    if (list[j].less(list[j-1])) list.exch(j, j - 1);
                    else break;
                }
            }
        }

        public static void SortTest()
        {
            Console.WriteLine("Insertion Sort");
            string[] a = new string[] { "e", "e", "e", "f", "g", "h", "a", "a", "a", "b", "c", "d" };
            Console.Write("Before Sort: ");
            foreach (string i in a) Console.Write(i + " ");
            Console.WriteLine();
            sort(a);
            Console.Write("After Sort: ");
            foreach (string i in a) Console.Write(i + " ");
        }
    }
}
