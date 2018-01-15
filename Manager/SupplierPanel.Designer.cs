namespace Manager
{
    partial class SupplierPanel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierPanel));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mtEmployeePanelSave = new MetroFramework.Controls.MetroTile();
			this.mtEmployeePanelDelete = new MetroFramework.Controls.MetroTile();
			this.mtEmployeePanelEdit = new MetroFramework.Controls.MetroTile();
			this.mtEmployeePanelAdd = new MetroFramework.Controls.MetroTile();
			this.mtEmployeePanelRefresh = new MetroFramework.Controls.MetroTile();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.cIFDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.supplierBindingSource;
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView1.Location = new System.Drawing.Point(22, 180);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(623, 329);
			this.dataGridView1.TabIndex = 8;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// adressDataGridViewTextBoxColumn
			// 
			this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
			this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
			this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
			// 
			// cIFDataGridViewTextBoxColumn
			// 
			this.cIFDataGridViewTextBoxColumn.DataPropertyName = "CIF";
			this.cIFDataGridViewTextBoxColumn.HeaderText = "CIF";
			this.cIFDataGridViewTextBoxColumn.Name = "cIFDataGridViewTextBoxColumn";
			// 
			// supplierBindingSource
			// 
			this.supplierBindingSource.DataSource = typeof(Manager.Supplier);
			// 
			// mtEmployeePanelSave
			// 
			this.mtEmployeePanelSave.Location = new System.Drawing.Point(407, 93);
			this.mtEmployeePanelSave.Name = "mtEmployeePanelSave";
			this.mtEmployeePanelSave.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelSave.TabIndex = 3;
			this.mtEmployeePanelSave.Text = "Save";
			this.mtEmployeePanelSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mtEmployeePanelSave.TileImage = ((System.Drawing.Image)(resources.GetObject("mtEmployeePanelSave.TileImage")));
			this.mtEmployeePanelSave.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtEmployeePanelSave.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.mtEmployeePanelSave.UseTileImage = true;
			this.mtEmployeePanelSave.Click += new System.EventHandler(this.mtEmployeePanelSave_Click);
			// 
			// mtEmployeePanelDelete
			// 
			this.mtEmployeePanelDelete.Location = new System.Drawing.Point(311, 93);
			this.mtEmployeePanelDelete.Name = "mtEmployeePanelDelete";
			this.mtEmployeePanelDelete.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelDelete.TabIndex = 4;
			this.mtEmployeePanelDelete.Text = "Delete";
			this.mtEmployeePanelDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mtEmployeePanelDelete.TileImage = ((System.Drawing.Image)(resources.GetObject("mtEmployeePanelDelete.TileImage")));
			this.mtEmployeePanelDelete.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtEmployeePanelDelete.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.mtEmployeePanelDelete.UseTileImage = true;
			this.mtEmployeePanelDelete.Click += new System.EventHandler(this.mtEmployeePanelDelete_Click);
			// 
			// mtEmployeePanelEdit
			// 
			this.mtEmployeePanelEdit.Location = new System.Drawing.Point(215, 93);
			this.mtEmployeePanelEdit.Name = "mtEmployeePanelEdit";
			this.mtEmployeePanelEdit.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelEdit.TabIndex = 5;
			this.mtEmployeePanelEdit.Text = "Edit";
			this.mtEmployeePanelEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mtEmployeePanelEdit.TileImage = ((System.Drawing.Image)(resources.GetObject("mtEmployeePanelEdit.TileImage")));
			this.mtEmployeePanelEdit.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtEmployeePanelEdit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.mtEmployeePanelEdit.UseTileImage = true;
			this.mtEmployeePanelEdit.Click += new System.EventHandler(this.mtEmployeePanelEdit_Click);
			// 
			// mtEmployeePanelAdd
			// 
			this.mtEmployeePanelAdd.Location = new System.Drawing.Point(119, 93);
			this.mtEmployeePanelAdd.Name = "mtEmployeePanelAdd";
			this.mtEmployeePanelAdd.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelAdd.TabIndex = 6;
			this.mtEmployeePanelAdd.Text = "Add";
			this.mtEmployeePanelAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mtEmployeePanelAdd.TileImage = ((System.Drawing.Image)(resources.GetObject("mtEmployeePanelAdd.TileImage")));
			this.mtEmployeePanelAdd.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtEmployeePanelAdd.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.mtEmployeePanelAdd.UseTileImage = true;
			this.mtEmployeePanelAdd.Click += new System.EventHandler(this.mtEmployeePanelAdd_Click);
			// 
			// mtEmployeePanelRefresh
			// 
			this.mtEmployeePanelRefresh.Location = new System.Drawing.Point(23, 93);
			this.mtEmployeePanelRefresh.Name = "mtEmployeePanelRefresh";
			this.mtEmployeePanelRefresh.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelRefresh.TabIndex = 7;
			this.mtEmployeePanelRefresh.Text = "Refresh";
			this.mtEmployeePanelRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mtEmployeePanelRefresh.TileImage = ((System.Drawing.Image)(resources.GetObject("mtEmployeePanelRefresh.TileImage")));
			this.mtEmployeePanelRefresh.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtEmployeePanelRefresh.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.mtEmployeePanelRefresh.UseTileImage = true;
			this.mtEmployeePanelRefresh.Click += new System.EventHandler(this.mtEmployeePanelRefresh_Click);
			// 
			// metroTile1
			// 
			this.metroTile1.Location = new System.Drawing.Point(555, 93);
			this.metroTile1.Name = "metroTile1";
			this.metroTile1.Size = new System.Drawing.Size(90, 78);
			this.metroTile1.TabIndex = 9;
			this.metroTile1.Text = "Close";
			this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
			this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile1.UseTileImage = true;
			this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
			// 
			// SupplierPanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(675, 544);
			this.Controls.Add(this.metroTile1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.mtEmployeePanelSave);
			this.Controls.Add(this.mtEmployeePanelDelete);
			this.Controls.Add(this.mtEmployeePanelEdit);
			this.Controls.Add(this.mtEmployeePanelAdd);
			this.Controls.Add(this.mtEmployeePanelRefresh);
			this.Name = "SupplierPanel";
			this.Text = "Supplier Panel";
			this.Load += new System.EventHandler(this.SupplierPanel_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTile mtEmployeePanelSave;
        private MetroFramework.Controls.MetroTile mtEmployeePanelDelete;
        private MetroFramework.Controls.MetroTile mtEmployeePanelEdit;
        private MetroFramework.Controls.MetroTile mtEmployeePanelAdd;
        private MetroFramework.Controls.MetroTile mtEmployeePanelRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource supplierBindingSource;
		private MetroFramework.Controls.MetroTile metroTile1;
	}
}