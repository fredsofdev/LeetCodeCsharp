using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Easy
internal class _605_Can_Place_Flowers
{
    //9 minutes
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int valCount = 0;
        for(int i = 0; i < flowerbed.Length; i++)
        {
            if(valid(flowerbed, i))
            {
                flowerbed[i] = 1;
                valCount++;
            }
        }
        return valCount >= n;
    }

    private bool valid(int[] flowerbed, int i)
    {
        if (flowerbed[i] == 1) return false;
        if (i - 1 >= 0 && flowerbed[i - 1] == 1) return false;
        if (i + 1 < flowerbed.Length && flowerbed[i + 1] == 1) return false;
        return true;
    }
}
