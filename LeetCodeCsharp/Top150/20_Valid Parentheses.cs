using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _20_Valid_Parentheses
{
    //16 minutes
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> pair = new()
        {
            ['('] = ')',
            ['{'] = '}',
            ['['] = ']'
        };
        foreach (char c in s)
        {
            if (pair.ContainsKey(c))
            {
                stack.Push(pair[c]);
            }
            else if(stack.Pop() != c) return false;
        }
        return stack.Count == 0;
    }
}
