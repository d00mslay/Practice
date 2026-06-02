using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
    public class PersistentClientDiscount : IDiscountSystem
    {
        public decimal getDiscount(Order order)
        {
            return order.Total * 0.1m;
        }
    }
}