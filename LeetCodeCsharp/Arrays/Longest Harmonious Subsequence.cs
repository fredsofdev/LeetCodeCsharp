using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    internal class Longest_Harmonious_Subsequence
    {
        public int FindLHS(int[] nums)
        {
            Dictionary<int, int> reps = new();

            for(int i = 0; i < nums.Length; i++)
            {
                reps[nums[i]] = reps.GetValueOrDefault(nums[i],0) + 1;
            }
            int max = 0;
            foreach(int num in reps.Keys)
            {
                if (reps.ContainsKey(num + 1))
                {
                    max = Math.Max(max, reps[num] + reps[num+1]);
                }
            }
            return max;
        }

        public int FindLHS2(int[] nums)
        {
            Dictionary<int, int> reps = new();

            int max = 0;
            foreach (int num in nums)
            {
                reps[num] = reps.GetValueOrDefault(num, 0) + 1;

                if (reps.ContainsKey(num - 1))
                {
                    max = Math.Max(max, reps[num] + reps[num - 1]);
                }
            }
            return max;
        }
    }
}
