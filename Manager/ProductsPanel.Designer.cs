namespace Manager
{
	partial class ProductsPanel
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
			this.mtEmployeePanelAdd = new MetroFramework.Controls.MetroTile();
			this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnitID = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.mtEmployeePanelSave = new MetroFramework.Controls.MetroTile();
			this.mtEmployeePanelDelete = new MetroFramework.Controls.MetroTile();
			this.mtEmployeePanelEdit = new MetroFramework.Controls.MetroTile();
			this.mtEmployeePanelRefresh = new MetroFramework.Controls.MetroTile();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.nameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.tVADataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.UnitID});
			this.dataGridView1.DataSource = this.productBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(24, 143);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(650, 263);
			this.dataGridView1.TabIndex = 0;
			// 
			// mtEmployeePanelAdd
			// 
			this.mtEmployeePanelAdd.Location = new System.Drawing.Point(120, 59);
			this.mtEmployeePanelAdd.Name = "mtEmployeePanelAdd";
			this.mtEmployeePanelAdd.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelAdd.TabIndex = 2;
			this.mtEmployeePanelAdd.Text = "Add";
			this.mtEmployeePanelAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mtEmployeePanelAdd.TileImage = global::Manager.Properties.Resources.rsz_user_20;
			this.mtEmployeePanelAdd.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtEmployeePanelAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.mtEmployeePanelAdd.UseTileImage = true;
			this.mtEmployeePanelAdd.Click += new System.EventHandler(this.mtEmployeePanelAdd_Click);
			// 
			// ProductID
			// 
			this.ProductID.DataPropertyName = "ProductID";
			this.ProductID.HeaderText = "ProductID";
			this.ProductID.Name = "ProductID";
			// 
			// UnitID
			// 
			this.UnitID.DataPropertyName = "UnitID";
			this.UnitID.DataSource = this.unitBindingSource;
			this.UnitID.DisplayMember = "Name";
			this.UnitID.HeaderText = "Unit";
			this.UnitID.Name = "UnitID";
			this.UnitID.ReadOnly = true;
			this.UnitID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.UnitID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.UnitID.ValueMember = "UnitID";
			// 
			// mtEmployeePanelSave
			// 
			this.mtEmployeePanelSave.Location = new System.Drawing.Point(408, 59);
			this.mtEmployeePanelSave.Name = "mtEmployeePanelSave";
			this.mtEmployeePanelSave.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelSave.TabIndex = 3;
			this.mtEmployeePanelSave.Text = "Save";
			this.mtEmployeePanelSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mtEmployeePanelSave.TileImage = global::Manager.Properties.Resources.rsz_user_23;
			this.mtEmployeePanelSave.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtEmployeePanelSave.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.mtEmployeePanelSave.UseTileImage = true;
			this.mtEmployeePanelSave.Click += new System.EventHandler(this.mtEmployeePanelSave_Click);
			// 
			// mtEmployeePanelDelete
			// 
			this.mtEmployeePanelDelete.Location = new System.Drawing.Point(312, 59);
			this.mtEmployeePanelDelete.Name = "mtEmployeePanelDelete";
			this.mtEmployeePanelDelete.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelDelete.TabIndex = 4;
			this.mtEmployeePanelDelete.Text = "Delete";
			this.mtEmployeePanelDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mtEmployeePanelDelete.TileImage = global::Manager.Properties.Resources.rsz_user_22;
			this.mtEmployeePanelDelete.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtEmployeePanelDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.mtEmployeePanelDelete.UseTileImage = true;
			this.mtEmployeePanelDelete.Click += new System.EventHandler(this.mtEmployeePanelDelete_Click);
			// 
			// mtEmployeePanelEdit
			// 
			this.mtEmployeePanelEdit.Location = new System.Drawing.Point(216, 59);
			this.mtEmployeePanelEdit.Name = "mtEmployeePanelEdit";
			this.mtEmployeePanelEdit.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelEdit.TabIndex = 5;
			this.mtEmployeePanelEdit.Text = "Edit";
			this.mtEmployeePanelEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mtEmployeePanelEdit.TileImage = global::Manager.Properties.Resources.rsz_user_32;
			this.mtEmployeePanelEdit.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtEmployeePanelEdit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.mtEmployeePanelEdit.UseTileImage = true;
			this.mtEmployeePanelEdit.Click += new System.EventHandler(this.mtEmployeePanelEdit_Click);
			// 
			// mtEmployeePanelRefresh
			// 
			this.mtEmployeePanelRefresh.Location = new System.Drawing.Point(24, 59);
			this.mtEmployeePanelRefresh.Name = "mtEmployeePanelRefresh";
			this.mtEmployeePanelRefresh.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelRefresh.TabIndex = 6;
			this.mtEmployeePanelRefresh.Text = "Refresh";
			this.mtEmployeePanelRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mtEmployeePanelRefresh.TileImage = global::Manager.Properties.Resources.rsz_user_35;
			this.mtEmployeePanelRefresh.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtEmployeePanelRefresh.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.mtEmployeePanelRefresh.UseTileImage = true;
			this.mtEmployeePanelRefresh.Click += new System.EventHandler(this.mtEmployeePanelRefresh_Click);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// unitPriceDataGridViewTextBoxColumn
			// 
			this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
			this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
			this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
			// 
			// tVADataGridViewTextBoxColumn
			// 
			this.tVADataGridViewTextBoxColumn.DataPropertyName = "TVA";
			this.tVADataGridViewTextBoxColumn.HeaderText = "TVA";
			this.tVADataGridViewTextBoxColumn.Name = "tVADataGridViewTextBoxColumn";
			// 
			// categoryIDDataGridViewTextBoxColumn
			// 
			this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
			this.categoryIDDataGridViewTextBoxColumn.DataSource = this.categoryBindingSource;
			this.categoryIDDataGridViewTextBoxColumn.DisplayMember = "Name";
			this.categoryIDDataGridViewTextBoxColumn.HeaderText = "Category";
			this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
			this.categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.categoryIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.categoryIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.categoryIDDataGridViewTextBoxColumn.ValueMember = "CategoryID";
			// 
			// categoryBindingSource
			// 
			this.categoryBindingSource.DataSource = typeof(Manager.Category);
			// 
			// unitBindingSource
			// 
			this.unitBindingSource.DataSource = typeof(Manager.Unit);
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataSource = typeof(Manager.Product);
			// 
			// ProductsPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(697, 429);
			this.Controls.Add(this.mtEmployeePanelSave);
			this.Controls.Add(this.mtEmployeePanelDelete);
			this.Controls.Add(this.mtEmployeePanelEdit);
			this.Controls.Add(this.mtEmployeePanelRefresh);
			this.Controls.Add(this.mtEmployeePanelAdd);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ProductsPanel";
			this.Text = "Products Panel";
			this.Load += new System.EventHandler(this.ProductsPanel_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource categoryBindingSource;
		private System.Windows.Forms.BindingSource productBindingSource;
		private System.Windows.Forms.BindingSource unitBindingSource;
		private MetroFramework.Controls.MetroTile mtEmployeePanelAdd;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tVADataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn categoryIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn UnitID;
		private MetroFramework.Controls.MetroTile mtEmployeePanelSave;
		private MetroFramework.Controls.MetroTile mtEmployeePanelDelete;
		private MetroFramework.Controls.MetroTile mtEmployeePanelEdit;
		private MetroFramework.Controls.MetroTile mtEmployeePanelRefresh;
	}
}