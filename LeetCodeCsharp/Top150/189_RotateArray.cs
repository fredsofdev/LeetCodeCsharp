using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;

//Medium
internal class _189_RotateArray
{
    //Brute force solution failed at 13 minutes because of performance
    public void Rotate(int[] nums, int k)
    {
        for (int i = 0; i < k; i++) ShiftLeft(nums);
    }

    private void ShiftLeft(int[] nums)
    {
        int h = nums[nums.Length - 1];
        for (int i = nums.Length - 1; i > 0; i--)
        {
            nums[i] = nums[i-1];
        }
        nums[0] = h;
    }

    public void Rotate2(int[] nums, int k)
    {
        Array.Reverse(nums);
        Array.Reverse(nums,0,k);
        Array.Reverse(nums,k,nums.Length - k);
    }

    //44 minutes after failing brute force
    public void Rotate3(int[] nums, int k)
    {
        if (nums.Length == 1) return;
        if (nums.Length < k)
        {
            Rotate2(nums, k);
            return;
        }
        int[] fH = new int[nums.Length - k];
        for (int i = 0; i < fH.Length; i++) fH[i] = nums[i];

        for (int i = 0; i < k; i++) nums[i] = nums[i + fH.Length];

        for (int i = 0; i < fH.Length; i++)
        {
            nums[i + k] = fH[i];
        }
    }
}
