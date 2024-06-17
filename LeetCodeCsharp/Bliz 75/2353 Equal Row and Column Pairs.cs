using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium 
internal class _2353_Equal_Row_and_Column_Pairs
{
    //37 minutes, peaked solution
    public int EqualPairs(int[][] grid)
    {
        int count = 0;
        for (int i = 0; i < grid.Length; i++)
        {

            for (int j = 0; j < grid[0].Length; j++)
            {
                bool isMatch = true;
                for (int k = 0; k < grid[0].Length; k++)
                {
                    if (grid[i][k] != grid[k][j])
                    {
                        isMatch = false;
                        break;
                    }
                }
                if (isMatch) count++;
            }
        }
        return count;
    }
}
