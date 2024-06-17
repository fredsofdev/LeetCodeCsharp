using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _2390_Removing_Stars_From_a_String
{
    //11 minutes
    public string RemoveStars(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if(c == '*') stack.TryPop(out _);
            else stack.Push(c);
        }
        char[] result = new char[stack.Count];
        for(int i = 0; i < stack.Count; i++) result[i] = stack.Pop();
        Array.Reverse(result);
        
        return new string(result);
    }
}
