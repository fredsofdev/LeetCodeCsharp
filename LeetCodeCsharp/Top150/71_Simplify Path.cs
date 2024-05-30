using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _71_Simplify_Path
{
    //21 minutes
    public string SimplifyPath(string path)
    {
        string[] pathA = path.Split('/');

        Stack<string> stack = new Stack<string>();
        foreach (string s in pathA)
        {
            if (s.Length == 0 || s == ".") continue;
            if (s == "..") if(stack.Count > 0) stack.Pop();
            else stack.Push(s);
        }
        if (stack.Count == 0) return "/";
        string result = "";
        while (stack.Count > 0)
        {
            string name = stack.Pop();
            result = "/" + name + result;
        }
        return result;
    }
}
