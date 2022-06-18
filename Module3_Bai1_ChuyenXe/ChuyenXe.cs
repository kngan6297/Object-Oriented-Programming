using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_Bai1_ChuyenXe
{
    public class ChuyenXe
    {
        private int maSoChuyen;
        private string hoTenTaiXe;
        private int soXe;
        private double doanhThu;
        public ChuyenXe() { }
        public ChuyenXe(int masochuyen, string hotentaixe, int soxe, double doanhthu)
        {
            this.maSoChuyen = masochuyen;
            this.hoTenTaiXe = hotentaixe;
            this.soXe = soxe;
            this.doanhThu = doanhthu;
        }
        public int getMaSoChuyen()
        {
            return maSoChuyen;
        }
        public string getHoTenTaiXe()
        {
            return hoTenTaiXe;
        }
        public int getSoXe()
        {
            return soXe;
        }
        public double getDoanhThu()
        {
            return doanhThu;
        }
        public void setMaSoChuyen(int masochuyen)
        {
            this.maSoChuyen = masochuyen;
        }
        public void setHoTenTaiXe(string hotentaixe)
        {
            this.hoTenTaiXe = hotentaixe;
        }
        public void setSoXe(int soxe)
        {
            this.soXe = soxe;
        }
        public void setDoanhThu(double doanhthu)
        {
            this.doanhThu = doanhthu;
        }
    }
}
