using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _289_Game_of_Life
{
    //66 minutes
    public void GameOfLife(int[][] board)
    {
        var init = board.Select(a => a.ToArray()).ToArray();
        List<int[]> n = new()
        {
            new int[]{-1,-1},
            new int[]{-1,0},
            new int[]{-1,1},
            new int[]{0,1},
            new int[]{1,1},
            new int[]{1,0},
            new int[]{1,-1},
            new int[]{0,-1},
        };

        for (int i = 0; i < init.Length; i++)
        {
            for (int j = 0; j < init[i].Length; j++)
            {
                int life = 0;
                foreach(var p  in n)
                {
                    int iN = i + p[0];
                    int jN = j + p[1];
                    if (!valid(init, iN, jN)) continue;
                    if(init[iN][jN] == 1) life++;
                    Console.Write(init[iN][jN]+", ");
                }
                Console.WriteLine( "["+life+"]");
                if(init[i][j] == 0)
                {
                    if(life == 3) board[i][j] = 1;
                }
                else if (life < 2 || life > 3) board[i][j] = 0;
                else board[i][j] = 1;
            }
        }
    }

    private bool valid(int[][] board, int i, int j)
    {
        if (i >= board.Length || i < 0) return false;
        if (j >= board[0].Length ||  j < 0) return false;
        return true;
    }
}
