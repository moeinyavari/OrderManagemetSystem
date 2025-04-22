using OrderManagemetSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagemetSystem.Services
{
	public static class CustomersService
	{
		public static List<CustomersListDto> GetCustomers()
		{
			using (DbEntities db = new DbEntities())
			{
				var result = db.Customers.Select(x => new CustomersListDto()
				{
					CustomerId = x.Id,
					CustomerName = x.Name
				}).ToList();

				return result;
			}
		}
	}
}
