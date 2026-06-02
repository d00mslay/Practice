using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
    public class Order
    {
        public int Id
        {
            get; set;
        }

        public System.DateTime Created
        {
            get; set;
        }

        public Client Client
        {
            get; set;
        }

        public decimal Total
        {
            get {
                var orderSum = 0m;

                foreach (var item in Items)
                {
                    orderSum += item.ItemSum;
                }

                return orderSum;
            }
        }

        public IDiscountSystem DiscountSystem
        {
            get; set;
        }

        public Delivery Delivery
        {
            get; set;
        }

        public System.Collections.Generic.List<OrderItem> Items
        {
            get; set;
        }

        public override string ToString()
        {
            return $"Заказ от {Created} для {Client} на сумму {Total}";
        }
    }
}