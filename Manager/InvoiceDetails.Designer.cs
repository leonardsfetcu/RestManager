﻿namespace Manager
{
	partial class InvoiceDetails
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
			this.components = new System.ComponentModel.Container();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroComboBoxSuppliers = new MetroFramework.Controls.MetroComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
			this.CategoryID = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.UnitID = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroTextBoxQuantity = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroComboBoxProduct = new MetroFramework.Controls.MetroComboBox();
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.metroTileFinish = new MetroFramework.Controls.MetroTile();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.unitsInStoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.invoiceUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceUnitBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.metroLabel1.CustomBackground = true;
			this.metroLabel1.Location = new System.Drawing.Point(24, 93);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(61, 19);
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "Supplier:";
			// 
			// metroComboBoxSuppliers
			// 
			this.metroComboBoxSuppliers.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplierBindingSource, "SupplierID", true));
			this.metroComboBoxSuppliers.FormattingEnabled = true;
			this.metroComboBoxSuppliers.ItemHeight = 23;
			this.metroComboBoxSuppliers.Location = new System.Drawing.Point(156, 88);
			this.metroComboBoxSuppliers.Name = "metroComboBoxSuppliers";
			this.metroComboBoxSuppliers.Size = new System.Drawing.Size(322, 29);
			this.metroComboBoxSuppliers.TabIndex = 2;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "Date", true));
			this.dateTimePicker1.Location = new System.Drawing.Point(156, 60);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(232, 20);
			this.dateTimePicker1.TabIndex = 4;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.metroLabel2.CustomBackground = true;
			this.metroLabel2.Location = new System.Drawing.Point(24, 60);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(39, 19);
			this.metroLabel2.TabIndex = 1;
			this.metroLabel2.Text = "Date:";
			// 
			// dataGridViewProducts
			// 
			this.dataGridViewProducts.AllowUserToAddRows = false;
			this.dataGridViewProducts.AutoGenerateColumns = false;
			this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.tVADataGridViewTextBoxColumn,
            this.CategoryID,
            this.UnitID,
            this.unitsInStoreDataGridViewTextBoxColumn});
			this.dataGridViewProducts.DataSource = this.productBindingSource;
			this.dataGridViewProducts.Location = new System.Drawing.Point(24, 318);
			this.dataGridViewProducts.Name = "dataGridViewProducts";
			this.dataGridViewProducts.ReadOnly = true;
			this.dataGridViewProducts.Size = new System.Drawing.Size(455, 194);
			this.dataGridViewProducts.TabIndex = 5;
			// 
			// CategoryID
			// 
			this.CategoryID.DataPropertyName = "CategoryID";
			this.CategoryID.DataSource = this.categoryBindingSource;
			this.CategoryID.DisplayMember = "Name";
			this.CategoryID.HeaderText = "Category";
			this.CategoryID.Name = "CategoryID";
			this.CategoryID.ReadOnly = true;
			this.CategoryID.ValueMember = "CategoryID";
			this.CategoryID.Width = 70;
			// 
			// UnitID
			// 
			this.UnitID.DataPropertyName = "UnitID";
			this.UnitID.DataSource = this.unitBindingSource;
			this.UnitID.DisplayMember = "Name";
			this.UnitID.HeaderText = "Unit";
			this.UnitID.Name = "UnitID";
			this.UnitID.ReadOnly = true;
			this.UnitID.ValueMember = "UnitID";
			this.UnitID.Width = 60;
			// 
			// metroButton2
			// 
			this.metroButton2.Location = new System.Drawing.Point(24, 284);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(456, 28);
			this.metroButton2.TabIndex = 3;
			this.metroButton2.Text = "Add product to Invoice";
			this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click_1);
			// 
			// metroTextBoxQuantity
			// 
			this.metroTextBoxQuantity.Location = new System.Drawing.Point(194, 255);
			this.metroTextBoxQuantity.Name = "metroTextBoxQuantity";
			this.metroTextBoxQuantity.Size = new System.Drawing.Size(85, 23);
			this.metroTextBoxQuantity.TabIndex = 6;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.metroLabel4.CustomBackground = true;
			this.metroLabel4.Location = new System.Drawing.Point(24, 262);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(61, 19);
			this.metroLabel4.TabIndex = 1;
			this.metroLabel4.Text = "Quantity:";
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.metroLabel5.CustomBackground = true;
			this.metroLabel5.Location = new System.Drawing.Point(24, 230);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(137, 19);
			this.metroLabel5.TabIndex = 1;
			this.metroLabel5.Text = "Select an old product:";
			// 
			// metroComboBoxProduct
			// 
			this.metroComboBoxProduct.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductID", true));
			this.metroComboBoxProduct.FormattingEnabled = true;
			this.metroComboBoxProduct.ItemHeight = 23;
			this.metroComboBoxProduct.Location = new System.Drawing.Point(194, 220);
			this.metroComboBoxProduct.Name = "metroComboBoxProduct";
			this.metroComboBoxProduct.Size = new System.Drawing.Size(194, 29);
			this.metroComboBoxProduct.TabIndex = 2;
			// 
			// metroButton3
			// 
			this.metroButton3.Location = new System.Drawing.Point(393, 220);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new System.Drawing.Size(85, 29);
			this.metroButton3.TabIndex = 3;
			this.metroButton3.Text = "Add Product";
			this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
			// 
			// metroLabel6
			// 
			this.metroLabel6.AutoSize = true;
			this.metroLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel6.Location = new System.Drawing.Point(194, 174);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(148, 25);
			this.metroLabel6.TabIndex = 1;
			this.metroLabel6.Text = "Product Selection:";
			this.metroLabel6.UseStyleColors = true;
			// 
			// metroTileFinish
			// 
			this.metroTileFinish.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.metroTileFinish.Location = new System.Drawing.Point(24, 519);
			this.metroTileFinish.Name = "metroTileFinish";
			this.metroTileFinish.Size = new System.Drawing.Size(454, 41);
			this.metroTileFinish.TabIndex = 7;
			this.metroTileFinish.Text = "Finish Invoice";
			this.metroTileFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTileFinish.Click += new System.EventHandler(this.metroTileFinish_Click);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// unitPriceDataGridViewTextBoxColumn
			// 
			this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
			this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
			this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
			this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
			this.unitPriceDataGridViewTextBoxColumn.Width = 60;
			// 
			// tVADataGridViewTextBoxColumn
			// 
			this.tVADataGridViewTextBoxColumn.DataPropertyName = "TVA";
			this.tVADataGridViewTextBoxColumn.HeaderText = "TVA";
			this.tVADataGridViewTextBoxColumn.Name = "tVADataGridViewTextBoxColumn";
			this.tVADataGridViewTextBoxColumn.ReadOnly = true;
			this.tVADataGridViewTextBoxColumn.Width = 40;
			// 
			// categoryBindingSource
			// 
			this.categoryBindingSource.DataSource = typeof(Manager.Category);
			// 
			// unitBindingSource
			// 
			this.unitBindingSource.DataSource = typeof(Manager.Unit);
			// 
			// unitsInStoreDataGridViewTextBoxColumn
			// 
			this.unitsInStoreDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStore";
			this.unitsInStoreDataGridViewTextBoxColumn.HeaderText = "Quantity";
			this.unitsInStoreDataGridViewTextBoxColumn.Name = "unitsInStoreDataGridViewTextBoxColumn";
			this.unitsInStoreDataGridViewTextBoxColumn.ReadOnly = true;
			this.unitsInStoreDataGridViewTextBoxColumn.Width = 80;
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataSource = typeof(Manager.Product);
			// 
			// invoiceBindingSource
			// 
			this.invoiceBindingSource.DataSource = typeof(Manager.Invoice);
			// 
			// employeeBindingSource
			// 
			this.employeeBindingSource.DataSource = typeof(Manager.Employee);
			// 
			// supplierBindingSource
			// 
			this.supplierBindingSource.DataSource = typeof(Manager.Supplier);
			// 
			// invoiceUnitBindingSource
			// 
			this.invoiceUnitBindingSource.DataSource = typeof(Manager.InvoiceUnit);
			// 
			// InvoiceDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(501, 583);
			this.Controls.Add(this.metroTileFinish);
			this.Controls.Add(this.metroTextBoxQuantity);
			this.Controls.Add(this.dataGridViewProducts);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.metroButton2);
			this.Controls.Add(this.metroButton3);
			this.Controls.Add(this.metroComboBoxProduct);
			this.Controls.Add(this.metroComboBoxSuppliers);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabel6);
			this.Controls.Add(this.metroLabel5);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Name = "InvoiceDetails";
			this.Text = "Invoice";
			this.Load += new System.EventHandler(this.InvoiceDetails_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceUnitBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource invoiceBindingSource;
		private System.Windows.Forms.BindingSource supplierBindingSource;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroComboBox metroComboBoxSuppliers;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.BindingSource employeeBindingSource;
		private System.Windows.Forms.DataGridView dataGridViewProducts;
		private System.Windows.Forms.BindingSource categoryBindingSource;
		private System.Windows.Forms.BindingSource unitBindingSource;
		private System.Windows.Forms.BindingSource productBindingSource;
		private MetroFramework.Controls.MetroButton metroButton2;
		private MetroFramework.Controls.MetroTextBox metroTextBoxQuantity;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroComboBox metroComboBoxProduct;
		private MetroFramework.Controls.MetroButton metroButton3;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private System.Windows.Forms.BindingSource invoiceUnitBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tVADataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn CategoryID;
		private System.Windows.Forms.DataGridViewComboBoxColumn UnitID;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitsInStoreDataGridViewTextBoxColumn;
		private MetroFramework.Controls.MetroTile metroTileFinish;
	}
}