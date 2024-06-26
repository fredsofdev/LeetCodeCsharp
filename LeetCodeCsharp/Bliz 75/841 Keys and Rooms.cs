using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _841_Keys_and_Rooms
{
    //53 minutes
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        HashSet<int> visited = new();
        visited.Add(0);
        Queue<int> queue = new Queue<int>();
        foreach (int key in rooms.First())
        {
            queue.Enqueue(key);
            visited.Add(key);
        }
        while(queue.Count > 0)
        {
            int key = queue.Dequeue();
            if(key < 0 || key > rooms.Count-1) continue;
            foreach(int otherK in rooms[key])
            {
                if (visited.Add(otherK))
                {
                    queue.Enqueue(otherK);
                }
            }
        }

        return visited.Count == rooms.Count;
    }
}
