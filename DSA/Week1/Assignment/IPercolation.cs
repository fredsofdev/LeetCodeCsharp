using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week1.Assignment
{
    internal interface IPercolation
    {

        // opens the site (row, col) if it is not open already
        public void open(int row, int col);

        // is the site (row, col) open?
        public bool isOpen(int row, int col);

        // is the site (row, col) full?
        public bool isFull(int row, int col);

        // returns the number of open sites
        public int numberOfOpenSites();

        // does the system percolate?
        public bool percolates();

    }
}
