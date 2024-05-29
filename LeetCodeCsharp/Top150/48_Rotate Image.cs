using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _48_Rotate_Image
{
    //20 minutes after hint
    public void Rotate(int[][] matrix)
    {
        Array.Reverse(matrix);
        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = i+1; j < matrix[i].Length; j++)
            {
                int hold = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = hold;    
            }
        }
    }
}
