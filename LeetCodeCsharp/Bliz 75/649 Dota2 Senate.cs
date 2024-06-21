using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _649_Dota2_Senate
{
    //15 minutes after getting some idea
    public string PredictPartyVictory(string senate)
    {
        Queue<int> rad = new(), dir = new();
        
        for(int i = 0; i < senate.Length; i++)
        {
            if (senate[i] == 'R') rad.Enqueue(i);
            else dir.Enqueue(i);
        }

        int N = senate.Length;
        while(rad.Count > 0 && dir.Count > 0)
        {
            Console.WriteLine($"{rad.Peek()} {dir.Peek()}");
            int cmp = rad.Dequeue().CompareTo(dir.Dequeue());
            if (cmp > 0) rad.Enqueue(N++);
            else dir.Enqueue(N++);
        }

        return rad.Count > 0 ? "Radiant" : "Dire";
    }
}
