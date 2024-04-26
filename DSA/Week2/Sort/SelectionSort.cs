using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Sort
{
    internal class SelectionSort
    {
        public static void sort(IComparable[] list)
        {
            for(int i = 0; i < list.Length; i++)
            {
                int min = i;
                for(int j = i + 1; j < list.Length; j++)
                {
                    if (list[j].less(list[min])) min = j;
                }
                if(min != i) list.exch(i, min);
            }
        }

        public static void SortTest()
        {
            Console.WriteLine("Selection Sort");
            string[] a = new string[] { "e", "f", "g", "h", "a", "b", "c", "d" };
            Console.Write("Before Sort: ");
            foreach (string i in a) Console.Write(i+" ");
            Console.WriteLine();
            sort(a);
            Console.Write("After Sort: ");
            foreach (string i in a) Console.Write(i+" ");
        }
    }
}
