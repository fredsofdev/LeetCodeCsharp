using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    internal class Valid_Sudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            Dictionary<int, HashSet<char>> rows = new();
            Dictionary<int, HashSet<char>> cols = new();
            Dictionary<string, HashSet<char>> grids = new();

            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    if(board[i][j] == '.') continue;
                    var gridKey = $"{ i / 3},{ j / 3 }";
                    Console.WriteLine(gridKey);
                    if (!rows.ContainsKey(i)) rows.Add(i, new HashSet<char>());
                    if (!cols.ContainsKey(j)) cols.Add(j, new HashSet<char>());
                    /*if (!grids.ContainsKey(gridKey))
                    {
                        grids.Add(gridKey, new HashSet<char>());
                    }*/
                    Console.WriteLine($"{i},{j}");
                    if (!rows[i].Add(board[i][j])) return false;
                    if (!cols[j].Add(board[j][i])) return false;
                    //if (!grids[gridKey].Add(board[i][j])) return false;
                }
            }
            return true;
        }
    }
}
