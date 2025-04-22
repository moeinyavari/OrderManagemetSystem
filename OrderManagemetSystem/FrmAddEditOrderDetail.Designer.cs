namespace OrderManagemetSystem
{
	partial class FrmAddEditOrderDetail
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEditOrderDetail));
			this.label1 = new System.Windows.Forms.Label();
			this.cbProducts = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.nuCount = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtSumPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nuCount)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label1.Location = new System.Drawing.Point(242, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "کالا";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbProducts
			// 
			this.cbProducts.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.cbProducts.FormattingEnabled = true;
			this.cbProducts.Location = new System.Drawing.Point(31, 74);
			this.cbProducts.Name = "cbProducts";
			this.cbProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cbProducts.Size = new System.Drawing.Size(205, 37);
			this.cbProducts.TabIndex = 1;
			this.cbProducts.SelectedIndexChanged += new System.EventHandler(this.cbProducts_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label2.Location = new System.Drawing.Point(242, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 61);
			this.label2.TabIndex = 2;
			this.label2.Text = "قیمت واحد\r\n( ریال )";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// nuCount
			// 
			this.nuCount.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.nuCount.Location = new System.Drawing.Point(31, 194);
			this.nuCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nuCount.Name = "nuCount";
			this.nuCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.nuCount.Size = new System.Drawing.Size(205, 37);
			this.nuCount.TabIndex = 6;
			this.nuCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nuCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nuCount.ValueChanged += new System.EventHandler(this.nuCount_ValueChanged);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label3.Location = new System.Drawing.Point(242, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 34);
			this.label3.TabIndex = 5;
			this.label3.Text = "تعداد";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPrice
			// 
			this.txtPrice.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.txtPrice.Location = new System.Drawing.Point(31, 132);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.ReadOnly = true;
			this.txtPrice.Size = new System.Drawing.Size(205, 37);
			this.txtPrice.TabIndex = 7;
			this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtSumPrice
			// 
			this.txtSumPrice.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.txtSumPrice.Location = new System.Drawing.Point(31, 251);
			this.txtSumPrice.Name = "txtSumPrice";
			this.txtSumPrice.ReadOnly = true;
			this.txtSumPrice.Size = new System.Drawing.Size(205, 37);
			this.txtSumPrice.TabIndex = 9;
			this.txtSumPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label4.Location = new System.Drawing.Point(242, 251);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 58);
			this.label4.TabIndex = 8;
			this.label4.Text = "جمع کل\r\n( ریال )";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(342, 55);
			this.panel1.TabIndex = 10;
			// 
			// btnCancel
			// 
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnCancel.Location = new System.Drawing.Point(96, 9);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(108, 35);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "انصراف";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnSave.Location = new System.Drawing.Point(220, 9);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(108, 35);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "ذخیره";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// FrmAddEditOrderDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(342, 313);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtSumPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.nuCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbProducts);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FrmAddEditOrderDetail";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FrmAddEditOrderDetail_Load);
			((System.ComponentModel.ISupportInitialize)(this.nuCount)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbProducts;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nuCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtSumPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
	}
}