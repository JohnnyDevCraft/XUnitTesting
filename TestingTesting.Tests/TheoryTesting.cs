using System;
using Xunit;
using Xunit.Extensions;
using TestingTesting.Core.Implmentation;
using TestingTesting.Core.Domain;
using System.Collections.Generic;

namespace TestingTesting.Tests
{
    public class TheoryTesting
    {
        public List<object[]> TestProcessData
        {
            get
            {
                return new List<object[]>(){
                    new object[] {OrderFactory.ValidNoDiscountsNoTax(), 0.0M, 0.0M},
                    new object[] {OrderFactory.ValidNoDiscountsTax(), 0.0M, 0.086460M},
                    new object[] {OrderFactory.ValidNameDiscountTax(), 0.0825M, 0.086460M}
                };
            }
        }

        [Theory]
        [PropertyData("TestProcessData")]
        public void TestProcessOrder(Order order, decimal discount, decimal salesTax)
        {

            OrderEngine.ProcessOrder(order);

            Assert.Equal(discount, order.Discount);
            Assert.Equal(salesTax, order.SalesTax);
        }
    }
}
