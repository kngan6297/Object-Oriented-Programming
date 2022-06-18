using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList_BT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Point p = new Point(1, 2);
            Point p1 = new Point(3, 4);
            Point p2 = new Point(5, 6);
            Point p3 = new Point(7, 8);
            Point p4 = new Point(9, 10);
            Point p5 = new Point(11, 12);
            Point p6 = new Point(13, 14);
            Point p7 = new Point(15, 16);
            Point p8 = new Point(17, 18);
            Point p9 = new Point(19, 20);
            var arr = new List<Point>();
            arr.Add(p);
            arr.Add(p1);
            arr.Add(p2);
            arr.Add(p3);
            arr.Add(p4);
            arr.Add(p5);
            arr.Add(p6);
            arr.Add(p7);
            arr.Add(p8);
            arr.Add(p9);
            foreach (Point obj in arr)
                Console.WriteLine("{0}", obj.toString());
            arr.Sort();
            Console.WriteLine("After sorting:");
            foreach (Point obj in arr)
                Console.WriteLine("{0}", obj.toString());
        }
    }
}
