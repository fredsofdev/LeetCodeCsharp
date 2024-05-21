using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _55_JumpGame
{
    //29 minutes 
    public bool CanJump(int[] nums)
    {
        if (nums.Length == 1) return true;
        int tc = nums[0];
        if (tc == 0) return false;
        for (int i = 1; i < nums.Length; i++)
        {
            tc = Math.Max(tc - 1, nums[i]);
            if (tc == 0 && i != nums.Length - 1) return false;
        }
        return true;
    }
}
