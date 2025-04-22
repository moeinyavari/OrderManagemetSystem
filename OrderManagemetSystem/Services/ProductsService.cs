using OrderManagemetSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagemetSystem.Services
{
	public static class ProductsService
	{
		public static List<ProductListDto> GetProducts()
		{
			using (DbEntities db = new DbEntities())
			{
				var result = db.Products
					.Select(x => new ProductListDto()
					{
						Code = x.Code,
						Name = x.Name,
						Price = x.Price,
						ProductId = x.Id
					}).ToList();

				return result;
			}
		}
	}
}
