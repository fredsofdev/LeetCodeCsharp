using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _57_Insert_Interval
{
    //21 minutes
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var result = new List<int[]>();
        int l = newInterval[0], r = newInterval[1];
        for (int i = 0; i < intervals.Length; i++)
        {
            if (l > intervals[i][1])
            {
                result.Add(intervals[i]);
                continue;
            }
            else if (l > intervals[i][0]) l = intervals[i][0];

            if (r > intervals[i][1]) continue;
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
