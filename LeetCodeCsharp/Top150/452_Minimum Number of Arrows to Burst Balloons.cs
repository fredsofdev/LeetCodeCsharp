using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _452_Minimum_Number_of_Arrows_to_Burst_Balloons
{
    //40 minute
    public int FindMinArrowShots(int[][] points)
    {
        var result = new List<int[]>();
        Array.Sort(points, (a, b)=> a[0].CompareTo(b[0]));
        int l = points[0][0], r = points[0][1];
        for (int i = 1; i < points.Length; i++)
        {
            if (r < points[i][0])
            {
                result.Add(new int[] { l, r });
                l = points[i][0];
                r = points[i][1];
                continue;
            }
            else l = points[i][0];

            r = Math.Min(r, points[i][1]);
        }
        result.Add(new int[] { l, r });
        return result.Count;
    }
}
