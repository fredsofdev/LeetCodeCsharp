using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _1_Two_Sum
{
    //5 minutes
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = new();
        for(int i = 0; i < nums.Length; i++) 
        {
            if(dic.ContainsKey(target - nums[i])) return new int[] { dic[target - nums[i]], i };
            else dic[nums[i]] = i;
        }
        return new int[0];
    }
}
