using System;
using System.Collections.Generic;
using System.Text;
using TestingTesting.Domain;

namespace TestingTesting.Tests
{
    public static class DetailFactory
    {
        public static Detail Valid_GenTax_Small()
        {
            return new Detail()
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

        public static Detail Valid_GenTax_Med()
        {
            return new Detail()
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
