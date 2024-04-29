using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Assignment
{
    internal class Point: IComparable
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public int CompareTo(object? obj)
        {
            Point? other = obj as Point;
            if (this.X > other.X) return 1;
            if (this.X < other.X) return -1;
            if (this.Y > other.Y) return 1;
            if (this.Y < other.Y) return -1;
            return 0;
        }
    }
}
