using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class DiscountedProduct : Product
    {
        private decimal _discount;

        public decimal Discount
        {
            get => _discount;
            set => _discount = value;
        }

        public decimal DiscouontedPrice
        {
            get => Price * (1 - _discount / 100);
        }
        public override string ToString()
        {
            var line = $"""
                Название: {Title}
                Произоводитель: {ManufacturerName}
                Цена: {Price}
                Дата изготовления: {ProductionDate.ToString("dd-MM-yyyy")}
                Срок годности: {ExpirationDate.ToString("dd-MM-yyyy")}
                Скидка: {Discount}%
                Цена со скидкой: {DiscouontedPrice}
                """;
            return line;
        }
    }
}
