namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client leo = new Client()
            {
                Name = "Leonid",
                Phone = "812345678"
            };

            var banana = new Product()
            {
                Price = 50m,
                Ttile = "Banana"
            };
            var pineapple = new Product()
            {
                Price = 70m,
                Ttile = "Pineapple"
            };

            var bananaOrderItem = new OrderItem() {Product = banana, Amount = 2}; 
            var pineappleOrderItem = new OrderItem() {Product = pineapple, Amount = 1};

            var itemList = new List<OrderItem> { bananaOrderItem, pineappleOrderItem };

            var leoOrder = new OrderBuilder()
                .ForClient(leo)
                .WithItems(itemList)
                .Build();


            var vasyaBuilder = new OrderBuilder()
                .ForClient(leo)
                .WithItems(itemList);
            if (1 == 2)
            {
                vasyaBuilder.WithDiscount(new OptDiscountSystem());
            }
            Order vasyaOrder = vasyaBuilder.Build();
            //var leoOrder = new Order()
            //{
            //    Client = leo,
            //    Created = DateTime.Now,
            //    Items = new List<OrderItem> { bananaOrderItem, pineappleOrderItem },
            //    DiscountSystem = new OptDiscountSystem()
            //};
            Console.WriteLine(leoOrder);

            Console.WriteLine(vasyaOrder);

        }
    }
}
