using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;

//Medium
internal class _122_BestTimeToButAndSellStock2
{
    //Failed to solve, Read the solution and understand, then implement it
    public int MaxProfit(int[] prices)
    {
        int max = 0;
        bool holding = false;
        for (int i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i] <= prices[i+1] && !holding)
            {
                max -= prices[i];
                holding = true;
            }
            if (prices[i] > prices[i+1] && holding) { 
                max += prices[i];
                holding = false;
            }
            else if(i + 1 == prices.Length - 1 && holding)
            {
                max += prices[i+1];
                holding = false;
            }
        }
        return max;
    }
}
