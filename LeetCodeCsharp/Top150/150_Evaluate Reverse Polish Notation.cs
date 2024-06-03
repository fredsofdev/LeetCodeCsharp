using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _150_Evaluate_Reverse_Polish_Notation
{
    //16 minutes
    public int EvalRPN(string[] tokens)
    {
        Stack<int> operands = new();

        foreach (var token in tokens)
        {
            if (int.TryParse(token, out int val))
            {
                operands.Push(val);
                continue;
            }

            int op2 = operands.Pop();
            int op1 = operands.Pop();
            if (token == "+") operands.Push(op1 + op2);
            else if (token == "-") operands.Push(op1 - op2);
            else if (token == "*") operands.Push(op1 * op2);
            else operands.Push(op1 / op2);
        }
        return operands.Pop();
    }
}
