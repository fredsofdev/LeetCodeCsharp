using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    internal class Distribute_Candies
    {
        public int DistributeCandies(int[] candyType)
        {
            int targetAmount = candyType.Length / 2;
            HashSet<int> types = new HashSet<int>(candyType);
            return targetAmount >= types.Count ?  types.Count : targetAmount;
        }

        public int DistributeCandies2(int[] candyType)
        {
            return Math.Min(candyType.Distinct().Count(), candyType.Length / 2);
        }
    }
}
