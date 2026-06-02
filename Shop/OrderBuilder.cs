using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class OrderBuilder
    {
        private Order _order;
        public OrderBuilder()
        {
            _order = new Order()
            {
                Created = DateTime.Now,

            };
        }

        public OrderBuilder ForClient(Client client)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            _order.Client = client;
            return this;
        }

        public OrderBuilder WithItems(List<OrderItem> orderItems)
        {
            _order.Items = orderItems;
            
            return this;
        }

        public OrderBuilder WithDiscount(IDiscountSystem discountSystem)
        {
            _order.DiscountSystem = discountSystem;

            return this;
        }

        public Order Build()
        {
            if (_order.Client == null)
            {
                throw new ArgumentNullException(nameof(_order.Client));
            }
            if (_order.Items == null)
            {
                throw new ArgumentNullException(nameof(_order.Items));
            }

            return _order;
        }
    }
}
