using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    internal class Degree_Of_An_Array
    {
        public int FindShortestSubArray(int[] nums)
        {
            Dictionary<int, int> highestDegree = new();

            foreach(int num in nums)
            {
                highestDegree[num] = highestDegree.GetValueOrDefault(num,0)+1;
            }

            int highestValue = highestDegree.Values.Max();

            var selectedHighest = highestDegree
                .Where(x => x.Value == highestValue)
                .Select(x => x.Key).ToList();

            int shortest = nums.Length;
            foreach(int highest in selectedHighest)
            {
                int first = 0;
                int last = nums.Length - 1;
                while (first <= last)
                {
                    if(nums[first] != highest) first++;
                    if(nums[last] != highest) last--;

                    if (nums[first] == highest
                        && nums[last] == highest) break;
                }
                shortest = Math.Min(shortest, last-first+1);
            }
            return shortest;
        }

        public int FindShortestSubArray2(int[] nums)
        {
            Dictionary<int, int> frequency = new();
            Dictionary<int, int> left = new();
            Dictionary<int, int> right = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!left.ContainsKey(nums[i])) left[nums[i]] = i;
                right[nums[i]] = i;

                if (frequency.ContainsKey(nums[i])) frequency[nums[i]]++;
                else frequency[nums[i]] = 1;
            }

            int highest = 0;
            foreach (var freq in frequency) highest = Math.Max(highest, freq.Value);

            int shortest = nums.Length;
            foreach (int num in nums)
            {
                if (frequency[num] == highest)
                {
                    shortest = Math.Min(shortest, right[num] - left[num] + 1);
                }
            }
            return shortest;
        }

        public int FindShortestSubArray3(int[] nums)
        {
            Dictionary<int, int> frequency = new();
            Dictionary<int, int> left = new();
            Dictionary<int, int> right = new();

            for(int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if(!left.ContainsKey(num)) left[num] = i;
                right[num] = i;

                if (frequency.ContainsKey(num)) frequency[num]++;
                else frequency[num] = 1;
            }

            int highest = 0;
            foreach(var freq in frequency) highest = Math.Max(highest, freq.Value);

            int shortest = nums.Length;
            foreach(var num in frequency)
            {
                if (frequency[num.Key] == highest)
                {
                    shortest = Math.Min(shortest, right[num.Key] - left[num.Key] +1);
                }
            }
            return shortest;
        }
    }
}
