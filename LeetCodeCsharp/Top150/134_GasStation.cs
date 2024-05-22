using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _134_GasStation
{
    // 1 hour, implementation took much time and detailed parts caused time
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int s = -1;
        int totalGas = 0;
        for(int i = 0; i < gas.Length; i++)
        {
            totalGas += gas[i] - cost[i];
            if (totalGas < 0)
            {
                totalGas = 0;
                s = -1;
            }
            else if (s == -1) s = i;
        }

        if (s == -1) return s;
        Console.WriteLine(s);

        int index = s;
        totalGas = 0;
        while(true)
        {
            totalGas += (gas[index] - cost[index]);
            Console.WriteLine(gas[index] - cost[index]);
            if (totalGas >= 0) index = (index + 1) % gas.Length;
            else return -1;
            if (index == s) break;
        }
        return s;
    }

    //optimization 
    public int CanCompleteCircuit2(int[] gas, int[] cost)
    {
        int s = -1;
        int totalGas = 0;
        int sumGas = 0, sumCost = 0;
        for (int i = 0; i < gas.Length; i++)
        {
            sumGas += gas[i];
            sumCost += cost[i];
            totalGas += gas[i] - cost[i];
            if (totalGas < 0)
            {
                totalGas = 0;
                s = -1;
            }
            else if (s == -1) s = i;
        }

        if (s == -1) return s;
        if (sumGas >= sumCost) return s;
        return -1;
    }


}
