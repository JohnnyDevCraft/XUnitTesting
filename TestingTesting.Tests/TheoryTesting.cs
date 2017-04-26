using System;
using Xunit;
using Xunit.Extensions;
using TestingTesting.Core.Implmentation;
using TestingTesting.Core.Domain;
using System.Collections.Generic;
using System.Reflection;

namespace TestingTesting.Tests
{
    public class TheoryTesting
    {
        public static List<object[]> TestProcessData()
        {
            return new List<object[]>(){
                new object[] {OrderFactory.ValidNoDiscountsNoTax(), 0.0M, 0.0M},
                new object[] {OrderFactory.ValidNoDiscountsTax(), 0.0M, 0.086460M},
                new object[] {OrderFactory.ValidNameDiscountTax(), 0.0825M, 0.086460M}
            };

        }

        [Theory]
        [MemberData(nameof(TestProcessData))]
        public void TestProcessOrder(Order order, decimal discount, decimal salesTax)
        {

            OrderEngine.ProcessOrder(order);

            Assert.Equal(discount, order.Discount);
            Assert.Equal(salesTax, order.SalesTax);
        }

        public static List<object[]> ValidationTestData()
        {
            return new List<object[]>(){
                new object[] {OrderFactory.ValidNoDiscountsNoTax(), false, false},
                new object[] {OrderFactory.InValidNoCustomer(), true, false},
                new object[] {OrderFactory.InvalidNullItems(), true, true},
                new object[] {OrderFactory.InvalidNoItems(), true, true},
                new object[] {OrderFactory.InvalidItemsZeroQnty(), false, false},
                new object[] {null, true, true}

            };

        }

        [Theory,
         MemberData(nameof(ValidationTestData))]
        public void TestValidationForOrders(Order order, bool ExpectException, bool nullEx)
        {
            var method = Type.GetType("TestingTesting.Core.Implmentation.OrderEngineSpecialized, TestingTesting.Core", true, true)
                             .GetMethod("ValidateOrder", BindingFlags.Static | BindingFlags.NonPublic);
            if (ExpectException && nullEx)
            {
                var ex = Assert.Throws<TargetInvocationException>(() => { method.Invoke(obj: null, parameters: new object[] { order }); });
                Assert.IsType<ArgumentNullException>(ex.InnerException);
            }
            else if (ExpectException && !nullEx)
            {
                var ex = Assert.Throws<TargetInvocationException>(() => { method.Invoke(obj: null, parameters: new object[] { order }); });
                Assert.IsType<ArgumentException>(ex.InnerException);
            }
            else
            {
                method.Invoke(null, new object[] { order });
            }
        }

        [Theory,
         MemberData(nameof(ValidationTestData))]
        public void TestValidationForOrdersInLargeProcess(Order order, bool ExpectException, bool nullEx)
        {

            if (ExpectException && nullEx)
            {
                var ex = Assert.Throws<ArgumentNullException>(() => { OrderEngine.ProcessOrder(order); });
            }
            else if (ExpectException && !nullEx)
            {
                var ex = Assert.Throws<ArgumentException>(() => { OrderEngine.ProcessOrder(order); });
            }
            else
            {
                OrderEngine.ProcessOrder(order);
            }
        }
    }
}
