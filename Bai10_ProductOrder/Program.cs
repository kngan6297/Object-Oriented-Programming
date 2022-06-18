using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_ProductOrder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product sp1 = new Product("Gạo", "sp1", 18000);
            Product sp3 = new Product("Đường", "sp3", 10000);
            Product sp4 = new Product("Nước tương", "sp4", 8000);

            Order order = new Order();
            order.addLineItem(sp4, 10);
            order.addLineItem(sp1, 5);
            order.addLineItem(sp3, 1);
            order.addLineItem(sp1, 1);

            Console.WriteLine(order.ToString());
        }
}