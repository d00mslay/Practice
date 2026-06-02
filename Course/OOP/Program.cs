namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle {X = 1, Y = 2, Width = 3, Height = 2};

            Console.WriteLine(rect);
            Console.WriteLine($"Площадь: {rect}");
            Console.WriteLine($"Периметр: {rect}");

            Console.Write("Название товара: ");
            string title = Console.ReadLine();
            Console.Write("Производитель товара: ");
            string manufacturerName = Console.ReadLine();
            Console.Write("Цена товара: ");
            decimal price = Decimal.Parse(Console.ReadLine());
            Console.Write("Дата производства (дд-ММ-гггг): ");
            DateTime productionDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Срок годности (дд-ММ-гггг): ");
            DateTime expirationDate = DateTime.Parse(Console.ReadLine());

            var product = new Product
            {
                Title = title,
                ManufacturerName = manufacturerName,
                Price = price,
                ProductionDate = productionDate,
                ExpirationDate = expirationDate
            };
            Console.WriteLine(product);

            Console.Write("Название товара: ");
            title = Console.ReadLine();
            Console.Write("Производитель товара: ");
            manufacturerName = Console.ReadLine();
            Console.Write("Цена товара: ");
            price = Decimal.Parse(Console.ReadLine());
            Console.Write("Дата производства (дд-ММ-гггг): ");
            productionDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Срок годности (дд-ММ-гггг): ");
            expirationDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Скидка в %: ");
            var discount = Decimal.Parse(Console.ReadLine());

            var discounedProduct = new DiscountedProduct
            {
                Title = title,
                ManufacturerName = manufacturerName,
                Price = price,
                ProductionDate = productionDate,
                ExpirationDate = expirationDate,
                Discount = discount
            };
            Console.WriteLine(discounedProduct);

        }
    }
}
