using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//hard
internal class _42_TrappingRainWater
{
    //6 minute to implement, seen solution
    public int Trap(int[] height)
    {
        int water = 0;
        int l = 0;
        int r = height.Length - 1;
        int lmax = height[l];
        int rmax = height[r];
        while (l < r)
        {
            lmax = Math.Max(lmax, height[l]);
            rmax = Math.Max(rmax, height[r]);
            water += lmax - height[l];
            water += rmax - height[r];
            if (lmax <= rmax) l++;
            else r--;
            
        }
        return water;
    }
}
