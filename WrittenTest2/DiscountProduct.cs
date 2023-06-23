using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenTest2
{
    //Use above Product class, create Discount method & accept the discount percentage.
    //Give discount to the price & Display actual price & discounted price
    public class DiscountProduct
    {
        private int productId, productPrice;
        private string productName;
        private double productDiscount, productActualPrice, productDiscountedPrice;

        public int ProductId
        {
            set { productId = value; }
            get { return productId; }
        }
        public string ProductName
        {
            set { productName = value; }
            get { return productName; }
        }
        public int ProductPrice
        {
            set { productPrice = value; }
            get { return productPrice; }
        }

        public void Discount()
        {
            productDiscount = productActualPrice - productPrice;
            productDiscountedPrice = productDiscount / 100;
           // productActualPrice = productActualPrice - productPrice;
           
            productDiscountedPrice = productActualPrice - productDiscountedPrice;
        }

        public override string ToString()
        {
            return $"Product Id:{productId}\nProduct Name:{productName}\nActual Price:{productActualPrice}\nDiscounted Price:{productDiscountedPrice}";
        }

        public static void Main(string[] args)
        {
            DiscountProduct discountProduct = new DiscountProduct { productId=56427,productName="Laptop",productActualPrice = 50000,productPrice=45000 };
            discountProduct.Discount();
            Console.WriteLine(discountProduct.ToString());
        }
            
            



    }
}
