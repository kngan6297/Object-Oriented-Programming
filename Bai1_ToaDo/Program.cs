using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_ToaDo
{
    public class Program
    {
        static void Main(string[] args)
        {
            ToaDo toaDo1 = new ToaDo(1,1, "A");
            Console.WriteLine(toaDo1.toString());
        }
    }
}
