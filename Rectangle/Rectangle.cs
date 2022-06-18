using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    abstract public class Rectangle
    {
        private int lenght = 0;
        private int width = 0;
        public Rectangle() { }
        public Rectangle(int l, int w)
        {
            if(l < 0)
            {
                this.lenght = 0;
            } else
            {
                this.lenght = l;
            }
            if(w < 0)
            {
                this.width = 0;
            } else
            {
                this.width = w;
            }              
        }
        public virtual string toString()
        {
            return "[" + getLength() + "," + getWidth() + "]";
        }
        public int getLength()
        {
            return lenght;
        }
        public int getWidth()
        {
            return width;
        }
        public void setLength(int l)
        {
            this.lenght = l;
        }
        public void setWidth(int w)
        {
            this.width = w;
        }
        public virtual int area()
        {
            return lenght * width;
        }
    }
}
