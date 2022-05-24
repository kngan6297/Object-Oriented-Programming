using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_SinhVien
{
    public class SinhVienMain
    {
        static void Main(String[] args)
        {
            SinhVien sv1 = new SinhVien(11111, "Ly Thi Kim Ngan", (float)8.5, (float)9.5);
            SinhVien sv2 = new SinhVien(22222, "Tran Ba Quan Thuy", 7, 8);
            SinhVien sv3 = new SinhVien();
            int maSV = 0;
            while (maSV <= 0)
            {
                Console.WriteLine("Nhap ma so cua sinh vien sv3:");
                maSV = Convert.ToInt32(Console.ReadLine());
                if (maSV <= 0)
                {
                    Console.WriteLine("Ma so cua sinh vien khong hop le");
                }
            }
            sv3.setMaSV(maSV);
            string name = "";
            while (name.Length == 0)
            {
                Console.WriteLine("Nhap ho va ten cua sinh vien sv3:");
                name = Console.ReadLine();
                if (name.Length == 0)
                {
                    Console.WriteLine("Ho va ten cua sinh vien khong hop le");
                }
            }
            sv3.setHoTen(name);
            float diemLT = -1;
            while (diemLT < 0 || diemLT > 10)
            {
                Console.WriteLine("Nhap diem ly thuyet cua sinh vien sv3:");
                diemLT = float.Parse(Console.ReadLine());
                if (diemLT < 0 || diemLT > 10)
                {
                    Console.WriteLine("Diem ly thuyet cua sinh vien khong hop le");
                }
            }
            sv3.setDiemLT(diemLT);
            float diemTH = -1;
            while (diemTH < 0 || diemTH > 10)
            {
                Console.WriteLine("Nhap diem thuc hanh cua sinh vien sv3:");
                diemTH = float.Parse(Console.ReadLine());
                if (diemTH < 0 || diemTH > 10)
                {
                    Console.WriteLine("Diem thuc hanh cua sinh vien khong hop le");
                }
            }
            sv3.setDiemTH(diemTH);
            Console.WriteLine("\n{0,-10} {1,-30} {2,-10} {3,-10} {4,-10}", "MaSV", "HoTen", "DiemLT", "DiemTH", "DiemTB");
            sv1.hienthiSV();
            sv2.hienthiSV();
            sv3.hienthiSV();
        }
    }
}