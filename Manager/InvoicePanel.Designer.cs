namespace Manager
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
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
			this.dataGridView1.Location = new System.Drawing.Point(24, 64);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(343, 394);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
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
			this.supplierBindingSource.CurrentChanged += new System.EventHandler(this.supplierBindingSource_CurrentChanged);
			// 
			// employeeBindingSource
			// 
			this.employeeBindingSource.DataSource = typeof(Manager.Employee);
			// 
			// invoiceBindingSource
			// 
			this.invoiceBindingSource.DataSource = typeof(Manager.Invoice);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIDDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.invoiceBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(374, 64);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(453, 394);
			this.dataGridView2.TabIndex = 1;
			// 
			// invoiceIDDataGridViewTextBoxColumn
			// 
			this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "InvoiceID";
			this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "InvoiceID";
			this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
			// 
			// supplierIDDataGridViewTextBoxColumn
			// 
			this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
			this.supplierIDDataGridViewTextBoxColumn.DataSource = this.supplierBindingSource;
			this.supplierIDDataGridViewTextBoxColumn.DisplayMember = "Name";
			this.supplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier";
			this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
			this.supplierIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.supplierIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.supplierIDDataGridViewTextBoxColumn.ValueMember = "SupplierID";
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			// 
			// employeeIDDataGridViewTextBoxColumn
			// 
			this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
			this.employeeIDDataGridViewTextBoxColumn.DataSource = this.employeeBindingSource;
			this.employeeIDDataGridViewTextBoxColumn.DisplayMember = "FirstName";
			this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee";
			this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
			this.employeeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.employeeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.employeeIDDataGridViewTextBoxColumn.ValueMember = "EmployeeID";
			// 
			// InvoicePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(850, 481);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "InvoicePanel";
			this.Text = "InvoicePanel";
			this.Load += new System.EventHandler(this.InvoicePanel_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
	}
}