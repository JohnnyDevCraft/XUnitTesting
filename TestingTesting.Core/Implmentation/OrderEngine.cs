using System;
using System.Collections.Generic;
using System.Text;
using TestingTesting.Core.Domain;

namespace TestingTesting.Core.Implmentation
{
    public static class OrderEngine
    {
        public static void ProcessOrder(this Order order)
        {
            //Validate Order
            if (order == null) throw new ArgumentNullException("Cannot process a null order.");
            if (string.IsNullOrWhiteSpace(order.Customer)) throw new ArgumentException("The order must have a customer associated.");
            if (order.Details == null || order.Details.Count < 1) throw new ArgumentNullException("This order has no details.");

            //Validate OrderItems
            foreach(var detail in order.Details)
            {
                if (detail.Id < 1) throw new ArgumentException("Invalid Sku ID for Item on order.");
                if (detail.Price < .01M) throw new ArgumentException("Item Minimum price should always be $0.01.");
                if (detail.Quantity <= 0) throw new ArgumentException("Invalid Quantity for item.");
            }

            //Set Subtotal
            order.SubTotal = 0M;

            foreach(var item in order.Details)
            {
                order.SubTotal += item.Price * item.Quantity;
            }

            //Set Tax
            order.SalesTax = 0M;

            foreach(var item in order.Details)
            {
                var ft = item.FoodTaxed ? (item.Price * item.Quantity) * .0127M : 0.00M;
                var gt = item.GeneralTaxed ? (item.Price * item.Quantity) * .0524M : 0.00M;
                order.SalesTax += (ft + gt);
            }

            //Set Discounts

            var discount = 0M;

            if (order.Customer == "John Smith") discount += .05M;
            if (order.Details.Count > 10) discount += 0.05M;
            if (order.SubTotal > 100) discount += 0.1M;
            order.Discount = order.SubTotal * discount;

            //Calculate Total
            order.Total = order.SubTotal + order.SalesTax - order.Discount;


        }
    }
}
