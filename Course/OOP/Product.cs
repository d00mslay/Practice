using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Product
    {
        private string _title;
        private string _manufacturerName;
        private decimal _price;
        private DateTime _expirationDate;
        private DateTime _productionDate;

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string ManufacturerName
        {
            get => _manufacturerName;
            set => _manufacturerName = value;
        }

        public decimal Price
        {
            get => _price;
            set => _price = value;
        }

        public DateTime ExpirationDate
        {
            get => _expirationDate;
            set => _expirationDate = value;
        }

        public DateTime ProductionDate
        {
            get => _productionDate;
            set => _productionDate = value;
        }

        public override string ToString()
        {
            var line = $"""
                Название: {_title}
                Произоводитель: {_manufacturerName}
                Цена: {_price}
                Дата изготовления: {_productionDate.ToString("dd-MM-yyyy")}
                Срок годности: {_expirationDate.ToString("dd-MM-yyyy")}
                """;
            return line;
        }
    }
}
