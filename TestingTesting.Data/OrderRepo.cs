using System;
using System.Collections.Generic;
using TestingTesting.Core.Abstractions.Data;
using TestingTesting.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TestingTesting.Data
{
    public class OrderRepo : IOrderRepo
    {
        public OrderRepo()
        {
        }

        AppContext _db;

        public Order CreateOrder(Order order)
        {
            _db.Orders.Add(order);
            _db.SaveChanges();
            return order;
        }

        public Order DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders(string customer)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders(int page, int count)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders(string customer, int page, int count)
        {
            throw new NotImplementedException();
        }

        public Order UpdateOrder(Order updated)
        {
            throw new NotImplementedException();
        }
    }
}
