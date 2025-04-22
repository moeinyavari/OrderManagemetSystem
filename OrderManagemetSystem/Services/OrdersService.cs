using OrderManagemetSystem.Models;
using OrderManagemetSystem.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace OrderManagemetSystem.Services
{
	public static class OrdersService
	{
		public static List<OrdersListDto> GetOrders(DateTime fromDate, DateTime toDate, int customerId)
		{
			using (DbEntities db = new DbEntities())
			{
				var res = db.Orders
					.Where(x => x.Date >= fromDate && x.Date <= toDate && (x.CustomerId == customerId || customerId == 0))
					.OrderByDescending(x => x.Date)
					.AsEnumerable()
					.Select(x => new OrdersListDto
					{
						OrderId = x.Id,
						OrderNumber = x.Number,
						CustomerName = x.Customer.Name,
						OrderDate = x.Date.ToPersian(),
						SumPrice = x.OrderDetails.Sum(y => y.Price * y.Count).ToString("N0")
					}).ToList();

				return res;
			}
		}

		public static OrderDto GetOrderById(int orderId)
		{
			using (DbEntities db = new DbEntities())
			{
				var res = db.Orders
					.Where(x => x.Id == orderId)
					.Select(x => new OrderDto()
					{
						CustomerId = x.CustomerId,
						Date = x.Date,
						OrderNumber = x.Number,
						OrderDetails = x.OrderDetails.Select(y => new OrderDetailDto()
						{
							Count = y.Count,
							Price = y.Price,
							ProductCode = y.Product.Code,
							ProductId = y.ProductId,
							ProductName = y.Product.Name,
							SumPrice = y.SumPrice
						}).ToList(),
						OrderId = x.Id
					}).FirstOrDefault();

				return res;
			}
		}

		public static bool DeleteOrder(int orderId)
		{
			using (DbEntities db = new DbEntities())
			{
				try
				{
					var orderDetails = db.OrderDetails.Where(x => x.OrderId == orderId).ToList();

					db.OrderDetails.RemoveRange(orderDetails);
					db.SaveChanges();

					var order = db.Orders.Find(orderId);

					db.Orders.Remove(order);
					db.SaveChanges();

					return true;
				}
				catch
				{
					return false;	
				}
			}
		}

		public static bool AddOrder(OrderDto order)
		{
			using (DbEntities db = new DbEntities())
			{
				try
				{
					Order newOrder = new Order()
					{
						CustomerId = order.CustomerId,
						Date = order.Date,
						Number = order.OrderNumber,
					};

					db.Orders.Add(newOrder);
					db.SaveChanges();

					foreach (var item in order.OrderDetails)
					{
						OrderDetail newOrderDetail = new OrderDetail()
						{
							Count = item.Count,
							OrderId = newOrder.Id,
							Price = item.Price,
							ProductId = item.ProductId,
							SumPrice = item.SumPrice,
						};
						db.OrderDetails.Add(newOrderDetail);
					}

					db.SaveChanges();

					return true;
				}
				catch { return false; }
			}
		}

		public static bool UpdateOrder(OrderDto model)
		{
			using (DbEntities db = new DbEntities())
			{
				try
				{
					Order order = db.Orders.Find(model.OrderId);

					if (order == null)
						return false;

					order.CustomerId = model.CustomerId;
					order.Date = model.Date;
					order.Number = model.OrderNumber;

					db.SaveChanges();

					var orderDetails = db.OrderDetails.Where(x => x.OrderId == model.OrderId).ToList();

					db.OrderDetails.RemoveRange(orderDetails);
					db.SaveChanges();

					foreach (var item in model.OrderDetails)
					{
						OrderDetail newOrderDetail = new OrderDetail()
						{
							Count = item.Count,
							OrderId = order.Id,
							Price = item.Price,
							ProductId = item.ProductId,
							SumPrice = item.SumPrice,
						};
						db.OrderDetails.Add(newOrderDetail);
					}

					db.SaveChanges();

					return true;
				}
				catch { return false; }
			}
		}
	}
}
