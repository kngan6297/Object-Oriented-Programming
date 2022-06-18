using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Demo_1
    {
        public static void Main(String[] args)
        {
            Rectangle r = new Rectangle(2, 5);
            Console.WriteLine("Rectangle: " + r.toString());
            Console.WriteLine("   Area: " + r.area());
            Box b = new Box(2, 2, 2);
            Console.WriteLine("Box: " + b.toString());
            Console.WriteLine("   Area: " + b.area());
            Console.WriteLine("   Volumn: " + b.volumn());
        }
    }
}