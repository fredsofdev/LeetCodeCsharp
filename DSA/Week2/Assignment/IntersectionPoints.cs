using DSA.Week2.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Assignment
{
    internal class IntersectionPoints
    {
        public int GetIntersectionCount(Point[] a, Point[] b)
        {
            Shellsort.sort(a);
            Shellsort.sort(b);

            /*IEnumerable<Point> intersection = a.Intersect(b);
            return intersection.Count();*/
            int count = 0;
            int i = 0, j = 0;
            while(i < a.Length || j < b.Length)
            {
                if (a[i].less(b[j])) i++;
                else if (b[j].less(a[i])) j++;
                else
                {
                    i++;
                    j++;
                    count++;
                }
            }

            return count;
        }
    }
}
