using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;

internal class _643_Maximum_Average_Subarray_1
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double max = double.MinValue;
        double sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (i - k >= 0) sum -= nums[i - k];
            if (i >= k - 1) max = Math.Max(max, sum / k);
        }
        return max;
    }
}
