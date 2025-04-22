namespace OrderManagemetSystem.Models
{
	public class OrdersListDto
	{
		public int OrderId { get; set; }

		public string OrderNumber { get; set; }

		public string CustomerName { get; set; }

		public string OrderDate { get; set; }

		public string SumPrice { get; set; }
	}
}
