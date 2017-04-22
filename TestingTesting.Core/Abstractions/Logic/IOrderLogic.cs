using System;
using TestingTesting.Domain;
using System.Collections.Generic;
namespace TestingTesting.Core.Abstractions
{
	public interface IOrderLogic
	{
        Order GetOrder(int id);
        List<Order> GetOrders(int page = 0, int count = 0);
        List<Order> GetOrdersForCustomer(string customer, int page = 0, int count = 0);
        Order CreateOrder(Order order);
        Order UpdateOrder(Order order);
        bool DeleteOrder(int id);
	}
}
