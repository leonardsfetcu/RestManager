﻿namespace Manager
{
	partial class InvoicePanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.EmployeeID2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mtEmployeePanelSave = new MetroFramework.Controls.MetroTile();
            this.mtEmployeePanelDelete = new MetroFramework.Controls.MetroTile();
            this.mtEmployeePanelEdit = new MetroFramework.Controls.MetroTile();
            this.mtEmployeePanelAdd = new MetroFramework.Controls.MetroTile();
            this.mtEmployeePanelRefresh = new MetroFramework.Controls.MetroTile();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.cIFDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supplierBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 193);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(457, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.EmployeeID2});
            this.dataGridView2.DataSource = this.invoiceBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(499, 193);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(592, 370);
            this.dataGridView2.TabIndex = 1;
            // 
            // EmployeeID2
            // 
            this.EmployeeID2.DataPropertyName = "EmployeeID";
            this.EmployeeID2.DataSource = this.employeeBindingSource;
            this.EmployeeID2.DisplayMember = "LastName";
            this.EmployeeID2.HeaderText = "Last Name";
            this.EmployeeID2.Name = "EmployeeID2";
            this.EmployeeID2.ReadOnly = true;
            this.EmployeeID2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeID2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EmployeeID2.ValueMember = "EmployeeID";
            // 
            // mtEmployeePanelSave
            // 
            this.mtEmployeePanelSave.Location = new System.Drawing.Point(416, 78);
            this.mtEmployeePanelSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtEmployeePanelSave.Name = "mtEmployeePanelSave";
            this.mtEmployeePanelSave.Size = new System.Drawing.Size(120, 96);
            this.mtEmployeePanelSave.TabIndex = 2;
            this.mtEmployeePanelSave.Text = "Save";
            this.mtEmployeePanelSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtEmployeePanelSave.TileImage = global::Manager.Properties.Resources.rsz_user_23;
            this.mtEmployeePanelSave.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtEmployeePanelSave.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtEmployeePanelSave.UseTileImage = true;
            // 
            // mtEmployeePanelDelete
            // 
            this.mtEmployeePanelDelete.Location = new System.Drawing.Point(288, 78);
            this.mtEmployeePanelDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtEmployeePanelDelete.Name = "mtEmployeePanelDelete";
            this.mtEmployeePanelDelete.Size = new System.Drawing.Size(120, 96);
            this.mtEmployeePanelDelete.TabIndex = 3;
            this.mtEmployeePanelDelete.Text = "Delete";
            this.mtEmployeePanelDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtEmployeePanelDelete.TileImage = global::Manager.Properties.Resources.rsz_user_22;
            this.mtEmployeePanelDelete.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtEmployeePanelDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtEmployeePanelDelete.UseTileImage = true;
            // 
            // mtEmployeePanelEdit
            // 
            this.mtEmployeePanelEdit.Location = new System.Drawing.Point(544, 78);
            this.mtEmployeePanelEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtEmployeePanelEdit.Name = "mtEmployeePanelEdit";
            this.mtEmployeePanelEdit.Size = new System.Drawing.Size(120, 96);
            this.mtEmployeePanelEdit.TabIndex = 4;
            this.mtEmployeePanelEdit.Text = "Exit";
            this.mtEmployeePanelEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtEmployeePanelEdit.TileImage = global::Manager.Properties.Resources.rsz_user_32;
            this.mtEmployeePanelEdit.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtEmployeePanelEdit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtEmployeePanelEdit.UseTileImage = true;
            this.mtEmployeePanelEdit.Click += new System.EventHandler(this.mtEmployeePanelEdit_Click);
            // 
            // mtEmployeePanelAdd
            // 
            this.mtEmployeePanelAdd.Location = new System.Drawing.Point(160, 78);
            this.mtEmployeePanelAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtEmployeePanelAdd.Name = "mtEmployeePanelAdd";
            this.mtEmployeePanelAdd.Size = new System.Drawing.Size(120, 96);
            this.mtEmployeePanelAdd.TabIndex = 5;
            this.mtEmployeePanelAdd.Text = "Add";
            this.mtEmployeePanelAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtEmployeePanelAdd.TileImage = global::Manager.Properties.Resources.rsz_user_20;
            this.mtEmployeePanelAdd.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtEmployeePanelAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtEmployeePanelAdd.UseTileImage = true;
            this.mtEmployeePanelAdd.Click += new System.EventHandler(this.metroTileAdd_Click);
            // 
            // mtEmployeePanelRefresh
            // 
            this.mtEmployeePanelRefresh.Location = new System.Drawing.Point(32, 78);
            this.mtEmployeePanelRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtEmployeePanelRefresh.Name = "mtEmployeePanelRefresh";
            this.mtEmployeePanelRefresh.Size = new System.Drawing.Size(120, 96);
            this.mtEmployeePanelRefresh.TabIndex = 6;
            this.mtEmployeePanelRefresh.Text = "Refresh";
            this.mtEmployeePanelRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtEmployeePanelRefresh.TileImage = global::Manager.Properties.Resources.rsz_user_35;
            this.mtEmployeePanelRefresh.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtEmployeePanelRefresh.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtEmployeePanelRefresh.UseTileImage = true;
            this.mtEmployeePanelRefresh.Click += new System.EventHandler(this.mtEmployeePanelRefresh_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceID";
            this.dataGridViewTextBoxColumn1.HeaderText = "InvoiceID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn4.DataSource = this.employeeBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "FirstName";
            this.dataGridViewTextBoxColumn4.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "EmployeeID";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Manager.Employee);
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(Manager.Invoice);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIFDataGridViewTextBoxColumn
            // 
            this.cIFDataGridViewTextBoxColumn.DataPropertyName = "CIF";
            this.cIFDataGridViewTextBoxColumn.HeaderText = "CIF";
            this.cIFDataGridViewTextBoxColumn.Name = "cIFDataGridViewTextBoxColumn";
            this.cIFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(Manager.Supplier);
            // 
            // InvoicePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1121, 592);
            this.Controls.Add(this.mtEmployeePanelSave);
            this.Controls.Add(this.mtEmployeePanelDelete);
            this.Controls.Add(this.mtEmployeePanelEdit);
            this.Controls.Add(this.mtEmployeePanelAdd);
            this.Controls.Add(this.mtEmployeePanelRefresh);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InvoicePanel";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "InvoicePanel";
            this.Load += new System.EventHandler(this.InvoicePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cIFDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource supplierBindingSource;
		private System.Windows.Forms.BindingSource invoiceBindingSource;
		private System.Windows.Forms.BindingSource employeeBindingSource;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn supplierIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn employeeIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewComboBoxColumn EmployeeID2;
		private MetroFramework.Controls.MetroTile mtEmployeePanelSave;
		private MetroFramework.Controls.MetroTile mtEmployeePanelDelete;
		private MetroFramework.Controls.MetroTile mtEmployeePanelEdit;
		private MetroFramework.Controls.MetroTile mtEmployeePanelAdd;
		private MetroFramework.Controls.MetroTile mtEmployeePanelRefresh;
	}
}