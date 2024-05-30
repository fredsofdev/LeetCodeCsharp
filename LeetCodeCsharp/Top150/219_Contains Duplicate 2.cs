using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _219_Contains_Duplicate_2
{
    //31 minutes
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, List<int>> dic = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dic.ContainsKey(nums[i]))
            {
                dic[nums[i]] = new List<int>() { i };
            }
            else dic[nums[i]].Add(i);
        }

        foreach(var points in dic.Values)
        {
            if (points.Count < 2) continue;
            for (int i = 1; i < points.Count; i++)
            {
                int sum = Math.Abs(points[i-1] - points[i]);
                if (sum <= k) return true;
            }
        }
        return false;
    }

    public bool ContainsNearbyDuplicate2(int[] nums, int k)
    {
        Dictionary<int, int> dic = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.TryGetValue(nums[i], out int j) 
                && Math.Abs(j - i) <= k) return true;
            dic[nums[i]] = i;
        }
        return false;
    }
}
