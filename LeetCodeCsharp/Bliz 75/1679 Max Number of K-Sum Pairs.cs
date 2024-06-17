using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _1679_Max_Number_of_K_Sum_Pairs
{
    //5 minutes
    public int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);
        int count = 0;
        int l = 0, r = nums.Length - 1;
        while (l < r)
        {
            int sum = nums[l] + nums[r];
            if (sum > k) r--;
            else if(sum < k) l++;
            else
            {
                Console.WriteLine($"{l} {r}");
                count++;
                l++;
                r--;
            }
        }
        return count;
    }
}
