using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11_HocVien
{
    public class HocVienMain
    {
        static void Main(String[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HocVien hv1 = new HocVien("Nguyễn Văn A", 2000, new MonHoc("Toán", 5), new MonHoc("Lý",6), new MonHoc("Hoá", 5), new MonHoc("Văn", 6.5), new MonHoc("Anh", 9));
            HocVien hv2 = new HocVien("Trần Văn B", 2000, new MonHoc("Toán", 4.5), new MonHoc("Lý", 5.5), new MonHoc("Hoá", 6.5), new MonHoc("Văn", 7.5), new MonHoc("Anh", 8.5));
            HocVien hv3 = new HocVien("Phạm Văn C", 2000, new MonHoc("Toán", 6.5), new MonHoc("Lý", 7.6), new MonHoc("Hoá", 7), new MonHoc("Văn", 3.3), new MonHoc("Anh", 4.4));
            HocVien hv4 = new HocVien("Võ Văn D", 2000, new MonHoc("Toán", 7), new MonHoc("Lý", 8.6), new MonHoc("Hoá", 7), new MonHoc("Văn", 6), new MonHoc("Anh", 10));
            HocVien hv5 = new HocVien("Lê Văn E", 2000, new MonHoc("Toán", 8), new MonHoc("Lý", 6.6), new MonHoc("Hoá", 6), new MonHoc("Văn", 7), new MonHoc("Anh", 7));
            HocVien[] list = { hv1, hv2, hv3, hv4, hv5 };
            Console.WriteLine("{0,-15} {1,-8} {2,-13} {3,-13} {4,-13} {5,-13} {6,-13} {7,-15}", "Họ tên", "Năm sinh", "Điểm môn Toán", "Điểm môn Lý", "Điểm môn Hóa", "Điểm môn Văn", "Điểm môn Anh", "Ghi chú");
            Console.WriteLine(hv1.toString());
            Console.WriteLine(hv2.toString());
            Console.WriteLine(hv3.toString());
            Console.WriteLine(hv4.toString());
            Console.WriteLine(hv5.toString());
            var soluongthilai = new Dictionary<string, double>();
            soluongthilai["Toán"] = 0;
            soluongthilai["Lý"] = 0;
            soluongthilai["Hoá"] = 0;     
            soluongthilai["Văn"] = 0;     
            soluongthilai["Anh"] = 0;
            var soLuongLamLuanVan = 0;
            var soLuongThiTotNghiep = 0;
            var soLuongThiLai = 0;
            for(int i =0; i < list.Length; i++)
            {
                if (list[i].lamLuanVan())
                {
                    soLuongLamLuanVan++;
                }
                else if (list[i].thiTotNghiep())
                {
                    soLuongThiTotNghiep++;
                } 
                else
                {
                    soLuongThiLai++;
                    var monThiLai = list[i].thiLai();
                    if(monThiLai.Count > 0)
                    {
                        for (int j = 0; j < monThiLai.Count; j++)
                        {
                            soluongthilai[monThiLai[j]]++;
                        }
                    }
                }
            }
            Console.WriteLine("\nSố lượng học viên làm luận văn là: " + soLuongLamLuanVan);
            Console.WriteLine("Số lượng học viên thi tốt nghiệp là: " + soLuongThiTotNghiep);
            Console.WriteLine("Số lượng học viên thi lại là: " + soLuongThiLai);
            Console.WriteLine("Số lượng học viên thi lại của các môn là: ");
            for(int i = 0; i < soluongthilai.Count; i++)
            {
                var item = soluongthilai.ElementAt(i);  
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}