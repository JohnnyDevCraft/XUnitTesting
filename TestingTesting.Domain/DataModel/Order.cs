using System;
using System.Collections.Generic;
using System.Text;

namespace TestingTesting.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
		public string AddressStreet1 { get; set; }
		public string AddressStreet2 { get; set; }
		public string AddressCity { get; set; }
		public string AddressState { get; set; }
		public string AddressPostalCode { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
        public decimal SubTotal { get; set; }
        public decimal SalesTax { get; set; }
        public decimal Shipping { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }

        public virtual List<Detail> Details { get; set; }
    }
}
