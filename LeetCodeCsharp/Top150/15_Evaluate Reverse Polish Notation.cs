using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;

internal class _15_Evaluate_Reverse_Polish_Notation
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> operands = new();
        Stack<string> oper = new();
        for(int i = tokens.Length - 1;i>=0; i--)
        {

        }
        foreach (string token in tokens)
        {
            if(int.TryParse(token, out int num)) operands.Push(num);
            else revO.Push(token);
        }

        while(revO.Count > 0) oper.Push(revO.Pop());

        int result = 0;
        while(operands.Count > 0)
        {
            result = 0;
            int op2 = operands.Pop();
            int op1 = operands.Pop();
            string op = oper.Pop();
            if (op == "+") result = op1 + op2;
            else if (op == "-") result = op1 - op2;
            else if (op == "*") result = op1 * op2;
            else result = op1 / op2;
            if (operands.Count == 0) break;
            operands.Push(result);
        }
        return result;
    }
}
