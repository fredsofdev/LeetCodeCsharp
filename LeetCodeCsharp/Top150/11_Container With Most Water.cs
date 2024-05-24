using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _11_Container_With_Most_Water
{
    //12 minutes 
    public int MaxArea(int[] height)
    {
        int max = 0;
        int l = 0, r = height.Length-1;
        while ( l < r)
        {
            int curWater = (r - l) * Math.Min(height[r], height[l]);
            if (curWater > max) max = curWater;
            if (height[r] < height[l]) r--;
            else l++;
        }
        return max;
    }
}
