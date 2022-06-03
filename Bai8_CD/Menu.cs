using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_CD
{
    public class Menu
    {
        string[] hints;
        int n = 0;
        public Menu(int size)
        {
            if (size < 1)
            {
                size = 10;
            }
            hints = new string[size];
        }
        public void add(string aHint)
        {
            if (n < hints.Length)
            {
                hints[n++] = aHint;
            }
        }
        public int getChoice()
        {
            int result = 0;
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine((i + 1) + "-" + hints[i]);
                }
                Console.WriteLine("Chọn menu: ");
                result = Convert.ToInt32(Console.ReadLine());
            }
            return result;
        }
    }
}
