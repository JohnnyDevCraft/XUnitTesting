using System;
using System.Collections.Generic;
using TestingTesting.Domain;

namespace TestingTesting.Core.Abstractions.Validation
{
	public interface IOrderValidator
	{
		Order GetOrder(int id);
		Order CreateOrder(Order order);
		Order DeleteOrder(int id);
		List<Order> GetOrders();
		List<Order> GetOrders(string customer);
		List<Order> GetOrders(int page, int count);
		List<Order> GetOrders(string customer, int page, int count);
		Order UpdateOrder(Order updated);
	}
}
