using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_CD
{
    public class ManagingProgram
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Menu menu = new Menu(7);
            menu.add("Thêm một CD vào danh sách");
            menu.add("Tính số lượng CD có trong danh sách");
            menu.add("Tính tổng giá thành của các CD");
            menu.add("Trả thông tin của toàn bộ CD có trong danh sách");
            menu.add("Sắp xếp danh sách giảm dần theo giá thành");
            menu.add("Sắp xếp danh sách tăng dần theo tựa CD");
            menu.add("Thoát");
            int choice;
            CDList list = new CDList(50);
            list.addCD(new CD(2017, "Tâm 9", 5, 500000));
            list.addCD(new CD(2010, "Melodies of Time", 10, 1000000));
            list.addCD(new CD(2021, "Vậy Cũng Vui", 28, 2800000));
            list.addCD(new CD(2018, "Cho Một Tình Yêu", 13, 1300000));
            list.addCD(new CD(2013, "Tâm, Vol. 8", 10, 1000000));
            do
            {
                Console.WriteLine("\nQUẢN LÝ CD");
                choice = menu.getChoice();
                switch (choice)
                {
                    case 1:
                        list.addCD();
                        break;
                    case 2:
                        list.countCD();
                        break;
                    case 3:
                        Console.WriteLine("Tổng giá thành của các CD là: " + list.totalPriceCD());
                        break;
                    case 4:
                        list.printCD();
                        break;
                    case 5:
                        list.sortGiaThanh();
                        list.printCD();
                        break;
                    case 6:
                        list.sortTuaCD();
                        list.printCD();
                        break;
                }
            }
            while (choice >= 1 && choice < 7);
        }
    }
}