using DSA.Week2.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Assignment
{
    internal class Permutation
    {
        public bool IsPermutation(IComparable[] a, IComparable[] b)
        {
            Shellsort.sort(a);
            Shellsort.sort(b);

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }
    }
}
