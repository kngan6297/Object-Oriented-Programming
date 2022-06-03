using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_CD
{
    public class CDList
    {
        private CD[] list = null;
        private int count = 0;
        public CDList(int size)
        {
            if (size < 10)
            {
                size = 10;
            }
            list = new CD[size];
        }
        int findCD(int aMaCD)
        {
            for (int i = 0; i < count; i++)
            {
                if (aMaCD.Equals(list[i].getMaCD()))
                {
                    return i;
                }
            }
            return -1;
        }
        public void addCD()
        {
            if (count == list.Length)
            {
                Console.WriteLine("List is full!");
            }
            else
            {
                int newMaCD;
                string newTuaCD;
                int newSoBaiHat;
                double newGiaThanh;
                int pos;
                do
                {
                    Console.WriteLine("Nhập mã CD: ");
                    newMaCD = Convert.ToInt32(Console.ReadLine());
                    pos = findCD(newMaCD);
                    if (pos >= 0)
                    {
                        Console.WriteLine("\tMã CD đã tồn tại!");
                    }
                } while (pos >= 0);
                Console.WriteLine("Nhập tựa CD: ");
                newTuaCD = Console.ReadLine().ToUpper();
                Console.WriteLine("Nhập số bài hát: ");
                newSoBaiHat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập giá thành: ");
                newGiaThanh = Convert.ToInt32(Console.ReadLine());
                list[count++] = new CD(newMaCD, newTuaCD, newSoBaiHat, newGiaThanh);
                Console.WriteLine("CD mới đã được thêm vào danh sách.");
            }
        }
        public void addCD(CD cd)
        {
            this.list[count++] = cd;
        }            
        public void countCD()
        {
            Console.WriteLine("Danh sách có " + count.ToString() + " CD");
        }
        public double totalPriceCD()
        {
            double total = 0;
            for (int i = 0; i < count; i++)
            {
                total += list[i].getGiaThanh();
            }
            return total;
        }
        public void printCD()
        {
            if (count == 0)
            {
                Console.WriteLine("Empty list.");
                return;
            }
            else
            {
                Console.WriteLine("DANH SÁCH CD:");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(list[i].toString());
                }
            }
        }
        public void sortGiaThanh()
        {
            if (count == 0)
            {
                return;
            }
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = count - 1; j > i; j--)
                {
                    if (list[j].getGiaThanh() > list[i].getGiaThanh())
                    {
                        CD p = this.list[j];
                        this.list[j] = this.list[i];
                        this.list[i] = p;
                    }
                }
            }
        }
        public void sortTuaCD()
        {
            if (count == 0)
            {
                return;
            }
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = count - 1; j > i; j--)
                {
                    if (String.Compare(list[i].getTuaCD(), list[j].getTuaCD()) == 1)
                    {
                        CD p = this.list[j];
                        this.list[j] = this.list[i];
                        this.list[i] = p;
                    }
                }
            }
        }
    }
}
