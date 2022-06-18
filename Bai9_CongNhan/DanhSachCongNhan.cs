using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_CongNhan
{
    public class DanhSachCongNhan
    {
        private CongNhan[] list = null;
        private int count = 0;
        public DanhSachCongNhan(int size)
        {
            if (size < 10)
            {
                size = 10;
            }
            list = new CongNhan[size];
        }
        int findCN(int aMaCN)
        {
            for (int i = 0; i < count; i++)
            {
                if (aMaCN.Equals(list[i].getMaCN()))
                {
                    return i;
                }
            }
            return -1;
        }
        public void addCN(CongNhan CN)
        {
            this.list[count++] = CN;
        }
        public void addCongNhan()
        {
            if (count == list.Length)
            {
                Console.WriteLine("Danh sách đã đầy!");
            }
            else
            {
                int newMaCN;
                string newHo;
                string newTen;
                int newSoSP;
                int pos;
                do
                {
                    Console.WriteLine("Nhập mã CN: ");
                    newMaCN = Convert.ToInt32(Console.ReadLine());
                    pos = findCN(newMaCN);
                    if (pos >= 0)
                    {
                        Console.WriteLine("\tMã CN đã tồn tại!");
                    }
                } while (pos >= 0);
                Console.WriteLine("Nhập họ CN: ");
                newHo = Console.ReadLine();
                Console.WriteLine("Nhập tên CN: ");
                newTen = Console.ReadLine();
                Console.WriteLine("Nhập giá thành: ");
                newSoSP = Convert.ToInt32(Console.ReadLine());
                list[count++] = new CongNhan(newMaCN, newHo, newTen, newSoSP);
                Console.WriteLine("CN mới đã được thêm vào danh sách.");
            }
        }
        public void printCN()
        {
            if (count == 0)
            {
                Console.WriteLine("Danh sách rỗng.");
                return;
            }
            else
            {
                Console.WriteLine("DANH SÁCH CN:");
                Console.WriteLine("{0, -5} | {1, -10} | {2, -5} | {3, -5} | {4, -10}", "Mã CN", "Họ", "Tên", "Số SP", "Lương");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(list[i].toString());
                }
            }
        }
        public void countCN()
        {
            Console.WriteLine("Danh sách có " + count.ToString() + " công nhân.");
        }
        public void printCN200()
        {
            if (count == 0)
            {
                Console.WriteLine("Danh sách rỗng.");
                return;
            }
            else
            {
                Console.WriteLine("DANH SÁCH CN làm trên 200 sản phẩm:");
                Console.WriteLine("{0, -5} | {1, -10} | {2, -5} | {3, -5} | {4, -10}", "Mã CN", "Họ", "Tên", "Số SP", "Lương");
                for (int i = 0; i < count; i++)
                {
                    if(list[i].getSoSP() > 200)
                    {
                        Console.WriteLine(list[i].toString());
                    }
                    
                }
            }
        }
        public void sortSoSP()
        {
            if (count == 0)
            {
                return;
            }
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = count - 1; j > i; j--)
                {
                    if (list[j].getSoSP() > list[i].getSoSP())
                    {
                        CongNhan p = this.list[j];
                        this.list[j] = this.list[i];
                        this.list[i] = p;
                    }
                }
            }
        }
    }
}
