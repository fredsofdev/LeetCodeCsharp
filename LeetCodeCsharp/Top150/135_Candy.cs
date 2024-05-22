using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150
{
    internal class _135_Candy
    {
        public int Candy(int[] ratings)
        {
            int candies = 0;
            int lgCandy = 0;
            int lRating = 0;

            for (int i = 0; i < ratings.Length; i++)
            {
                int nRating =   
                if (ratings[i] == 0) lgCandy = 1;
                
                
                candies += lgCandy;
            }
        }
    }
}
