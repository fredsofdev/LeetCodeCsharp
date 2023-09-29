using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    internal class Find_Disappeared_Numbers
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> result = new List<int>();

            for (int i = 1; i <= nums.Length; i++)
            {
                if (!nums.Contains(i)) result.Add(i);
            }
            return result;
        }

        public IList<int> FindDisappearedNumbers2(int[] nums)
        {
            List<int> result = new();
            HashSet<int> hash = new HashSet<int>(nums);
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!hash.Contains(i)) result.Add(i);
            }
            return result.ToList();
        }
    }
}
