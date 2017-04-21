using System;
using System.Collections.Generic;
using System.Text;
using TestingTesting.Core.Domain;

namespace TestingTesting.Tests
{
    public static class OrderDetailFactory
    {
        public static OrderDetail Valid_GenTax_Small()
        {
            return new OrderDetail()
            {
                Id = 23323,
                Name = "Gold Bar",
                Descr = "Luxory Bath Bar",
                Price = 1.65M,
                Quantity = 12M,
                GeneralTaxed = true,
                FoodTaxed = false
            };
        }

        public static OrderDetail Valid_GenTax_Med()
        {
            return new OrderDetail()
            {
                Id = 23323,
                Name = "",
                Descr = "Luxory Bath Bar",
                Price = 1.65M,
                Quantity = 12M,
                GeneralTaxed = true,
                FoodTaxed = false
            };
        }
    }
}
