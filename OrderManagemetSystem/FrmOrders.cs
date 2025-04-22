using OrderManagemetSystem.Models;
using OrderManagemetSystem.Services;
using OrderManagemetSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagemetSystem
{
	public partial class FrmOrders : Form
	{
		public FrmOrders()
		{
			InitializeComponent();
		}

		private void FrmOrders_Load(object sender, EventArgs e)
		{
			InitDates();
			GetCustomers();
			GetOrders();
		}

		private void InitDates()
		{
			string fromDate = DateTime.Now.AddDays(-30).ToPersian();
			string toDate = DateTime.Now.ToPersian();

			txtFromDate.Text = fromDate;
			txtToDate.Text = toDate;
		}

		private void GetCustomers()
		{
			var customers = CustomersService.GetCustomers();

			var allCustomersItem = new CustomersListDto()
			{
				CustomerId = 0,
				CustomerName = "همه"
			};
			customers.Insert(0, allCustomersItem);

			cbCustomers.DataSource = customers;
			cbCustomers.DisplayMember = "CustomerName";
			cbCustomers.ValueMember = "CustomerId";
		}

		private void GetOrders()
		{
			DateTime fromDate = txtFromDate.Text.ToGregorian();
			DateTime toDate = txtToDate.Text.ToGregorian().AddHours(23).AddMinutes(59);
			int cusomerId = (int)cbCustomers.SelectedValue;

			var orders = OrdersService.GetOrders(fromDate, toDate, cusomerId);

			gvOrders.DataSource = orders;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			GetOrders();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void btnDeleteOrder_Click(object sender, EventArgs e)
		{
			if (gvOrders.SelectedRows.Count == 0)
			{
				MessageBox.Show("یک فاکتور را انتخاب کنید");
				return;
			}

			var selectedRow = gvOrders.SelectedRows[0];

			var selectedOrderNumber = selectedRow.Cells["OrderNumber"].Value;
			var selectedOrderId = (int)selectedRow.Cells["OrderId"].Value;

			var confirmResult = MessageBox.Show($"آیا از حذف فاکتور شماره {selectedOrderNumber} مطمئن هستید؟",
									 string.Empty,
									 MessageBoxButtons.YesNo);

			if (confirmResult == DialogResult.Yes)
			{
				var deleteResult = OrdersService.DeleteOrder(selectedOrderId);
				if (deleteResult)
				{
					MessageBox.Show("عملیات با موفقیت انجام شد");
					GetOrders();
				}
				else
				{
					MessageBox.Show("خطا در انجام عملیات");
				}
			}
		}

		private void btnNewOrder_Click(object sender, EventArgs e)
		{
			var frmAddOrder = new FrmAddEditOrder();
			frmAddOrder.OrderId = 0;

			this.Hide();
			frmAddOrder.ShowDialog();
			this.Show();

			if (frmAddOrder.RefreshData)
			{
				GetOrders();
			}
		}

		private void btnEditOrder_Click(object sender, EventArgs e)
		{
			if (gvOrders.SelectedRows.Count == 0)
			{
				MessageBox.Show("یک فاکتور را انتخاب کنید");
				return;
			}

			var selectedRow = gvOrders.SelectedRows[0];

			var selectedOrderNumber = selectedRow.Cells["OrderNumber"].Value;
			var selectedOrderId = (int)selectedRow.Cells["OrderId"].Value;

			var frmAddOrder = new FrmAddEditOrder();
			frmAddOrder.OrderId = selectedOrderId;

			this.Hide();
			frmAddOrder.ShowDialog();
			this.Show();

			if (frmAddOrder.RefreshData)
			{
				GetOrders();
			}
		}
	}
}
