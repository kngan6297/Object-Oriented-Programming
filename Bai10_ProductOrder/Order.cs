using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_ProductOrder
{
    public class Order:Product
    {
        private int orderID;
        private DateTime orderDate;
        private OrderDetail[] lineItems;
        private int count;
        public void addLineItem(Product product, int quantity)
        {
            if (count == lineItems.Length)
            {
                return;
            }                
            lineItems[count++] = new OrderDetail(product, quantity);
        }
        public double calcTotalCharge()
        {
            double totalCharge = 0;
            for (int i = 0; i < count; i++)
            {
                totalCharge += lineItems[i].calcTotalPrice();
            }
            return totalCharge;
        }
        public string toString()
        {
            string str = "Mã HĐ " + getProductID();
            str += "\nNgày lập hóa đơn: " + orderDate + "\n";
            str += String.Format("{0,5} | {1,5} | {2,10}| {3,20:#,##0.00} | {4,3} | {5,20:#,##0.00}\n", "STT", "Mã SP", "Mô tả", "Đơn giá", "S Lượng", "Thành tiền");
            for (int i = 0; i < count; i++) str += String.Format(lineItems[i].ToString() + "\n");
            str += String.Format("Tổng tiền thanh toán: {0,15:#,##0.00} VND", calcTotalCharge());
            return str;
        }
        public Order(int orderID, DateTime orderDate)
        {
            this.orderID = orderID;
            this.orderDate = orderDate;
        }
        public OrderDetail[] getLineItems()
        {
            return lineItems;
        }
        public DateTime getOrderDate()
        {
            return orderDate;
        }
        public int getOrderID()
        {
            return orderID;
        }
        public void setOrderDate(DateTime orderDate)
        {
            this.orderDate = orderDate;
        }
    }
}
