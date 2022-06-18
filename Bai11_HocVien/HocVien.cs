using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11_HocVien
{
    public class HocVien
    {
        private string hoTen;
        private int namSinh;
        private MonHoc diemMon1;
        private MonHoc diemMon2;
        private MonHoc diemMon3;
        private MonHoc diemMon4;
        private MonHoc diemMon5;
        //constructor
        public HocVien()
        {

        }
        public HocVien(string hoten, int namsinh, MonHoc diem1, MonHoc diem2, MonHoc diem3, MonHoc diem4, MonHoc diem5)
        {
            this.hoTen = hoten;
            this.namSinh = namsinh;
            this.setDiemMon1(diem1);
            this.setDiemMon2(diem2);
            this.setDiemMon3(diem3);
            this.setDiemMon4(diem4);
            this.setDiemMon5(diem5);
        }
        //getter
        public string getHoTen()
        {
            return hoTen;
        }
        public int getNamSinh()
        {
            return namSinh;
        }
        public MonHoc getDiemMon1()
        {
            return diemMon1;
        }
        public MonHoc getDiemMon2()
        {
            return diemMon2;
        }
        public MonHoc getDiemMon3()
        {
            return diemMon3;
        }
        public MonHoc getDiemMon4()
        {
            return diemMon4;
        }
        public MonHoc getDiemMon5()
        {
            return diemMon5;
        }
        //setter
        public void setHoTen(string hoten)
        {
            this.hoTen = hoten;
        }
        public void setNamSinh(int namsinh)
        {
            this.namSinh = namsinh;
        }
        public void setDiemMon1(MonHoc diem1)
        {
            if (diem1.getDiem() < 0 || diem1.getDiem() > 10)
            {
                this.diemMon1 = new MonHoc(diem1.getTenMonHoc(),0);
            }
            else
            {
                this.diemMon1 = diem1;
            }
        }
        public void setDiemMon2(MonHoc diem2)
        {
            if (diem2.getDiem() < 0 || diem2.getDiem() > 10)
            {
                this.diemMon2 = new MonHoc(diem2.getTenMonHoc(), 0);
            }
            else
            {
                this.diemMon2 = diem2;
            }
        }
        public void setDiemMon3(MonHoc diem3)
        {
            if (diem3.getDiem() < 0 || diem3.getDiem() > 10)
            {
                this.diemMon3 = new MonHoc(diem3.getTenMonHoc(), 0);
            }
            else
            {
                this.diemMon3 = diem3;
            }
        }
        public void setDiemMon4(MonHoc diem4)
        {
            if (diem4.getDiem() < 0 || diem4.getDiem() > 10)
            {
                this.diemMon4 = new MonHoc(diem4.getTenMonHoc(), 0);
            }
            else
            {
                this.diemMon4 = diem4;
            }
        }
        public void setDiemMon5(MonHoc diem5)
        {
            if (diem5.getDiem() < 0 || diem5.getDiem() > 10)
            {
                this.diemMon5 = new MonHoc(diem5.getTenMonHoc(), 0);
            }
            else
            {
                this.diemMon5 = diem5;
            }
        }
        public double tinhDiemTB()
        {
            return (diemMon1.getDiem() + diemMon2.getDiem() + diemMon3.getDiem() + diemMon4.getDiem() + diemMon5.getDiem()) / 5;
        }
        public Boolean lamLuanVan()
        {
            if (tinhDiemTB() > 7 && this.diemMon1.getDiem() >= 5 && this.diemMon2.getDiem() >= 5 && this.diemMon3.getDiem() >= 5 && this.diemMon4.getDiem() >= 5 && this.diemMon5.getDiem() >= 5)
            {
                return true;
            }
            return false;
        }
        public Boolean thiTotNghiep()
        {
            if (tinhDiemTB() <= 7 && this.diemMon1.getDiem() >= 5 && this.diemMon2.getDiem() >= 5 && this.diemMon3.getDiem() >= 5 && this.diemMon4.getDiem() >= 5 && this.diemMon5.getDiem() >= 5)
            {
                return true;
            }
            return false;
        }
        public List<string> thiLai()
        {
            List<string> listMonThiLai = new List<string>();
            if (this.diemMon1.getDiem() < 5)
            {
                listMonThiLai.Add(this.diemMon1.getTenMonHoc());
            }
            else if (this.diemMon2.getDiem() < 5)
            {
                listMonThiLai.Add(this.diemMon2.getTenMonHoc());
            }            else if (this.diemMon3.getDiem() < 5)
            {
                listMonThiLai.Add(this.diemMon3.getTenMonHoc());
            }            else if (this.diemMon4.getDiem() < 5)
            {
                listMonThiLai.Add(this.diemMon4.getTenMonHoc());
            }else if (this.diemMon5.getDiem() < 5)
            {
                listMonThiLai.Add(this.diemMon5.getTenMonHoc());
            }
            return listMonThiLai;
        }

        public string trangThaiHS()
        {
            if (lamLuanVan())
            {
                return "Làm luận văn";
            } else if (thiTotNghiep())
            {
                return "Thi tốt nghiệp";
            } else
            {
                return "Thi lại";
            }
        }
        public string toString()
        {
            return String.Format("{0,-15} {1,-8} {2,-13} {3,-13} {4,-13} {5,-13} {6,-13} {7,-15}", this.hoTen, this.namSinh, this.diemMon1.getDiem(), this.diemMon2.getDiem(), this.diemMon3.getDiem(), this.diemMon4.getDiem(), this.diemMon5.getDiem(), this.trangThaiHS());
        }
    }
}
