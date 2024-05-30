using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _202_Happy_Number
{
    //19 minutes
    public bool IsHappy(int n)
    {
        string curr = n.ToString();
        HashSet<int> numbers = new HashSet<int>();
        while (true)
        {
            int[] nums = new int[curr.Length];
            for(int i=0; i<curr.Length; i++) nums[i] = int.Parse($"{curr[i]}");
            int sum = 0;
            foreach(int d in nums) sum += d*d;
            Console.WriteLine(sum);
            if(sum == 1) return true;   
            curr = sum.ToString();
            if(!numbers.Add(sum)) return false;
        }
    }
    public bool IsHappy2(int n)
    {
        HashSet<int> numbers = new HashSet<int>();
        int sum = 0;
        while (sum != 1)
        {
            sum = 0;
            while (n != 0)
            {
                sum += (n % 10) * (n % 10);
                n /= 10;
            }
            n = sum;
            if (!numbers.Add(sum)) break;
        }
        return sum == 1;
    }

}
