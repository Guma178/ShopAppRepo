using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Customer
    {
        List<Order> orders;

        public string FullName
        {
            get;
            set;
        }

        public string Adress
        {
            get;
            set;
        }

        public int PhoneNumber
        {
            get;
            set;
        }

        public decimal Discount
        {
            get;
            private set;
        }

        decimal totalPrice; 

        const decimal discountLevel = 900M;

        public Customer(string fullName, string adress, int phoneNumber)
        {
            this.orders = new List<Order>();
            totalPrice = 0;
            Discount = 1;
            FullName = fullName;
            Adress = adress;
            PhoneNumber = phoneNumber;
        }

        public void MakeOrder(Order order)
        {
            orders.Add(order);
            totalPrice += order.SummaryPrice;
            if (totalPrice >= discountLevel)
            {
                Discount = 0.8M;
            }
        }
    }
}
