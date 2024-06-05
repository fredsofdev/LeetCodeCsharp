using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
public class LRUCache
{
    //29 minutes
    private int N;
    private Dictionary<int, int> table = new();
    private List<int> keys = new();
    public LRUCache(int capacity)
    {
        N = capacity;
    }

    public int Get(int key)
    {
        if (table.ContainsKey(key))
        {
            keys.Remove(key);
            keys.Add(key);
            return table[key];
        }
        else return -1;
    }

    public void Put(int key, int value)
    {
        table[key] = value;
        keys.Remove(key);
        keys.Add(key);
        if (table.Count > N)
        {
            int rmKey = keys[0];
            keys.RemoveAt(0);
            table.Remove(rmKey);
        }
    }
}


