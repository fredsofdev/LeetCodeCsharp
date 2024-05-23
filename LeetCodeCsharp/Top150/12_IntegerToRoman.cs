using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _12_IntegerToRoman
{
    //30 minute
    public string IntToRoman(int num)
    {
        int[] rnum = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        var rchar = new string[] { "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX","V", "IV", "I"};

        string romout = "";
        int i = 0;
        while(num > 0)
        {
            if(num < rnum[i]) i++;
            else
            {
                num -= rnum[i];
                romout += rchar[i];
            }
        }
        return romout;
    }
}
