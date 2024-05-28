using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _56_Merge_Intervals
{
    //34 minutes
    public int[][] Merge(int[][] intervals)
    {
        if(intervals.Length == 1) return intervals;
        Array.Sort(intervals,(a,b)=> a[0].CompareTo(b[0]));
        var result = new List<int[]>();
        int l = intervals[0][0], r = intervals[0][1];
        for(int i = 1; i < intervals.Length; i++)
        {
            if (r >= intervals[i][1]) continue;
            if (r < intervals[i][0])
            {
                result.Add(new int[] { l, r });
                l = intervals[i][0];
            }
            r = intervals[i][1];
        }
        result.Add(new int[] { l, r });
        return result.ToArray();
    }
}
