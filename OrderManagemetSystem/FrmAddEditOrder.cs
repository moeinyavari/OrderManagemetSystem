using OrderManagemetSystem.Models;
using OrderManagemetSystem.Services;
using OrderManagemetSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagemetSystem
{
	public partial class FrmAddEditOrder : Form
	{
		public int OrderId = 0;
		BindingList<OrderDetailDto> OrderDetails = new BindingList<OrderDetailDto>();

		public bool RefreshData = false;

		public FrmAddEditOrder()
		{
			InitializeComponent();
		}

		private void FrmAddEditOrder_Load(object sender, EventArgs e)
		{
			InitTitle();
			InitDate();
			GetCustomers();

			if (OrderId != 0)
			{
				GetOrderById();
			}

			gvOrderDetails.DataSource = OrderDetails;
		}

		private void GetOrderById()
		{
			var order = OrdersService.GetOrderById(OrderId);

			foreach (var orderDetail in order.OrderDetails)
			{
				OrderDetails.Add(orderDetail);
			}

			cbCustomers.SelectedValue = order.CustomerId;
			txtOrderDate.Text = order.Date.ToPersian();
			txtOrderNumber.Text = order.OrderNumber;
		}

		private void InitTitle()
		{
			string title = OrderId == 0 ? "ثبت فاکتور جدید" : "ویرایش فاکتور";
			this.Text = title;
		}

		private void InitDate()
		{
			string date = DateTime.Now.ToPersian();
			txtOrderDate.Text = date;
		}

		private void GetCustomers()
		{
			var customers = CustomersService.GetCustomers();

			cbCustomers.DataSource = customers;
			cbCustomers.DisplayMember = "CustomerName";
			cbCustomers.ValueMember = "CustomerId";
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnNewOrderDetail_Click(object sender, EventArgs e)
		{
			var frmAddOrderDetail = new FrmAddEditOrderDetail();
			frmAddOrderDetail.ShowDialog();

			if (frmAddOrderDetail.Data != null)
			{
				OrderDetails.Add(frmAddOrderDetail.Data);
			}
		}

		private void btnEditOrderDetail_Click(object sender, EventArgs e)
		{
			if (gvOrderDetails.SelectedRows.Count == 0)
			{
				MessageBox.Show("یک آیتم را انتخاب کنید");
				return;
			}

			var frmAddOrderDetail = new FrmAddEditOrderDetail();

			var selectedRow = gvOrderDetails.SelectedRows[0];
			var selectedIndex = selectedRow.Index;

			var detailDto = new OrderDetailDto
			{
				ProductId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value),
				ProductName = selectedRow.Cells["ProductName"].Value?.ToString(),
				ProductCode = selectedRow.Cells["ProductCode"].Value?.ToString(),
				Price = Convert.ToDecimal(selectedRow.Cells["Price"].Value),
				Count = Convert.ToInt32(selectedRow.Cells["Count"].Value),
				SumPrice = Convert.ToDecimal(selectedRow.Cells["SumPrice"].Value)
			};

			frmAddOrderDetail.Data = detailDto;

			frmAddOrderDetail.ShowDialog();

			if (frmAddOrderDetail.Data != null)
			{
				OrderDetails[selectedIndex] = frmAddOrderDetail.Data;
			}
		}

		private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
		{
			if (gvOrderDetails.SelectedRows.Count == 0)
			{
				MessageBox.Show("یک آیتم را انتخاب کنید");
				return;
			}

			var confirmResult = MessageBox.Show($"آیا از حذف این ایتم مطمئن هستید ؟",
									 string.Empty,
									 MessageBoxButtons.YesNo);

			if (confirmResult == DialogResult.Yes)
			{
				var selectedRow = gvOrderDetails.SelectedRows[0];
				var selectedIndex = selectedRow.Index;

				OrderDetails.RemoveAt(selectedIndex);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string orderNumber = txtOrderNumber.Text.Trim();
			int customerId = (int)cbCustomers.SelectedValue;
			DateTime orderDate = txtOrderDate.Text.ToGregorian();

			var order = new OrderDto()
			{
				OrderId = OrderId,
				CustomerId = customerId,
				Date = orderDate,
				OrderNumber = orderNumber,
				OrderDetails = OrderDetails.ToList()
			};

			bool saveResult = false;
			if (OrderId == 0)
			{
				saveResult = OrdersService.AddOrder(order);
			}
			else
			{
				saveResult = OrdersService.UpdateOrder(order);
			}

			if (saveResult) 
			{
				MessageBox.Show("فاکتور با موفقیت ثبت شد");

				RefreshData = true;
				this.Close();
			}
			else
			{
				MessageBox.Show("خطا در انجام عملیات");
			}
		}
	}
}
