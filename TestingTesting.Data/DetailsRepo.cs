using System;
using System.Collections.Generic;
using TestingTesting.Core.Abstractions.Data;
using TestingTesting.Domain;

namespace TestingTesting.Data
{
	public class DetailsRepo : IDetailsRepo
	{
		public DetailsRepo() { }

		AppContext _db;

		public Detail CreateDetail(Detail detail)
		{
			throw new NotImplementedException();
		}

		public Detail DeleteOrder(int id)
		{
			throw new NotImplementedException();
		}

		public Detail GetDetail(int id)
		{
			throw new NotImplementedException();
		}

		public List<Detail> GetDetails()
		{
			throw new NotImplementedException();
		}

		public List<Detail> GetDetails(int page, int count)
		{
			throw new NotImplementedException();
		}

		public Detail UpdateDetail(Detail updated)
		{
			throw new NotImplementedException();
		}
	}
}
