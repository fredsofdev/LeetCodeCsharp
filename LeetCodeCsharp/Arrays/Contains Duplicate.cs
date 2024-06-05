using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    internal class Contains_Duplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> cont = new();
            foreach(int num in nums)
            {
                if(!cont.Add(num)) return true;
            }
            return false;
        }

        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            List<int> cont = new();
            foreach(int num in nums)
            {
                if (cont.Count > k) cont.RemoveAt(0);

                if (cont.Contains(num)) return true;
                else cont.Add(num);
            }
            return false;
        }

        public bool ContainsNearbyDuplicate2(int[] nums, int k)
        {

            HashSet<int> cont = new();
            foreach (int num in nums)
            {
                if (cont.Count == k) cont.Remove(cont.First());
                if (cont.Contains(num)) return true;
                else cont.Add(num);
            }
            return false;
        }
    }
}
