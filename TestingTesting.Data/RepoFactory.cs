using System;
using TestingTesting.Core.Abstractions.Data;
namespace TestingTesting.Data
{
    public static class RepoFactory
    {

        public static IOrderRepo GetOrderRepo()
        {
            return new OrderRepo();
        }

        public static IDetailsRepo GetDetailsRepo()
        {
            return new DetailsRepo();
        }

    }
}
