using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7_ToaDoHinhTron
{
    public class ToaDo
    {
        private string ten;
        private float x;
        private float y;
        //constructor
        public ToaDo()
        {

        }
        public ToaDo(string ten, float x, float y)
        {
            this.ten = ten;
            this.x = x;
            this.y = y;
        }
        //getter
        public float getX()
        {
            return x;
        }
        public float getY()
        {
            return y;
        }
        //setter
        public void setX()
        {
            this.x = x;
        }
        public void setY()
        {
            this.y = y;
        }
        public string toString()
        {
            return String.Format("{0}({1},{2})", ten, x, y);
        }
    }
}
