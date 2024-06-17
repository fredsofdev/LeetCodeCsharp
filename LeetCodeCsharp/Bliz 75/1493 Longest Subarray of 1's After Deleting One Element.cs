using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _1493_Longest_Subarray_of_1_s_After_Deleting_One_Element
{
    //10 minutes
    public int LongestSubarray(int[] nums)
    {
        int max = 0;
        int zeros = 1;
        int l = 0, r = 0;
        while(r < nums.Length)
        {
            if (nums[r] == 1) r++;
            else if(zeros == 1)
            {
                zeros = 0;
                r++;
            }
            else
            {
                if (nums[l] == 0) zeros = 1;
                l++;
            }
            max = Math.Max(max, r - l - 1);
        }
        return max;
    }
}
