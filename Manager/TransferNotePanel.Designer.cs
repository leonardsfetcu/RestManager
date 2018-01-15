namespace Manager
{
    partial class TransferNotePanel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferNotePanel));
			this.mtEmployeePanelAdd = new MetroFramework.Controls.MetroTile();
			this.mtEmployeePanelRefresh = new MetroFramework.Controls.MetroTile();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.TransferNoteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductID = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.transferNoteUnitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.transferNoteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.transferNoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.transfetNoteUnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.transferNoteIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.transferNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mtEmployeePanelSave = new MetroFramework.Controls.MetroTile();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.transfetNoteUnitBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.transferNoteBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// mtEmployeePanelAdd
			// 
			this.mtEmployeePanelAdd.Location = new System.Drawing.Point(122, 64);
			this.mtEmployeePanelAdd.Margin = new System.Windows.Forms.Padding(4);
			this.mtEmployeePanelAdd.Name = "mtEmployeePanelAdd";
			this.mtEmployeePanelAdd.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelAdd.TabIndex = 12;
			this.mtEmployeePanelAdd.Text = "Add";
			this.mtEmployeePanelAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mtEmployeePanelAdd.TileImage = global::Manager.Properties.Resources.rsz_user_20;
			this.mtEmployeePanelAdd.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtEmployeePanelAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.mtEmployeePanelAdd.UseTileImage = true;
			this.mtEmployeePanelAdd.Click += new System.EventHandler(this.mtEmployeePanelAdd_Click);
			// 
			// mtEmployeePanelRefresh
			// 
			this.mtEmployeePanelRefresh.Location = new System.Drawing.Point(24, 64);
			this.mtEmployeePanelRefresh.Margin = new System.Windows.Forms.Padding(4);
			this.mtEmployeePanelRefresh.Name = "mtEmployeePanelRefresh";
			this.mtEmployeePanelRefresh.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelRefresh.TabIndex = 13;
			this.mtEmployeePanelRefresh.Text = "Refresh";
			this.mtEmployeePanelRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mtEmployeePanelRefresh.TileImage = global::Manager.Properties.Resources.rsz_user_35;
			this.mtEmployeePanelRefresh.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtEmployeePanelRefresh.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.mtEmployeePanelRefresh.UseTileImage = true;
			this.mtEmployeePanelRefresh.Click += new System.EventHandler(this.mtEmployeePanelRefresh_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransferNoteID,
            this.ProductID,
            this.Quantity,
            this.transferNoteUnitIDDataGridViewTextBoxColumn,
            this.transferNoteIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.transferNoteDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.transfetNoteUnitBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(349, 150);
			this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(458, 370);
			this.dataGridView2.TabIndex = 8;
			// 
			// TransferNoteID
			// 
			this.TransferNoteID.DataPropertyName = "TransferNoteID";
			this.TransferNoteID.HeaderText = "TransferNoteID";
			this.TransferNoteID.Name = "TransferNoteID";
			this.TransferNoteID.ReadOnly = true;
			// 
			// ProductID
			// 
			this.ProductID.DataPropertyName = "ProductID";
			this.ProductID.DataSource = this.productBindingSource;
			this.ProductID.DisplayMember = "Name";
			this.ProductID.HeaderText = "Product";
			this.ProductID.Name = "ProductID";
			this.ProductID.ReadOnly = true;
			this.ProductID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ProductID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.ProductID.ValueMember = "ProductID";
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataSource = typeof(Manager.Product);
			// 
			// Quantity
			// 
			this.Quantity.DataPropertyName = "Quantity";
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.Name = "Quantity";
			this.Quantity.ReadOnly = true;
			this.Quantity.Width = 60;
			// 
			// transferNoteUnitIDDataGridViewTextBoxColumn
			// 
			this.transferNoteUnitIDDataGridViewTextBoxColumn.DataPropertyName = "TransferNoteUnitID";
			this.transferNoteUnitIDDataGridViewTextBoxColumn.HeaderText = "TransferNoteUnitID";
			this.transferNoteUnitIDDataGridViewTextBoxColumn.Name = "transferNoteUnitIDDataGridViewTextBoxColumn";
			this.transferNoteUnitIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// transferNoteIDDataGridViewTextBoxColumn
			// 
			this.transferNoteIDDataGridViewTextBoxColumn.DataPropertyName = "TransferNoteID";
			this.transferNoteIDDataGridViewTextBoxColumn.HeaderText = "TransferNoteID";
			this.transferNoteIDDataGridViewTextBoxColumn.Name = "transferNoteIDDataGridViewTextBoxColumn";
			this.transferNoteIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productIDDataGridViewTextBoxColumn
			// 
			this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
			this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
			this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
			this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// quantityDataGridViewTextBoxColumn
			// 
			this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
			this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
			this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
			this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productDataGridViewTextBoxColumn
			// 
			this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
			this.productDataGridViewTextBoxColumn.HeaderText = "Product";
			this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
			this.productDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// transferNoteDataGridViewTextBoxColumn
			// 
			this.transferNoteDataGridViewTextBoxColumn.DataPropertyName = "TransferNote";
			this.transferNoteDataGridViewTextBoxColumn.HeaderText = "TransferNote";
			this.transferNoteDataGridViewTextBoxColumn.Name = "transferNoteDataGridViewTextBoxColumn";
			this.transferNoteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// transfetNoteUnitBindingSource
			// 
			this.transfetNoteUnitBindingSource.DataSource = typeof(Manager.TransfetNoteUnit);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transferNoteIDDataGridViewTextBoxColumn1,
            this.employeeIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.transferNoteBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(24, 150);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(317, 370);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// transferNoteIDDataGridViewTextBoxColumn1
			// 
			this.transferNoteIDDataGridViewTextBoxColumn1.DataPropertyName = "TransferNoteID";
			this.transferNoteIDDataGridViewTextBoxColumn1.HeaderText = "ID";
			this.transferNoteIDDataGridViewTextBoxColumn1.Name = "transferNoteIDDataGridViewTextBoxColumn1";
			this.transferNoteIDDataGridViewTextBoxColumn1.ReadOnly = true;
			this.transferNoteIDDataGridViewTextBoxColumn1.Width = 50;
			// 
			// employeeIDDataGridViewTextBoxColumn
			// 
			this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
			this.employeeIDDataGridViewTextBoxColumn.DataSource = this.employeeBindingSource;
			this.employeeIDDataGridViewTextBoxColumn.DisplayMember = "LastName";
			this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Made By Employee";
			this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
			this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.employeeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.employeeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.employeeIDDataGridViewTextBoxColumn.ValueMember = "EmployeeID";
			this.employeeIDDataGridViewTextBoxColumn.Width = 120;
			// 
			// employeeBindingSource
			// 
			this.employeeBindingSource.DataSource = typeof(Manager.Employee);
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// transferNoteBindingSource
			// 
			this.transferNoteBindingSource.DataSource = typeof(Manager.TransferNote);
			// 
			// mtEmployeePanelSave
			// 
			this.mtEmployeePanelSave.Location = new System.Drawing.Point(717, 63);
			this.mtEmployeePanelSave.Name = "mtEmployeePanelSave";
			this.mtEmployeePanelSave.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelSave.TabIndex = 14;
			this.mtEmployeePanelSave.Text = "Close";
			this.mtEmployeePanelSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mtEmployeePanelSave.TileImage = ((System.Drawing.Image)(resources.GetObject("mtEmployeePanelSave.TileImage")));
			this.mtEmployeePanelSave.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtEmployeePanelSave.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.mtEmployeePanelSave.UseTileImage = true;
			// 
			// TransferNotePanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(831, 536);
			this.Controls.Add(this.mtEmployeePanelSave);
			this.Controls.Add(this.mtEmployeePanelAdd);
			this.Controls.Add(this.mtEmployeePanelRefresh);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "TransferNotePanel";
			this.Text = "TransferNotePanel";
			this.Load += new System.EventHandler(this.TransferNotePanel_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.transfetNoteUnitBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.transferNoteBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile mtEmployeePanelAdd;
        private MetroFramework.Controls.MetroTile mtEmployeePanelRefresh;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource transfetNoteUnitBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource transferNoteBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferNoteIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferNoteID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferNoteUnitIDDataGridViewTextBoxColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn transferNoteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferNoteDataGridViewTextBoxColumn;
		private MetroFramework.Controls.MetroTile mtEmployeePanelSave;
	}
}