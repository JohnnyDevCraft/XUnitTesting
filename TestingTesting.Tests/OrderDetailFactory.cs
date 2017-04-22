using System;
using System.Collections.Generic;
using System.Text;
using TestingTesting.Core.Domain;

namespace TestingTesting.Tests
{
    public static class OrderDetailFactory
    {
        public static OrderDetail Valid_GenTax_Small(int qnty)
        {
            return new OrderDetail()
            {
                Id = 23323,
                Name = "Gold Bar",
                Descr = "Luxory Bath Bar",
                Price = 1.65M,
                Quantity = qnty,
                GeneralTaxed = true,
                FoodTaxed = false
            };
        }

        public static OrderDetail Valid_GenTax_Med(int qnty)
        {
            return new OrderDetail()
            {
                Id = 36556,
                Name = "",
                Descr = "T36 Oil 1 Ounce",
                Price = 13.65M,
                Quantity = qnty,
                GeneralTaxed = true,
                FoodTaxed = false
            };
        }

        public static OrderDetail Valid_GenTax_Big(int qnty)
        {
            return new OrderDetail()
            {
                Id = 14552,
                Name = "",
                Descr = "Vitality Pack",
                Price = 133.95M,
                Quantity = qnty,
                GeneralTaxed = true,
                FoodTaxed = false
            };
        }

        public static OrderDetail Valid_FoodTax_Small(int qnty)
        {
            return new OrderDetail()
            {
                Id = 23323,
                Name = "Gold Bar",
                Descr = "Luxory Bath Bar",
                Price = 1.65M,
                Quantity = qnty,
                GeneralTaxed = false,
                FoodTaxed = true
            };
        }

        public static OrderDetail Valid_FoodTax_Med(int qnty)
        {
            return new OrderDetail()
            {
                Id = 36556,
                Name = "",
                Descr = "T36 Oil 1 Ounce",
                Price = 13.65M,
                Quantity = qnty,
                GeneralTaxed = false,
                FoodTaxed = true
            };
        }

        public static OrderDetail Valid_FoodTax_Big(int qnty)
        {
            return new OrderDetail()
            {
                Id = 14552,
                Name = "",
                Descr = "Vitality Pack",
                Price = 133.95M,
                Quantity = qnty,
                GeneralTaxed = false,
                FoodTaxed = true
            };
        }

        public static OrderDetail Valid_NoTax_Small(int qnty)
        {
            return new OrderDetail()
            {
                Id = 23323,
                Name = "Gold Bar",
                Descr = "Luxory Bath Bar",
                Price = 1.65M,
                Quantity = qnty,
                GeneralTaxed = false,
                FoodTaxed = false
            };
        }

        public static OrderDetail Valid_NoTax_Med(int qnty)
        {
            return new OrderDetail()
            {
                Id = 36556,
                Name = "",
                Descr = "T36 Oil 1 Ounce",
                Price = 13.65M,
                Quantity = qnty,
                GeneralTaxed = false,
                FoodTaxed = false
            };
        }

        public static OrderDetail Valid_NoTax_Big(int qnty)
        {
            return new OrderDetail()
            {
                Id = 14552,
                Name = "",
                Descr = "Vitality Pack",
                Price = 133.95M,
                Quantity = qnty,
                GeneralTaxed = false,
                FoodTaxed = false
            };
        }
    }
}
