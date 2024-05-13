using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week3.Assignment
{
    internal class SelectionInTwoSortedArrays
    {
        public static void Run()
        {
            int[] a = { 1, 3, 5 };
            int[] b = { 2, 4, 6, 8, 10 };
            int k = 5; // Find the 5th element
            Console.WriteLine($"The {k}th element is {FindKthElement(a, b, k - 1)}");
        }

        public static int FindKthElement(int[] a, int[] b, int k)
        {
            int n1 = a.Length, n2 = b.Length;
            if (n1 > n2) return FindKthElement(b, a, k); // Make sure a is the smaller array

            int low = 0, high = Math.Min(k, n1);

            while (low <= high)
            {
                int i = (low + high) / 2;
                int j = k - i;

                int Aleft = (i > 0) ? a[i - 1] : int.MinValue;
                int Aright = (i < n1) ? a[i] : int.MaxValue;
                int Bleft = (j > 0) ? b[j - 1] : int.MinValue;
                int Bright = (j < n2) ? b[j] : int.MaxValue;

                if (Aleft <= Bright && Bleft <= Aright)
                {
                    return Math.Max(Aleft, Bleft);
                }
                else if (Aleft > Bright)
                {
                    high = i - 1;
                }
                else
                {
                    low = i + 1;
                }
            }

            throw new InvalidOperationException("No valid element found.");
        }
    }
}
