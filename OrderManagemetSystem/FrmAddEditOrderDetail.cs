using OrderManagemetSystem.Models;
using OrderManagemetSystem.Services;
using System;
using System.Windows.Forms;

namespace OrderManagemetSystem
{
	public partial class FrmAddEditOrderDetail : Form
	{
		public OrderDetailDto Data = null;

		public FrmAddEditOrderDetail()
		{
			InitializeComponent();
		}

		private void FrmAddEditOrderDetail_Load(object sender, EventArgs e)
		{
			GetProducts();

			if (Data != null)
			{
				cbProducts.SelectedValue = Data.ProductId;
				nuCount.Value = Data.Count;
			}
		}

		private void GetProducts()
		{
			var products = ProductsService.GetProducts();

			cbProducts.DataSource = products;
			cbProducts.DisplayMember = "Name";
			cbProducts.ValueMember = "ProductId";
		}

		private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedProduct = cbProducts.SelectedItem as ProductListDto;

			int selectedCount = (int)nuCount.Value;

			txtPrice.Text = selectedProduct.Price.ToString("N0");
			txtSumPrice.Text = (selectedProduct.Price * selectedCount).ToString("N0");
		}

		private void nuCount_ValueChanged(object sender, EventArgs e)
		{
			var selectedProduct = cbProducts.SelectedItem as ProductListDto;

			int selectedCount = (int)nuCount.Value;

			txtSumPrice.Text = (selectedProduct.Price * selectedCount).ToString("N0");
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var selectedProduct = cbProducts.SelectedItem as ProductListDto;

			int selectedCount = (int)nuCount.Value;

			Data = new OrderDetailDto()
			{
				Count = selectedCount,
				Price = selectedProduct.Price,
				ProductId = selectedProduct.ProductId,
				ProductName = selectedProduct.Name,
				ProductCode = selectedProduct.Code,
				SumPrice = selectedCount * selectedProduct.Price
			};

			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Data = null;
			this.Close();
		}
	}
}
