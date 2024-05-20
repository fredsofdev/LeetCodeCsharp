using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;

//Easy
internal class _121_BestTimeToBuyAndSellStock
{
    //Brute Fource failed 
    public int MaxProfit(int[] prices)
    {
        int max = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                int profit = prices[j] - prices[i];
                if (profit > max) max = profit;
            }
        }
        return max;
    }
    //16 minuts after brute force 
    public int MaxProfit2(int[] prices)
    {
        int max = 0;
        int p = prices[0];
        for(int i = 1;i < prices.Length; i++)
        {
            if (prices[i] < p) p = prices[i];
            
            max = Math.Max(max, prices[i] - p);
        }

        return max;
    }

}
