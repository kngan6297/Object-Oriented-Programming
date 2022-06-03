using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;

namespace Bai6_Account
{
    public class Account
    {
        private long accountNumber;
        private string name;
        private double balance;
        private readonly double RATE = 0.035;
        //constructor
        public Account()
        {
            balance = 50000;
        }
        public Account(long accNumber, string name, double balance)
        {
            this.accountNumber = accNumber;
            this.name = name;
            this.balance = balance;
        }
        public Account(long accNumber, string name)
        {
            this.accountNumber = accNumber;
            this.name = name;
        }
        //getter
        public long getAccountNumber()
        {
            return accountNumber;
        }
        public string getBalance()
        {
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            return String.Format(info, "{0:C}", this.balance);
        }
        //methods
        public Boolean deposit(double amount)
        {
            if(amount < 0)
            {
                throw new Exception("Gửi tiền thất bại!");
            }
            else
            {
                balance += amount;
                return true;
            }            
        }
        public Boolean withdraw(double amount, double fee)
        {
            if (amount < 0 || (amount + fee) >= balance)
            {
                throw new Exception("Rút tiền thất bại!");
            }
            else
            {
                balance = balance - (amount + fee);
                return true;
            }
        }
        public void addInterest()
        {
            balance = balance + (balance * RATE);
        }
        public void transfer(Account acc2, double amount, double fee)
        {
            try
            {
                this.withdraw(amount, fee);
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi!");
            }
            try
            {
                acc2.deposit(amount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi!");
            }
        }
        public string toString()
        {
            var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            return String.Format("{0,-20} {1,-20} {2,-20}", this.accountNumber, this.name, String.Format(info, "{0:C}", this.balance));
        }
    }
}
