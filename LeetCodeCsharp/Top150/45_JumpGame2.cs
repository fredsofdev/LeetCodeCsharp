using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;

//Medium
internal class _45_JumpGame2
{
    //Failed to solve
    public int Jump(int[] nums)
    {
        if(nums.Length == 1) return 0;
        int min = 0;
        int tc = nums[0];
        int p = 1;
        while(p < nums.Length)
        {
            int cmp = nums[p].CompareTo(--tc);
            int jump = p + tc;
            if (jump < nums.Length && cmp > 0 && nums[p] < nums[jump])
            {
                p += tc;
                tc = nums[jump];
            }
            else if (p == nums.Length - 1) min++;
            else if (cmp > 0) min++;
            tc = Math.Max(tc, nums[p]);
            p++;
        }
        return min;
    }

    // Got the solution from chatgpt and understand the new approach called Gready Algorithm.
    // Since it's guaranteed that it reaches nums[n - 1], greadyly we can jump to maximum reachable
    // position from i point and update the currentEnd to new furthest point if i point is equel to
    // currentEnd.
    public int Jump2(int[] nums)
    {
        int jumps = 0;
        int currentEnd = 0;
        int furthest = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            furthest = Math.Max(furthest, i + nums[i]);

            if (i == currentEnd)
            {
                jumps++;
                currentEnd = furthest;
            }
        }

        return jumps;
    }
}
