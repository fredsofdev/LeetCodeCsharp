using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Assignment;

internal class DutchNationalFlag
{
    public void SortPebbles(Bucket[] buckets)
    {
        int low = 0, mid = 0, high = buckets.Length-1;

        while(mid != high)
        {
            Bucket current = Color(buckets, mid);

            if (current == Bucket.RED)
            {
                Swap(buckets, low, mid);
                low++;
                mid++;
            }
            else if (current == Bucket.BLUE)
            {
                Swap(buckets, mid, high);
                high--;
                mid++;
            }
            else mid++;
        }
    }

    private Bucket Color(Bucket[] buckets, int i)
    {
        return buckets[i];
    }

    private void Swap(Bucket[] buckets, int i, int j)
    {
        Bucket old = buckets[i];
        buckets[i] = buckets[j];
        buckets[j] = old;
    }
}

enum Bucket { RED, WHITE, BLUE }