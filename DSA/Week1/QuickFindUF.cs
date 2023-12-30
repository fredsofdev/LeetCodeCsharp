using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week1
{
    internal class QuickFindUF : IUF
    {
        private readonly int[] id;

        public QuickFindUF(int N)
        {
            id = new int[N];
            for(int i = 0; i < N; i++)
            {
                id[i] = i;
            }
        }

        public bool connected(int p, int q)
        {
            return id[p] == id[q];
        }

        public void union(int p, int q)
        {
            if (connected(p, q)) return;

            int prev = id[q];
            int next = id[p];
            for(int i = 0; i < id.Length; i++)
            {
                if (id[i] == next) id[i] = prev;
            }
        }
    }
}
