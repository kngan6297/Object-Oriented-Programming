using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_Vehicle
{
    public class Vehicle
    {
        private string TenChuXe;
        private string LoaiXe;
        private double DungTich;
        private double TriGia;
        private double ThuePhaiNop;
        //constructor mặc định
        public Vehicle()
        {

        }
        //constructor đủ tham số
        public Vehicle(string TenChuXe, string LoaiXe, float DungTich, float TriGia)
        {
            this.TenChuXe = TenChuXe;
            this.LoaiXe = LoaiXe;
            this.DungTich = DungTich;
            this.TriGia = TriGia;
        }
        //getter
        public string getTenChuXe()
        {
            return TenChuXe;
        }
        public string getLoaiXe()
        {
            return LoaiXe;
        }
        public double getDungTich()
        {
            return DungTich;
        }
        public double getTriGia()
        {
            return TriGia;
        }
        //setter
        public void setTenChuXe(string TenChuXe)
        {
            this.TenChuXe = TenChuXe;
        }
        public void setLoaiXe(string LoaiXe)
        {
            this.LoaiXe = LoaiXe;
        }
        public void setDungTich(int DungTich)
        {
            this.DungTich = DungTich;
        }
        public void setTriGia(int TriGia)
        {
            this.TriGia = TriGia;
        }
        public double tinhThuePhaiNop()
        {
            if(DungTich < 100)
            {
                this.ThuePhaiNop = 0.01 * this.TriGia;
            } else if(DungTich >= 100 && DungTich < 200)
            {
                this.ThuePhaiNop = 0.03 * this.TriGia;
            }
            else
            {
                this.ThuePhaiNop = 0.05 * this.TriGia;
            }
            return this.ThuePhaiNop;
        }
        public void HienthiXe()
        {
            Console.WriteLine(this.toString());
        }
        public string toString()
        {
            return String.Format("{0,-20} {1,-20} {2,10} {3,20:#,##0.00} {4,20:#,##0.00}", this.TenChuXe, this.LoaiXe, this.DungTich, this.TriGia, this.tinhThuePhaiNop());
        }
    }
}
