using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//medium
internal class _15_3Sum
{
    // 50 minutes to Time limit exceeded
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        List<string> triples = new List<string>();
        Dictionary<string, int> pair = new();

        for(int i = 0; i < nums.Length-1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int k = Array.IndexOf(nums, -(nums[i] + nums[j]));
                if (k == -1) continue;
                string key = $"{nums[i]},{nums[j]},{nums[k]}";
                if (k != i && k != j && !triples.Contains(key)) triples.Add(key);
            }
        }

        return triples.Select(x => x.Split(",").Select(i=> int.Parse(i)).ToArray()).ToArray();
    }

    public IList<IList<int>> ThreeSum2(int[] nums)
    {
        Array.Sort(nums);
        Dictionary<string, int[]> pair = new();
        bool turn = true;
        int l= 0, r= nums.Length-1;
        while(l < r)
        {
            int target = -(nums[l] + nums[r]);
            for(int i = l+1; i< r; i++)
            {
                if (nums[i] != target) continue;
                int[] keys = new int[] { nums[l], nums[r], nums[i] };
                Array.Sort(keys);
                string key = string.Join(",", keys);
                pair.Add(key, keys);
            }
            
            if (turn) r--;
            else l++;
            turn = !turn;
        }

        return pair.Values.ToArray();
    }

    public IList<IList<int>> ThreeSum3(int[] nums)
    {
        Array.Sort(nums);
        Dictionary<string, int[]> pair = new();
        bool turn = true;
        int l = 0, r = nums.Length - 1;
        while (l < r)
        {
            int s = 0, e = 0;
            if (turn)
            {

            }

            int target = -(nums[l] + nums[r]);
            for (int i = s; i < e; i++)
            {
                if (nums[i] != target) continue;
                int[] keys = new int[] { nums[l], nums[r], nums[i] };
                Array.Sort(keys);
                string key = string.Join(",", keys);
                if (!pair.TryAdd(key, keys)) Console.WriteLine(key); 
            }

            if (turn) r--;
            else l++;
            turn = !turn;
        }

        return pair.Values.ToArray();
    }
}
