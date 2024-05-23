using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _6_ZigzagConversion
{
    //17 minute
    public string Convert(string s, int numRows)
    {
        string[] rows = new string[numRows];
        bool down = true;
        int rowIn = 0;
        foreach(char c in s)
        {
            Console.WriteLine(rowIn);
            rows[rowIn] += c;
            if (down) rowIn++;
            else rowIn--;
            if(rowIn == 0 || rowIn == numRows-1) down = !down;
        }
        return string.Join("", rows);
    }
}
