using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchingExceptions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Boolean cont = true;
            int n = 0;
            do
            {
                try
                {
                    Console.WriteLine("Nhập vào số n: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    cont = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Yêu cầu số nguyên!");
                }
            }
            while (cont == true || n < 0 || n > 10);
        }
    }
}