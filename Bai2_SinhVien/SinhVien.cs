using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_SinhVien
{
    public class SinhVien
    {
        private int MaSV;
        private string HoTen;
        private float DiemLT;
        private float DiemTH;
        //constructor mặc định
        public SinhVien()
        {
        }
        //constructor đầy đủ
        public SinhVien(int MaSV, string HoTen, float DiemLT, float DiemTH)
        {
            this.MaSV = MaSV;
            this.HoTen = HoTen;
            this.DiemLT = DiemLT;
            this.DiemTH = DiemTH;
        }
        public int getMaSV()
        {
            return MaSV;
        }
        public void setMaSV(int MaSV)
        {
            this.MaSV = MaSV;
        }
        public String getHoTen()
        {
            return HoTen;
        }
        public void setHoTen(String HoTen)
        {
            this.HoTen = HoTen;
        }
        public float getDiemLT()
        {
            return DiemLT;
        }
        public void setDiemLT(float DiemLT)
        {
            if (DiemLT < 0 || DiemLT > 10)
            {
                this.DiemLT = 0;
            }
            else
            {
                this.DiemLT = DiemLT;
            }
        }
        public float getDiemTH()
        {
            return DiemTH;
        }
        public void setDiemTH(float DiemTH)
        {
            if (DiemTH < 0 || DiemTH > 10)
            {
                this.DiemTH = 0;
            }
            else
            {
                this.DiemTH = DiemTH;
            }
        }
        public float tinhDiemTB()
        {
            return (DiemLT + DiemTH) / 2;
        }
        public void hienthiSV()
        {
            Console.WriteLine(this.toString());
        }
        public String toString()
        {
            return String.Format("{0,-10} {1,-30} {2,-10} {3,-10} {4,-10}", this.MaSV, this.HoTen, this.DiemLT, this.DiemTH, this.tinhDiemTB());

        }
    }
}