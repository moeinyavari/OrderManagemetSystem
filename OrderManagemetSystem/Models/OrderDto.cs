using System;
using System.Collections.Generic;

namespace OrderManagemetSystem.Models
{
	public class OrderDto
	{
		public int OrderId { get; set; }

		public string OrderNumber { get; set; }

		public int CustomerId { get; set; }

		public DateTime Date { get; set; }

		public List<OrderDetailDto> OrderDetails { get; set; }
	}
}
