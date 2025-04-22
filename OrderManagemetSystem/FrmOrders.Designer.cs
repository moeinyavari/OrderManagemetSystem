namespace OrderManagemetSystem
{
	partial class FrmOrders
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrders));
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbCustomers = new System.Windows.Forms.ComboBox();
			this.btnNewOrder = new System.Windows.Forms.Button();
			this.btnEditOrder = new System.Windows.Forms.Button();
			this.btnDeleteOrder = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtFromDate = new System.Windows.Forms.MaskedTextBox();
			this.txtToDate = new System.Windows.Forms.MaskedTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.gvOrders = new System.Windows.Forms.DataGridView();
			this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnNewOrder);
			this.panel2.Controls.Add(this.btnEditOrder);
			this.panel2.Controls.Add(this.btnDeleteOrder);
			this.panel2.Controls.Add(this.btnExit);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(980, 69);
			this.panel2.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.txtToDate);
			this.panel1.Controls.Add(this.txtFromDate);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cbCustomers);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 69);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(980, 68);
			this.panel1.TabIndex = 4;
			// 
			// cbCustomers
			// 
			this.cbCustomers.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.cbCustomers.FormattingEnabled = true;
			this.cbCustomers.Location = new System.Drawing.Point(679, 13);
			this.cbCustomers.Name = "cbCustomers";
			this.cbCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cbCustomers.Size = new System.Drawing.Size(202, 37);
			this.cbCustomers.TabIndex = 0;
			// 
			// btnNewOrder
			// 
			this.btnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNewOrder.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnNewOrder.Location = new System.Drawing.Point(833, 13);
			this.btnNewOrder.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.btnNewOrder.Name = "btnNewOrder";
			this.btnNewOrder.Size = new System.Drawing.Size(135, 42);
			this.btnNewOrder.TabIndex = 7;
			this.btnNewOrder.Text = "فاکتور جدید";
			this.btnNewOrder.UseVisualStyleBackColor = true;
			this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
			// 
			// btnEditOrder
			// 
			this.btnEditOrder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditOrder.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnEditOrder.Location = new System.Drawing.Point(681, 13);
			this.btnEditOrder.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.btnEditOrder.Name = "btnEditOrder";
			this.btnEditOrder.Size = new System.Drawing.Size(135, 42);
			this.btnEditOrder.TabIndex = 8;
			this.btnEditOrder.Text = "ویرایش فاکتور";
			this.btnEditOrder.UseVisualStyleBackColor = true;
			this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
			// 
			// btnDeleteOrder
			// 
			this.btnDeleteOrder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteOrder.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnDeleteOrder.Location = new System.Drawing.Point(531, 13);
			this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.btnDeleteOrder.Name = "btnDeleteOrder";
			this.btnDeleteOrder.Size = new System.Drawing.Size(135, 42);
			this.btnDeleteOrder.TabIndex = 9;
			this.btnDeleteOrder.Text = "حذف فاکتور";
			this.btnDeleteOrder.UseVisualStyleBackColor = true;
			this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnExit.Location = new System.Drawing.Point(12, 13);
			this.btnExit.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(135, 42);
			this.btnExit.TabIndex = 10;
			this.btnExit.Text = "خروج";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label1.Location = new System.Drawing.Point(887, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "نام مشتری";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label2.Location = new System.Drawing.Point(609, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 29);
			this.label2.TabIndex = 3;
			this.label2.Text = "از تاریخ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label3.Location = new System.Drawing.Point(350, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 29);
			this.label3.TabIndex = 5;
			this.label3.Text = "از تاریخ";
			// 
			// btnSearch
			// 
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnSearch.Location = new System.Drawing.Point(10, 13);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(135, 36);
			this.btnSearch.TabIndex = 10;
			this.btnSearch.Text = "جستجو";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtFromDate
			// 
			this.txtFromDate.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.txtFromDate.Location = new System.Drawing.Point(427, 13);
			this.txtFromDate.Mask = "0000/00/00";
			this.txtFromDate.Name = "txtFromDate";
			this.txtFromDate.Size = new System.Drawing.Size(176, 37);
			this.txtFromDate.TabIndex = 5;
			this.txtFromDate.ValidatingType = typeof(System.DateTime);
			// 
			// txtToDate
			// 
			this.txtToDate.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.txtToDate.Location = new System.Drawing.Point(168, 12);
			this.txtToDate.Mask = "0000/00/00";
			this.txtToDate.Name = "txtToDate";
			this.txtToDate.Size = new System.Drawing.Size(176, 37);
			this.txtToDate.TabIndex = 5;
			this.txtToDate.ValidatingType = typeof(System.DateTime);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.gvOrders);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 137);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(980, 383);
			this.panel3.TabIndex = 5;
			// 
			// gvOrders
			// 
			this.gvOrders.AllowUserToAddRows = false;
			this.gvOrders.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle1.NullValue = "---";
			this.gvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gvOrders.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.OrderNumber,
            this.CustomerName,
            this.OrderDate,
            this.SumPrice});
			this.gvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvOrders.EnableHeadersVisualStyles = false;
			this.gvOrders.Location = new System.Drawing.Point(0, 0);
			this.gvOrders.MultiSelect = false;
			this.gvOrders.Name = "gvOrders";
			this.gvOrders.ReadOnly = true;
			this.gvOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gvOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.AppWorkspace;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.gvOrders.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.gvOrders.Size = new System.Drawing.Size(980, 383);
			this.gvOrders.TabIndex = 0;
			// 
			// OrderId
			// 
			this.OrderId.DataPropertyName = "OrderId";
			this.OrderId.HeaderText = "OrderId";
			this.OrderId.Name = "OrderId";
			this.OrderId.ReadOnly = true;
			this.OrderId.Visible = false;
			// 
			// OrderNumber
			// 
			this.OrderNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.OrderNumber.DataPropertyName = "OrderNumber";
			dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.OrderNumber.DefaultCellStyle = dataGridViewCellStyle3;
			this.OrderNumber.HeaderText = "شماره فاکتور";
			this.OrderNumber.Name = "OrderNumber";
			this.OrderNumber.ReadOnly = true;
			this.OrderNumber.Width = 111;
			// 
			// CustomerName
			// 
			this.CustomerName.DataPropertyName = "CustomerName";
			this.CustomerName.HeaderText = "نام مشتری";
			this.CustomerName.Name = "CustomerName";
			this.CustomerName.ReadOnly = true;
			this.CustomerName.Width = 300;
			// 
			// OrderDate
			// 
			this.OrderDate.DataPropertyName = "OrderDate";
			this.OrderDate.HeaderText = "تاریخ فاکتور";
			this.OrderDate.Name = "OrderDate";
			this.OrderDate.ReadOnly = true;
			this.OrderDate.Width = 240;
			// 
			// SumPrice
			// 
			this.SumPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SumPrice.DataPropertyName = "SumPrice";
			this.SumPrice.HeaderText = "جمع کل (ریال)";
			this.SumPrice.Name = "SumPrice";
			this.SumPrice.ReadOnly = true;
			// 
			// FrmOrders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(980, 520);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FrmOrders";
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "سیستم مدیریت فاکتور ها";
			this.Load += new System.EventHandler(this.FrmOrders_Load);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnNewOrder;
		private System.Windows.Forms.Button btnEditOrder;
		private System.Windows.Forms.Button btnDeleteOrder;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbCustomers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox txtFromDate;
		private System.Windows.Forms.MaskedTextBox txtToDate;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView gvOrders;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn SumPrice;
	}
}