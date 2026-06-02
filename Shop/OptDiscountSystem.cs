namespace Shop
{
    /// <summary>
    /// Вычисляет сумму скидки на позицию, если его количество больше 1
    /// </summary>
    internal class OptDiscountSystem : IDiscountSystem
    {
        public decimal getDiscount(Order order)
        {
            var discount = 0m;

            foreach (var item in order.Items)
            {
                if (item.Amount > 1)
                {
                    discount += item.ItemSum * 0.05m;
                }
            }

            return discount;
        }
    }
}
