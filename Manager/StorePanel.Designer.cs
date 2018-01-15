namespace Manager
{
	partial class Store
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quatityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.storeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.metroInvoices = new MetroFramework.Controls.MetroTile();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.metroTile4 = new MetroFramework.Controls.MetroTile();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.storeViewBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.quatityDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.tVADataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.storeViewBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(24, 147);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(572, 241);
			this.dataGridView1.TabIndex = 0;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// quatityDataGridViewTextBoxColumn
			// 
			this.quatityDataGridViewTextBoxColumn.DataPropertyName = "Quatity";
			this.quatityDataGridViewTextBoxColumn.HeaderText = "Quatity";
			this.quatityDataGridViewTextBoxColumn.Name = "quatityDataGridViewTextBoxColumn";
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
			// categoryDataGridViewTextBoxColumn
			// 
			this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
			this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
			this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
			// 
			// storeViewBindingSource
			// 
			this.storeViewBindingSource.DataSource = typeof(Manager.StoreView);
			// 
			// metroInvoices
			// 
			this.metroInvoices.Location = new System.Drawing.Point(24, 63);
			this.metroInvoices.Name = "metroInvoices";
			this.metroInvoices.Size = new System.Drawing.Size(90, 78);
			this.metroInvoices.TabIndex = 1;
			this.metroInvoices.Text = "Save CSV";
			this.metroInvoices.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroInvoices.TileImage = ((System.Drawing.Image)(resources.GetObject("metroInvoices.TileImage")));
			this.metroInvoices.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.metroInvoices.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroInvoices.UseTileImage = true;
			this.metroInvoices.Click += new System.EventHandler(this.metroInvoices_Click);
			// 
			// metroTile1
			// 
			this.metroTile1.Location = new System.Drawing.Point(120, 63);
			this.metroTile1.Name = "metroTile1";
			this.metroTile1.Size = new System.Drawing.Size(90, 78);
			this.metroTile1.TabIndex = 1;
			this.metroTile1.Text = "Save Excel";
			this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
			this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile1.UseTileImage = true;
			// 
			// metroTile4
			// 
			this.metroTile4.Location = new System.Drawing.Point(508, 63);
			this.metroTile4.Name = "metroTile4";
			this.metroTile4.Size = new System.Drawing.Size(90, 78);
			this.metroTile4.TabIndex = 2;
			this.metroTile4.Text = "Close";
			this.metroTile4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile4.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile4.TileImage")));
			this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile4.UseTileImage = true;
			this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
			// 
			// Store
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(621, 411);
			this.Controls.Add(this.metroTile4);
			this.Controls.Add(this.metroTile1);
			this.Controls.Add(this.metroInvoices);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Store";
			this.Text = "StorePanel";
			this.Load += new System.EventHandler(this.StorePanel_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.storeViewBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quatityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tVADataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource storeViewBindingSource;
		private MetroFramework.Controls.MetroTile metroInvoices;
		private MetroFramework.Controls.MetroTile metroTile1;
		private MetroFramework.Controls.MetroTile metroTile4;
	}
}