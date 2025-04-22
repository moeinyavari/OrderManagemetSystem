namespace OrderManagemetSystem
{
	partial class FrmAddEditOrder
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditOrder));
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtOrderNumber = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtOrderDate = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbCustomers = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.gvOrderDetails = new System.Windows.Forms.DataGridView();
			this.OrderDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDeleteOrderDetail = new System.Windows.Forms.Button();
			this.btnEditOrderDetail = new System.Windows.Forms.Button();
			this.btnNewOrderDetail = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvOrderDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Controls.Add(this.btnCancel);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(799, 69);
			this.panel2.TabIndex = 4;
			// 
			// btnSave
			// 
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnSave.Location = new System.Drawing.Point(652, 13);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(135, 42);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "ثبت نهایی";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnCancel.Location = new System.Drawing.Point(498, 13);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(135, 42);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "انصراف";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// panel1
			// 
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.txtOrderNumber);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtOrderDate);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cbCustomers);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 69);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(799, 69);
			this.panel1.TabIndex = 5;
			// 
			// txtOrderNumber
			// 
			this.txtOrderNumber.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.txtOrderNumber.Location = new System.Drawing.Point(522, 14);
			this.txtOrderNumber.Name = "txtOrderNumber";
			this.txtOrderNumber.Size = new System.Drawing.Size(168, 37);
			this.txtOrderNumber.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label4.Location = new System.Drawing.Point(690, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 29);
			this.label4.TabIndex = 11;
			this.label4.Text = "شماره سفارش";
			// 
			// txtOrderDate
			// 
			this.txtOrderDate.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.txtOrderDate.Location = new System.Drawing.Point(10, 14);
			this.txtOrderDate.Mask = "0000/00/00";
			this.txtOrderDate.Name = "txtOrderDate";
			this.txtOrderDate.Size = new System.Drawing.Size(165, 37);
			this.txtOrderDate.TabIndex = 9;
			this.txtOrderDate.ValidatingType = typeof(System.DateTime);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label2.Location = new System.Drawing.Point(179, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 29);
			this.label2.TabIndex = 8;
			this.label2.Text = "تاریخ فاکتور";
			// 
			// cbCustomers
			// 
			this.cbCustomers.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.cbCustomers.FormattingEnabled = true;
			this.cbCustomers.Location = new System.Drawing.Point(274, 14);
			this.cbCustomers.Name = "cbCustomers";
			this.cbCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cbCustomers.Size = new System.Drawing.Size(165, 37);
			this.cbCustomers.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label1.Location = new System.Drawing.Point(437, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 29);
			this.label1.TabIndex = 7;
			this.label1.Text = "نام مشتری";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.gvOrderDetails);
			this.panel3.Controls.Add(this.btnDeleteOrderDetail);
			this.panel3.Controls.Add(this.btnEditOrderDetail);
			this.panel3.Controls.Add(this.btnNewOrderDetail);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 138);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(799, 259);
			this.panel3.TabIndex = 6;
			// 
			// gvOrderDetails
			// 
			this.gvOrderDetails.AllowUserToAddRows = false;
			this.gvOrderDetails.AllowUserToDeleteRows = false;
			this.gvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderDetailId,
            this.ProductId,
            this.ProductName,
            this.ProductCode,
            this.Price,
            this.Count,
            this.SumPrice});
			this.gvOrderDetails.Location = new System.Drawing.Point(12, 74);
			this.gvOrderDetails.Name = "gvOrderDetails";
			this.gvOrderDetails.ReadOnly = true;
			this.gvOrderDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gvOrderDetails.Size = new System.Drawing.Size(775, 173);
			this.gvOrderDetails.TabIndex = 10;
			// 
			// OrderDetailId
			// 
			this.OrderDetailId.DataPropertyName = "OrderDetailId";
			this.OrderDetailId.HeaderText = "OrderDetailId";
			this.OrderDetailId.Name = "OrderDetailId";
			this.OrderDetailId.ReadOnly = true;
			this.OrderDetailId.Visible = false;
			// 
			// ProductId
			// 
			this.ProductId.DataPropertyName = "ProductId";
			this.ProductId.HeaderText = "ProductId";
			this.ProductId.Name = "ProductId";
			this.ProductId.ReadOnly = true;
			this.ProductId.Visible = false;
			// 
			// ProductName
			// 
			this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ProductName.DataPropertyName = "ProductName";
			this.ProductName.HeaderText = "نام کالا";
			this.ProductName.Name = "ProductName";
			this.ProductName.ReadOnly = true;
			// 
			// ProductCode
			// 
			this.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ProductCode.DataPropertyName = "ProductCode";
			this.ProductCode.HeaderText = "کد کالا";
			this.ProductCode.Name = "ProductCode";
			this.ProductCode.ReadOnly = true;
			// 
			// Price
			// 
			this.Price.DataPropertyName = "Price";
			this.Price.HeaderText = "قیمت واحد (ریال)";
			this.Price.Name = "Price";
			this.Price.ReadOnly = true;
			// 
			// Count
			// 
			this.Count.DataPropertyName = "Count";
			this.Count.HeaderText = "تعداد";
			this.Count.Name = "Count";
			this.Count.ReadOnly = true;
			// 
			// SumPrice
			// 
			this.SumPrice.DataPropertyName = "SumPrice";
			this.SumPrice.HeaderText = "جمع کل (ریال)";
			this.SumPrice.Name = "SumPrice";
			this.SumPrice.ReadOnly = true;
			// 
			// btnDeleteOrderDetail
			// 
			this.btnDeleteOrderDetail.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteOrderDetail.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnDeleteOrderDetail.Location = new System.Drawing.Point(480, 33);
			this.btnDeleteOrderDetail.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
			this.btnDeleteOrderDetail.Size = new System.Drawing.Size(99, 35);
			this.btnDeleteOrderDetail.TabIndex = 9;
			this.btnDeleteOrderDetail.Text = "حذف";
			this.btnDeleteOrderDetail.UseVisualStyleBackColor = true;
			this.btnDeleteOrderDetail.Click += new System.EventHandler(this.btnDeleteOrderDetail_Click);
			// 
			// btnEditOrderDetail
			// 
			this.btnEditOrderDetail.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditOrderDetail.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnEditOrderDetail.Location = new System.Drawing.Point(585, 33);
			this.btnEditOrderDetail.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.btnEditOrderDetail.Name = "btnEditOrderDetail";
			this.btnEditOrderDetail.Size = new System.Drawing.Size(99, 35);
			this.btnEditOrderDetail.TabIndex = 9;
			this.btnEditOrderDetail.Text = "ویرایش";
			this.btnEditOrderDetail.UseVisualStyleBackColor = true;
			this.btnEditOrderDetail.Click += new System.EventHandler(this.btnEditOrderDetail_Click);
			// 
			// btnNewOrderDetail
			// 
			this.btnNewOrderDetail.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNewOrderDetail.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnNewOrderDetail.Location = new System.Drawing.Point(690, 33);
			this.btnNewOrderDetail.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.btnNewOrderDetail.Name = "btnNewOrderDetail";
			this.btnNewOrderDetail.Size = new System.Drawing.Size(99, 35);
			this.btnNewOrderDetail.TabIndex = 9;
			this.btnNewOrderDetail.Text = "ایجاد";
			this.btnNewOrderDetail.UseVisualStyleBackColor = true;
			this.btnNewOrderDetail.Click += new System.EventHandler(this.btnNewOrderDetail_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label3.Location = new System.Drawing.Point(353, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 26);
			this.label3.TabIndex = 0;
			this.label3.Text = "آیتم های فاکتور";
			// 
			// FrmAddEditOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(799, 397);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FrmAddEditOrder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FrmAddEditOrder_Load);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvOrderDetails)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MaskedTextBox txtOrderDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbCustomers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnDeleteOrderDetail;
		private System.Windows.Forms.Button btnEditOrderDetail;
		private System.Windows.Forms.Button btnNewOrderDetail;
		private System.Windows.Forms.DataGridView gvOrderDetails;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderDetailId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Count;
		private System.Windows.Forms.DataGridViewTextBoxColumn SumPrice;
		private System.Windows.Forms.TextBox txtOrderNumber;
		private System.Windows.Forms.Label label4;
	}
}