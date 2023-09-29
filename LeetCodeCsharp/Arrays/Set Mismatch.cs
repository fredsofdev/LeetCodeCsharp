using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    internal class Set_Mismatch
    {
        public int[] FindErrorNums(int[] nums)
        {
            HashSet<int> holder = new(nums);
            HashSet<int> temp = new();
            int duplicated = 0;
            int absent = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!temp.Add(nums[i])) duplicated = nums[i];
                if (!holder.Contains(i + 1)) absent = i + 1;
            }
            return new int[] { duplicated, absent };
        }

        public int[] FindErrorNums2(int[] nums)
        {
            int expextedSum = nums.Length * (nums.Length + 1) / 2;
            HashSet<int> uniqueSet = new();
            int duplicated = 0;
            int totalSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!uniqueSet.Add(nums[i])) duplicated = nums[i];
                totalSum += nums[i];
            }
            return new int[] { duplicated, (expextedSum - totalSum)+duplicated};
        }
    }
}
