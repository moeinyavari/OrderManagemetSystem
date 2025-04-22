namespace OrderManagemetSystem.Models
{
	public class OrderDetailDto
	{
		public int ProductId { get; set; }

		public string ProductName { get; set; }

		public string ProductCode { get; set; }

		public decimal Price { get; set; }

		public int Count { get; set; }

		public decimal SumPrice { get; set; }
	}
}
