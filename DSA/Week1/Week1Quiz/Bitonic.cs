using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week1.Week1Quiz
{
    internal class Bitonic
    {
        public bool FindN(int[] nums, int target)
        {
            int n = nums.Length;
            int peak = FindPeak(nums, 0, n - 1);

            return BinarySearchIncreasing(nums, 0, peak, target) != -1 || 
                BinarySearchDecreasing(nums, peak + 1,n-1,target) != -1;
        }

        private int FindPeak(int[] nums, int low, int high)
        {
            while(low <= high)
            {
                int mid = low + (high - low) / 2;

                if(nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1])
                {
                    return mid;
                }else if (nums[mid] > nums[mid - 1]) low = mid + 1;
                else high = mid - 1;
            }
            return -1;
        }

        private int BinarySearchIncreasing(int[] nums, int low, int high, int target)
        {
            while(low <= high)
            {
                int mid = high + (low - high) / 2;

                if (nums[mid] == target) return nums[mid];
                else if (nums[mid] < target) low = mid + 1;
                else high = mid - 1;
            }
            return -1;
        }

        private int BinarySearchDecreasing(int[] nums, int low, int high, int target)
        {
            while (low <= high)
            {
                int mid = high + (low - high) / 2;

                if (nums[mid] == target) return nums[mid];
                else if (nums[mid] < target) high = mid - 1;
                else low = mid + 1;
            }
            return -1;
        }
    }
}
