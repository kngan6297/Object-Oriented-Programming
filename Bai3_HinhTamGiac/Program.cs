using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_HinhTamGiac
{
    public class HinhTamGiacMain
    {
        static void Main(String[] args)
        {
            HinhTamGiac tg1 = new HinhTamGiac(2, 2, 8);
            HinhTamGiac tg2 = new HinhTamGiac(-1, -1, 4);
            HinhTamGiac tg3 = new HinhTamGiac(5, 6, 7);
            HinhTamGiac tg4 = new HinhTamGiac(4, 5, 4);
            HinhTamGiac tg5 = new HinhTamGiac(6, 6, 6);
            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-30} {4,-10} {5,-10}", "Canh ma", "Canh mb", "Canh mc", "Kieu tam giac", "Chu vi", "Dien tich");
            tg1.HienthiHinhTamGiac();
            tg2.HienthiHinhTamGiac();
            tg3.HienthiHinhTamGiac();
            tg4.HienthiHinhTamGiac();
            tg5.HienthiHinhTamGiac();
        }

    }

}