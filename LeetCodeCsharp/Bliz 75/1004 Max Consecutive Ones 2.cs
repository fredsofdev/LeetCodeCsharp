using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _1004_Max_Consecutive_Ones_2
{
    //14 minutes
    public int LongestOnes(int[] nums, int k)
    {
        int kleft = k, max = 0;
        int l = 0, r = 0;
        while (r < nums.Length)
        {
            if (nums[r] == 1) r++;
            
            else if (kleft > 0)
            {
                r++;
                kleft--;
            }
            else
            {
                if (nums[l] == 0) kleft++;
                l++;
            }
            max = Math.Max(max, r-l); 
        }
        return max;
    }
}
