using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;

namespace Bai6_Account
{
    public class AccountMain
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Account acc1 = new Account(72354, "Ted Murphy", 102.56);
            Account acc2 = new Account(69713, "Jane Smith", 40.00);
            Account acc3 = new Account(93757, "Edward Demsey", 759.32);
            //Gởi thêm số tiền cho acc1 là 25.85, cho acc2 là 500.00
            try
            {
                acc1.deposit(25.85);
                acc2.deposit(500.00);
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi!");
            }
            Console.WriteLine("//Gởi thêm số tiền cho acc1 là 25.85, cho acc2 là 500.00");
            Console.WriteLine("{0,-20} {1,-20} {2,-20}", "Account Number", "Name", "Balance");
            Console.WriteLine(acc1.toString());
            Console.WriteLine(acc2.toString());
            //Rút khỏi acc2 số tiền là 430.75, mức phí 1.50
            try
            {
                acc2.withdraw(430.75, 1.50);
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi!");
            }
            Console.WriteLine("\n//Rút khỏi acc2 số tiền là 430.75, mức phí 1.50");
            Console.WriteLine("{0,-20} {1,-20} {2,-20}", "Account Number", "Name", "Balance");
            Console.WriteLine(acc2.toString());
            //Tính tiền lãi cho acc3
            string temp;
            temp = acc3.getBalance();
            acc3.addInterest();
            Console.WriteLine("\n//Số tiền lãi acc3: " + acc3.getBalance());
            //Chuyển tiền từ acc2 sang cho acc1 số tiền là 100.00
            acc1.transfer(acc2, 100.00, 1.00);
            Console.WriteLine("\n//Chuyển tiền từ acc2 sang cho acc1 số tiền là 100.00");
            Console.WriteLine("{0,-20} {1,-20} {2,-20}", "Account Number", "Name", "Balance");
            Console.WriteLine(acc1.toString());
            Console.WriteLine(acc2.toString());
        }
    }
}