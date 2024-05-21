using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
//44 minutes, because i keep trying to find solution by combination of list
//and dict but dict was enough for solving
public class RandomizedSet
{
    Random rnd = new Random();
    private readonly Dictionary<int, int> dict;

    public RandomizedSet()
    {
        dict = new Dictionary<int, int>();
    }

    public bool Insert(int val)
    {
        return dict.TryAdd(val, val);
    }

    public bool Remove(int val)
    {
        return dict.Remove(val);
    }

    public int GetRandom()
    {
        
        int index = rnd.Next(dict.Count);
        return dict.ElementAtOrDefault(index).Key;
    }
}


