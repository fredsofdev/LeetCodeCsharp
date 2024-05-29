using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _73_Set_Matrix_Zeroes
{
    //12 minutes
    public void SetZeroes(int[][] matrix)
    {
        List<int[]> points = new List<int[]>();
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++) 
                if (matrix[i][j] == 0) points.Add(new int[] { i, j });
        }

        foreach (int[] point in points)
        {
            for(int i = 0;i < matrix[0].Length;i++) matrix[point[0]][i] = 0;
            for (int i = 0; i < matrix.Length; i++) matrix[i][point[1]] = 0;
        }
    }
}
