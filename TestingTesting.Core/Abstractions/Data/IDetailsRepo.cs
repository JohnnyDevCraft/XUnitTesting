using System;
using System.Collections.Generic;
using TestingTesting.Domain;

namespace TestingTesting.Core.Abstractions.Data
{
    public interface IDetailsRepo
    {
		Detail CreateDetail(Detail detail);
		Detail DeleteOrder(int id);
		Detail GetDetail(int id);
		List<Detail> GetDetails();
		List<Detail> GetDetails(int page, int count);
		Detail UpdateDetail(Detail updated);
    }
}
