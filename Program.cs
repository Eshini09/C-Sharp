using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03Q3
{
    using System;

    class Product
    {

        private int productId;
        private string productName;
        private double price;
        private int quantityInStock;

        public Product(int productId, string productName, double price, int quantityInStock)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.quantityInStock = quantityInStock;
        }

        public void AddProduct()
        {
            Console.WriteLine("Product added to inventory.");
        }

        public void BuyProduct()
        {
            if (quantityInStock > 0)
            {
                Console.WriteLine($"Product purchased: {productName}");
                quantityInStock--;
            }
            else
            {
                Console.WriteLine("Product out of stock.");
            }
        }

        public void DisplayProductName()
        {
            Console.WriteLine($"Product Name: {productName}");
        }

        public void DisplayProductPrice()
        {
            Console.WriteLine($"Product Price: ${price}");
        }

        public void DisplayQuantityInStock()
        {
            Console.WriteLine($"Quantity in Stock: {quantityInStock}");
        }
    }

    class Program
    {
        static void Main()
        {
            Product laptop = new Product(101, "Laptop", 800, 10);

            laptop.DisplayProductName();
            laptop.DisplayProductPrice();
            laptop.DisplayQuantityInStock();


            laptop.BuyProduct();
            laptop.DisplayQuantityInStock();

            Console.ReadLine();
        }
    }

}
