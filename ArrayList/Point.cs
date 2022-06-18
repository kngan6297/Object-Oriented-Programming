using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_BT
{
    public class Point:IComparable<Point>
    {
        private int x;
        private int y;
        public Point() { }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int CompareTo(Point? other)
        {
            if (this.x < other.x) { return 1; }
            else if (this.x > other.x) { return -1; }
            return 0;
        }

        public int getX() { return x; }
        public int getY() { return y; }
        public void setX(int x) { this.x = x; }
        public void setY(int y) { this.y = y; }
        public string toString()
        {
            return String.Format("({0}, {1})", x, y);
        }
    }
}
