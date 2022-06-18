using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_ProductOrder
{
    public class Product
    {
        private string description;
        private string productID;
        private double price;

        public string toString()
        {
            return String.Format("{0,5} | {1,20} | {2,15:#,##0.00}", productID, description, price);
        }
        public Product()
        {

        }
        public Product(string description, string productID, double price)
        {
            this.description = description;
            this.productID = productID;
            this.price = price;
        }
        public string getDescription()
        {
            return description;
        }
        public string getProductID()
        {
            return productID;
        }
        public double getPrice()
        {
            return price;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
        public void setProductID(string productID)
        {
            this.productID = productID;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
    }
}
