using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _36_Valid_Sudoku
{
    //35 minutes
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<char> nums = new();
        foreach (char[] row in board)
        {
            foreach(char c in row) if(c != '.' && !nums.Add(c)) return false;
            nums.Clear();
        }
        for(int i=0; i< board.Length; i++)
        {
            for(int j=0; j< board.Length; j++)
            {
                if (board[j][i] != '.' && !nums.Add(board[j][i])) return false;
            }
            nums.Clear();
        }


        for (int i = 0; i < 9; i+=3)
        {
            for (int j = 0; j < 9; j+=3)
            {
                for(int k = 0; k< 3; k++)
                {
                    for(int l = 0; l < 3; l++)
                    {
                        char c = board[i + k][j + l];
                        if (c != '.' && !nums.Add(c)) return false;
                    }
                }
                nums.Clear();
            }
        }
        return true;
    }

    public bool IsValidSudoku2(char[][] board)
    {
        HashSet<char> row = new();
        HashSet<char> col = new();
        Dictionary<string, HashSet<char>> triples = new();

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board.Length; j++)
            {

                char r = board[i][j];
                char c = board[j][i];
                if (c != '.' && !col.Add(c)) return false;
                if (r != '.' && !row.Add(r)) return false;
                string key = $"{i / 3}x{j / 3}";

                if (r == '.') continue;
                if (!triples.ContainsKey(key)) triples[key] = new() { r };
                else if (!triples[key].Add(r)) return false;
            }
            row.Clear();
            col.Clear();
        }

        return true;
    }
}
