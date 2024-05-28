using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _209_Minimum_Size_Subarray_Sum
{
    //40 minutes
    public int MinSubArrayLen(int target, int[] nums)
    {
        int min = int.MaxValue;
        int sum = 0;
        int l = 0, r = 0;
        while (l < nums.Length)
        {
            if (sum >= target)
            {
                min = Math.Min(min, r - l);
                sum -= nums[l++];
                Console.WriteLine(min);
            }
            else if (r < nums.Length)
            {
                sum += nums[r++];
            }
            else l++;
        }
        return min == int.MaxValue ? 0: min;
    }
}
