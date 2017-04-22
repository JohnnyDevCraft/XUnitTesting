using System;
using Xunit;
using TestingTesting.Core.Implmentation;

namespace TestingTesting.Tests
{
    public class OrderEngineTests
    {
        [Fact]
        public void TestProcessOrder_NoDiscountsNoTax()
        {
            var order = OrderFactory.ValidNoDiscountsNoTax();
            OrderEngine.ProcessOrder(order);

            Assert.Equal(0.00M, order.Discount);
            Assert.Equal(0.00M, order.SalesTax);
        }

        [Fact]
        public void TestProcessOrder_NoDiscountsTax()
        {
            var order = OrderFactory.ValidNoDiscountsTax();
            OrderEngine.ProcessOrder(order);

            Assert.Equal(0.00M, order.Discount);
            Assert.Equal(0.086460M, order.SalesTax);
        }

        [Fact]
        public void TestProcessOrder_DiscountsAndTax()
        {
            var order = OrderFactory.ValidNameDiscountTax();
            OrderEngine.ProcessOrder(order);

            Assert.Equal(0.0825M, order.Discount);
            Assert.Equal(0.086460M, order.SalesTax);
        }


    }
}
