using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7_ToaDoHinhTron
{
    public class ToaDoHinhTron
    {
        static void Main(String[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HinhTron hinhTron = new HinhTron(new ToaDo("O", 5, 5), 10.5);
            Console.WriteLine(hinhTron.toString());            
        }
    }
}