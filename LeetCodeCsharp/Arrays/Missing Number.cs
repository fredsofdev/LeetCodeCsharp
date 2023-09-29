using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    internal class Missing_Number
    {
        public int MissingNumber(int[] nums)
        {
            for (int i = 0; i <= nums.Length; i++)
            {
                if (!nums.Contains(i)) return i;
            }
            return 0;
        }

        public int MissingNumber2(int[] nums)
        {
            int totalSum = 0;
            int sum = 0;
            for(int i= 0; i <= nums.Length; i++)
            {
                if(i < nums.Length) sum += nums[i];
                totalSum += i;
            }

            return totalSum - sum;
        }

        public int MissingNumber3(int[] nums)
        {
            int totalSum = (nums.Length*(nums.Length+1))/2;
            int sum = SumArray(nums, 0);
            return totalSum - sum;
        }

        public static int SumArray(int[] numbers, int index)
        {
            if (index >= numbers.Length)
                return 0;
            return numbers[index] + SumArray(numbers, index + 1);
        }
    }
}
