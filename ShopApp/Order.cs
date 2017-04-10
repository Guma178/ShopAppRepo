using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Order
    {
        public List<Product> OrderedProducts
        {
            get;
        }

        public bool IsComplited
        {
            get;
            set;
        }

        public Customer Buyer
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        public Order(DateTime date, Customer buyer, List<Product> orderedProducts = null)
        {
            OrderedProducts = new List<Product>();
            Buyer = buyer;
            Date = date;
            IsComplited = false;
            if (orderedProducts != null)
            {
                OrderedProducts = orderedProducts;
            }
        }

        public decimal SummaryPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach (Product p in OrderedProducts)
                {
                    totalPrice += p.Price;
                }
                return (totalPrice * Buyer.Discount);
            }
        }
    }
}
