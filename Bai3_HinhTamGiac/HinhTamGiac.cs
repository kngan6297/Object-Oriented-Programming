using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_HinhTamGiac
{
    public class HinhTamGiac
    {
        private float ma;
        private float mb;
        private float mc;
        private string kieuTamGiac;
        //constructor mặc định
        public HinhTamGiac()
        {

        }
        //constructor đủ tham số
        public HinhTamGiac(float ma, float mb, float mc)
        {
            // neu canh ma la so am, gan gia tri = 0
            if (ma < 0)
            {
                this.ma = 0;
            } else
            {
                this.ma = ma;
            }
            if (mb < 0)
            {
                this.mb = 0;
            }
            else
            {
                this.mb = mb;
            }
            if (mc < 0)
            {
                this.mc = 0;
            }
            else
            {
                this.mc = mc;
            }
            // neu khong phai tam gia gan cac gia tri khoi tao = 0
            if (!(ma + mb > mc && mb + mc > ma && ma + mc > mb))
            {
                this.ma = 0;
                this.mb = 0;
                this.mc = 0;
            }
        }
        //getter
        public float getma()
        {
            return ma;
        }
        public float getmb()
        {
            return mb;
        }
        public float getmc()
        {
            return mc;
        }
        //setter
        public void setma()
        {
            if(ma < 0)
            {
                this.ma = 0;
            }
            else
            {
                this.ma = ma;
            }
        }
        public void setmb()
        {
            if (mb < 0)
            {
                this.mb = 0;
            }
            else
            {
                this.mb = mb;
            }
        }
        public void setmc()
        {
            if (mc < 0)
            {
                this.mc = 0;
            }
            else
            {
                this.mc = mc;
            }
        }
        public float TinhChuVi()
        {
            return ma + mb + mc;
        }
        public double TinhDienTich()
        {
            float p = (ma + mb + mc) / 2;
            return Math.Sqrt(p * (p - ma) * (p - mb) * (p - mc));
        }
        public string KieuTamGiac()
        {
            if(ma + mb > mc && mb + mc > ma && ma + mc > mb)
            {
                if(ma == mb && mb == mc && mc == ma)
                {
                    this.kieuTamGiac = "Tam giac deu";
                }
                else if(ma == mb || mb == mc || mc == ma)
                {
                    this.kieuTamGiac = "Tam giac can";
                }
                else
                {
                    this.kieuTamGiac = "Tam giac thuong";
                }
            }
            else
            {
                this.kieuTamGiac = "Khong phai hinh tam giac";
            }
            return this.kieuTamGiac;
        }
        public void HienthiHinhTamGiac()
        {
            Console.WriteLine(this.toString());
        }
        public string toString()
        {
            return String.Format("{0,-10} {1,-10} {2,-10} {3,-30} {4,-10} {5,-10:0.00}", this.ma, this.mb, this.mc, this.KieuTamGiac(), this.TinhChuVi(), this.TinhDienTich());
        }
    }
    
}
