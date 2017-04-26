using System;
using System.Collections.Generic;
using System.Text;
using TestingTesting.Core.Domain;

namespace TestingTesting.Tests
{
    public static class OrderFactory
    {
        public static Order ValidNoDiscountsNoTax()
        {
            var order = new Order()
            {
                Id = 1001,
                Customer = "Jim Kirk"
            };

            order.Details = new List<OrderDetail>();
            order.Details.Add(OrderDetailFactory.Valid_NoTax_Small(1));
            return order;
        }

        public static Order ValidNoDiscountsTax()
        {
            var order = new Order()
            {
                Id = 1001,
                Customer = "Jim Kirk"
            };

            order.Details = new List<OrderDetail>();
            order.Details.Add(OrderDetailFactory.Valid_GenTax_Small(1));
            return order;
        }

        public static Order ValidNameDiscountNoTax()
        {
            var order = new Order()
            {
                Id = 1001,
                Customer = "John Smith"
            };

            order.Details = new List<OrderDetail>();
            order.Details.Add(OrderDetailFactory.Valid_NoTax_Small(1));
            return order;
        }

        public static Order ValidNameDiscountTax()
        {
            var order = new Order()
            {
                Id = 1001,
                Customer = "John Smith"
            };

            order.Details = new List<OrderDetail>();
            order.Details.Add(OrderDetailFactory.Valid_GenTax_Small(1));
            return order;
        }

        public static Order InValidNoCustomer()
        {
            var order = new Order()
            {
                Id = 1001,
            };

            order.Details = new List<OrderDetail>();
            order.Details.Add(OrderDetailFactory.Valid_FoodTax_Med(1));
            return order;
        }

        public static Order InvalidNoItems()
        {
            var order = new Order()
            {
                Id = 1001,
                Customer = "John Smith"
            };

            order.Details = new List<OrderDetail>();
            return order;
        }

        public static Order InvalidNullItems()
        {
            var order = new Order()
            {
                Id = 1001,
                Customer = "John Smith"
            };

            return order;
        }

        public static Order InvalidItemsZeroQnty()
        {
            var order = new Order()
            {
                Id = 1001,
                Customer = "John Smith"
            };

            order.Details = new List<OrderDetail>();
            order.Details.Add(OrderDetailFactory.Valid_NoTax_Small(0));
            return order;
        }

    }
}
