using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{ 
    class Product
    {
        public string Name
        {
            get;
            set;
        }

        public decimal Price
        {
            get;
            set;
        }

        public Product(decimal price, string name)
        {
            Price = price;
            Name = name;
        }

        public override bool Equals(object obj)
        {
            Product prod;
            if (obj is Product)
            {
                prod = obj as Product;
                if (prod.Name == this.Name && prod.Price == this.Price)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
