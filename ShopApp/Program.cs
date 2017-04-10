using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Shop shop = new Shop("shop#1", "Moscow, Pushkin str.");
            shop.Products.Add(new Product(10M, "chess"));
            shop.Products.Add(new Product(12M, "chair"));

            shop.Customers.Add(new Customer("Pavel P. P.", "Moscow 11 -22", 231243));

            List<Product> wishList = new List<Product>();
            wishList.Add(new Product(10M, "chess"));

            Customer customer = shop.Customers.Find(c => c.FullName == "Pavel P. P.");

            if (customer != null)
            {
                if (shop.Sell(new Order(DateTime.Now, customer, wishList)))
                {
                    Console.WriteLine("Order is maked");
                }
                else
                {
                    Console.WriteLine("Order cannot be completed");
                }
            }

            Console.ReadLine();
        }
    }
}
