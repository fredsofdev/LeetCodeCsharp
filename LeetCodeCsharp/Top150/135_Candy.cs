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
}
