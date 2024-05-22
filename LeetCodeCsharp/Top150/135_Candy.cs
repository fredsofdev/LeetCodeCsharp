using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Hard
internal class _135_Candy
{
    //40 minuts after getting some hint
    public int Candy(int[] ratings)
    {
        int[] candies = new int[ratings.Length];
        int lastCandy = 1;
        for (int i = 0; i < ratings.Length - 1; i++)
        {
            candies[i] = lastCandy;
            if (ratings[i] < ratings[i + 1]) lastCandy++;
            else lastCandy = 1;
        }
        candies[ratings.Length - 1] = lastCandy;
        Console.WriteLine(string.Join(", ", candies));
        lastCandy = 1;
        for (int i = ratings.Length - 1; i > 0; i--)
        {
            candies[i] = Math.Max(candies[i], lastCandy);
            if (ratings[i - 1] > ratings[i]) lastCandy++;
            else lastCandy = 1;
        }
        candies[0] = Math.Max(candies[0], lastCandy);
        Console.WriteLine(string.Join(", ", candies));
        return candies.Sum();
    }

    public int Candy(int[] ratings)
    {
        int candies = 0;
        int lastCandy = 1;
        int dslop = 0;

        for(int i = 0; i < ratings.Length-1; i++)
        {
            int cmp = ratings[i].CompareTo(ratings[i+1]);
            if (cmp > 0) { dslop++; continue; }
            if (dslop > 0)
            {
                int tmpCandy = 1;
                while (dslop > 0)
                {
                    candies += ++tmpCandy;
                    if (dslop == 1) candies += Math.Max(lastCandy, ++tmpCandy);
                    else candies += ++tmpCandy;
                    dslop--;
                }
                lastCandy = 1;
            }
            candies += lastCandy;
            if (cmp < 0) lastCandy++;
        }
        return candies;
    }
}
