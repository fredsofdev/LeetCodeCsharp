using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week1;

public interface IUF
{
    public void union(int p, int q);

    public bool connected(int p, int q);
}
