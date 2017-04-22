using System;
using System.Collections.Generic;
using System.Text;
using TestingTesting.Domain;

namespace TestingTesting.Core.Abstractions.Data
{
    public interface IOrderRepo
    {
        Order GetOrder(int id);

    }
}
