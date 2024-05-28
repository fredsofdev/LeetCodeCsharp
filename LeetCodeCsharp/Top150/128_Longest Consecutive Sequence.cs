using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium

internal class _128_Longest_Consecutive_Sequence
{
    Dictionary<int, int> groups = new();
    Dictionary<int, int> size = new();
    //80 minutes 
    public int LongestConsecutive(int[] nums)
    {
        int max = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (groups.ContainsKey(nums[i])) continue;
            int prev = FindRoot(nums[i] - 1);
            int next = FindRoot(nums[i] + 1);
            if (prev != int.MinValue && next != int.MinValue)
            {
                if (size[prev] < size[next])
                {
                    groups[prev] = next;
                    size[next] += size[prev] + 1;
                    groups.Add(nums[i], next);
                    max = Math.Max(max, size[next]);
                }
                else
                {
                    groups[next] = prev;
                    size[prev] += size[next] + 1;
                    groups.Add(nums[i], prev);
                    max = Math.Max(max, size[prev]);
                }
            }
            else if (prev != int.MinValue)
            {
                size[prev] += 1;
                groups.Add(nums[i], prev);
                max = Math.Max(max, size[prev]);
            }
            else if (next != int.MinValue)
            {
                size[next] += 1;
                groups.Add(nums[i], next);
                max = Math.Max(max, size[next]);
            }
            else
            {
                size.Add(nums[i], 1);
                groups.Add(nums[i], int.MinValue);
                
            }
        }
        return max;
    }

    private int FindRoot(int key)
    {
        if (!groups.TryGetValue(key, out int value)) return int.MinValue;
        if (value == int.MinValue) return key;
        while (groups[value] != int.MinValue) value = groups[value];
        return value;
    }

    public int LongestConsecutive2(int[] nums)
    {
        HashSet<int> group = nums.ToHashSet();
        int max = 0;
        foreach(int n in nums)
        {
            if (!group.Contains(n - 1))
            {
                int count = 0;
                bool found = true;
                int current = n;
                while (found)
                {
                    count++;
                    found = group.Contains(++current);
                }
                max = Math.Max(max, count);
            }
        }
        return max;
    }
}
