using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Easy
internal class _283_Move_Zeroes
{
    //23 minutes
    public void MoveZeroes(int[] nums)
    {
        int l = 0, r = 0;
        while (r < nums.Length)
        {
            while (l < nums.Length && nums[l] != 0) l++;
            while (r < nums.Length && nums[r] == 0) r++;
            Console.WriteLine($"{l}  {r}");
            if (r == nums.Length || l == nums.Length) break;
            nums[l] = nums[r];
            nums[r] = 0;
        }
    }

    public static void Run()
    {
        _283_Move_Zeroes cal = new _283_Move_Zeroes();
        var input =  new int[] { 1,0 };
        cal.MoveZeroes(input);
        Console.WriteLine(input);
    }
}
