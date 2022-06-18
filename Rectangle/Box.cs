using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Box : Rectangle
    {
        private int height = 0;
        public Box() : base() { }
        public Box(int l, int w, int h) : base(l, w)
        {
            if (h < 0)
            {
                this.height = 0;
            }
            else
            {
                this.height = w;
            }
        }
        public int getHeight()
        {
            return height;
        }
        public void setHeight(int h)
        {
            this.height = h;
        }
        public override string toString()
        {
            return "[" + getLength() + "," + getWidth() + "," + getHeight() + "]";
        }
        public override int area()
        {
            int l = this.getLength();
            int w = this.getWidth();
            int h = this.getHeight();
            return 2*(l*w + w*h + h*l);
        }
        public int volumn()
        {
            return this.getLength() * this.getWidth() * height;
        }

    }
}
