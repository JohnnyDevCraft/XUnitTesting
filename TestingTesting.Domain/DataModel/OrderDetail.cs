using System;
using System.Collections.Generic;
using System.Text;

namespace TestingTesting.Domain
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Descr { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public bool FoodTaxed { get; set; }
        public bool GeneralTaxed { get; set; }

    }
}
