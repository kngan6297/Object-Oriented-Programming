using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_ProductOrder
{
    public class OrderDetail
    {
        private int quantity;
        private Product product;
        public double calcTotalPrice()
        {
            return quantity * product.getPrice();
        }
        public string toString()
        {
            return quantity.ToString();
        }
        public int getQuantity()
        {
            return this.quantity;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public OrderDetail(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
    }
}
