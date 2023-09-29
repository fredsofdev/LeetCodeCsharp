using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Dictionary
{
    internal class Majority_Element
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> rank = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if(rank.ContainsKey(nums[i]))
                    rank[nums[i]] += 1;
                else rank[nums[i]] = 1;
            }
            return rank.OrderBy(n => n.Value).Last().Key;
        }

        public int MajorityElement2(int[] nums)
        {
            int count = 0;
            int? current = null;

            foreach(int num in nums)
            {
                if(count == 0) current = num;
                count += (current == num) ? 1 : -1;
            }
            return current.Value;
        }
    }
}
