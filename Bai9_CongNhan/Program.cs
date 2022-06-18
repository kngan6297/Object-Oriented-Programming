using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_CongNhan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DanhSachCongNhan list = new DanhSachCongNhan(50);
            list.addCN(new CongNhan(111, "Nguyễn Văn", "A", 100));
            list.addCN(new CongNhan(222, "Trần Văn", "B", 250));
            list.addCN(new CongNhan(333, "Lê Văn", "C", 700));
            list.addCN(new CongNhan(444, "Phạm Thị", "D", 500));
            list.addCN(new CongNhan(555, "Võ Thị", "E", 300));
            Console.WriteLine("//Xuất toàn bộ thông tin công nhân viên");
            list.printCN();
            Console.WriteLine("\n//Tính số lượng công nhân viên có trong danh sách");
            list.countCN();
            Console.WriteLine("\n//Xuất thông tin các công nhân làm trên 200 sản phẩm");
            list.printCN200();
            Console.WriteLine("\n//Sắp xếp công nhân theo số sản phẩm giảm dần");
            list.sortSoSP();
            list.printCN();
        }
    }
}
