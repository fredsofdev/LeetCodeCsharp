using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _547_Number_of_Provinces
{
    public int[] id;
    private int[] sz;
    private int[] groups;

    //32 minutes
    public int FindCircleNum(int[][] isConnected)
    {
        int N = isConnected.Length;
        id = new int[N];
        sz = new int[N];
        groups = new int[N];
        for (int i = 0; i < N; i++)
        {
            id[i] = i;
            sz[i] = 1;
            groups[i] = 1;
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = i+1; j < N; j++)
            {
                if(isConnected[i][j] == 1) Connect(i, j);
            }
        }

        return groups.Sum();
    }

    private void Connect(int p, int q)
    {
        int i = root(p);
        int j = root(q);
        if (i == j) return;
        if (sz[i] > sz[j])
        {
            id[j] = i;
            sz[i] += sz[j];
            groups[j] = 0;
        }
        else
        {
            id[i] = j;
            sz[j] += sz[i];
            groups[i] = 0;
        }
    }

    private int root(int child)
    {
        while (child != id[child])
        {
            id[child] = id[id[child]];//Added for path compression
            child = id[child];
        }
        return child;
    }

}


