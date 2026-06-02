using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
    public class OrderItem
    {
        public Order Order
        {
            get; set;
        }

        public int Amount
        {
            get; set;

        }

        public Product Product
        {
            get;
            set;
        }

        public decimal ItemSum
        {
            get => Product.Price * Amount;
        }
    }
}