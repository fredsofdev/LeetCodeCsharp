using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _54_Spiral_Matrix
{
    //80 minutes
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int m = matrix.Length, n = matrix[0].Length;    
        int dir = 0; // Right: 0, Down: 1, Left: 2, Up: 3;

        Dictionary<string, int> result = new();
        result.Add("0x0", matrix[0][0]);
        int i = 0, j = 0;
        while(result.Count!= m * n)
        {
            int iNew = i, jNew = j;
            if (dir == 0 && j != n - 1) jNew++;
            else if (dir == 1 && i != m - 1) iNew++;
            else if (dir == 2 && j != 0) jNew--;
            else if (dir == 3 && i != 0) iNew--;
            else { dir = (dir + 1) % 4; continue; }

            string key = $"{iNew}x{jNew}";
            
            if (result.ContainsKey(key)) dir = (dir + 1) % 4;
            else
            {
                result.Add(key, matrix[iNew][jNew]);
                i = iNew;
                j = jNew;
            }
        }

        return result.Values.ToArray();
    }

    public IList<int> SpiralOrder2(int[][] matrix)
    {
        int m = matrix.Length, n = matrix[0].Length;
        int dir = 0; // Right: 0, Down: 1, Left: 2, Up: 3;

        Dictionary<string, int> result = new();
        result.Add("0x0", matrix[0][0]);
        int i = 0, j = 0;
        while (result.Count != m * n)
        {
            int iNew = i, jNew = j;
            if (dir == 0) jNew++;
            else if (dir == 1) iNew++;
            else if (dir == 2) jNew--;
            else iNew--;


            string key = $"{iNew}x{jNew}";
            if (iNew < 0 || iNew >= m ||
                jNew < 0 || jNew >= n ||
                result.ContainsKey(key)) dir = (dir + 1) % 4;
            else
            {
                result.Add(key, matrix[iNew][jNew]);
                i = iNew;
                j = jNew;
            }
        }

        return result.Values.ToArray();
    }
}
