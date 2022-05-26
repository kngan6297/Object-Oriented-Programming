using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_Vehicle
{
    public class VehicleMain
    {
        static void Main(String[] args)
        {
            Vehicle xe1 = new Vehicle("Nguyen Thu Loan", "Future Neo", 100, 35000000);
            Vehicle xe2 = new Vehicle("Le Minh Tinh", "Ford Ranger", 3000, 250000000);
            Vehicle xe3 = new Vehicle("Nguyen Minh Triet", "Landscape", 1500, 1000000000);
            Console.WriteLine("{0,-20} {1,-20} {2,10} {3,20} {4,20}", "Ten chu xe", "Loai xe", "Dung tich", "Tri gia", "Thue phai nop");
            Console.WriteLine("==============================================================================================");
            xe1.HienthiXe();
            xe2.HienthiXe();
            xe3.HienthiXe();
        }
    }
}