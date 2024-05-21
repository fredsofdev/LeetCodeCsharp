using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _274_H_Index
{
    //24 minuts, need to read the Wikipedia for understanding H-index colculation for
    //researchers productivity and this metrix is used for winning the Nobel Prize.
    public int HIndex(int[] citations)
    {
        Array.Sort(citations);
        Array.Reverse(citations);
        int p = 0;
        while(p < citations.Length)
        {
            if (citations[p] < p+1) break;
            p++;
        }
        return p;
    }
}
