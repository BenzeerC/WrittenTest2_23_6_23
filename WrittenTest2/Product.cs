using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrittenTest2
{
    //Create class Product. Add fields like id, name and price. Create properties for each field.
    //Use object initializer syntax initialize the object.
    //Print product details using ToString()
    public class Product
    {
        private int productId, productPrice;
        private string productName;

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

        public override string ToString()
        {
            return $"Product Id:{productId}\nProduct Name:{productName}\nProduct Price:{productPrice}"; 
        }

        public static void Main(string[] args)
        {
            Product product = new Product
            {
                productId = 56324789,
                productName = "Sony TV",
                productPrice = 890000
            };
            new Product
            { 
                productId = 6348975,
                productName = "Lenovo Laptops", 
                productPrice = 560000
            };
            
            
            
            Console.WriteLine(product.ToString());
            Console.WriteLine(product.ToString());
        }
    }
}
