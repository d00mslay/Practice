using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
    public class Product
    {
        public string Ttile
        {
            get; set;
        }

        public decimal Price
        {
            get; set;
        }

        public int Id
        {
            get; set;
        }

        public Category Category
        {
            get; set;
        }

        public string Brand
        {
            get; set;
        }
    }
}