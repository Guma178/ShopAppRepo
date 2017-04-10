using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    //comment
    class Shop
    {
        public string Name
        {
            get;
            set;
        }

        public string Adress
        {
            get;
            set;
        }

        public List<Product> Products
        {
            get;
        }

        public List<Customer> Customers
        {
            get;
        }

        public Shop(string adress, string name, List<Customer> customers = null, List<Product> products = null)
        {
            Products = new List<Product>();
            Customers = new List<Customer>();
            Adress = adress;
            Name = name;
            if (customers != null)
            {
                Customers = customers;
            }
            if (products != null)
            {
                Products = products;
            }
        }

        public bool Sell(Order order)
        {
            bool isOrderPossible = true;
            foreach (Product p in order.OrderedProducts)
            {
                if (Products.Find(pr => pr.Equals(p)) == null)
                {
                    isOrderPossible = false;
                }
            }

            if (isOrderPossible)
            {
                order.Buyer.MakeOrder(order);
            }

            return isOrderPossible;
        }
    }
}
