using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_ToaDo
{
    public class ToaDo
    {
        private int x;
        private int y;
        private string tenToaDo;
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public string getTenToaDo()
        {
            return tenToaDo;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public void setTenToaDo(string tenToaDo)
        {
            this.tenToaDo = tenToaDo;
        }
        public String toString()
        {
            return this.tenToaDo + "(" + this.x + "," + this.y + ")";
        }
        public ToaDo()
        {
        }
        public ToaDo(int x, int y, string tenToaDo)
        {
            this.x = x;
            this.y = y;
            this.tenToaDo = tenToaDo;
        }
    }

   
}
 