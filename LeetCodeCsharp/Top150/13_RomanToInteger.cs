using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _13_RomanToInteger
{
    //18 minutes
    public int RomanToInt(string s)
    {
        Dictionary<char, int> rom = new()
        {
            ['M'] = 1000,
            ['D'] = 500,
            ['C'] = 100,
            ['L'] = 50,
            ['X'] = 10,
            ['V'] = 5,
            ['I'] = 1,
        };
        int sum = 0;
        for(int i = 1; i < s.Length; i++)
        {
            if (rom[s[i-1]] < rom[s[i]]) sum -= rom[s[i-1]];
            else sum += rom[s[i-1]];
        }
        sum += rom[s[s.Length - 1]];
        return sum;
    }
}
