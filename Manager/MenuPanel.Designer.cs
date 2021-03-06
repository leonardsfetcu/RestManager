﻿namespace Manager
{
    partial class MenuPanel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPanel));
			this.mtRefresh = new MetroFramework.Controls.MetroTile();
			this.mtAdd = new MetroFramework.Controls.MetroTile();
			this.mtEdit = new MetroFramework.Controls.MetroTile();
			this.mtDelete = new MetroFramework.Controls.MetroTile();
			this.mtSave = new MetroFramework.Controls.MetroTile();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TypeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.CookingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cookingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ingredientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mtEmployeePanelSave = new MetroFramework.Controls.MetroTile();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// mtRefresh
			// 
			this.mtRefresh.Location = new System.Drawing.Point(23, 85);
			this.mtRefresh.Name = "mtRefresh";
			this.mtRefresh.Size = new System.Drawing.Size(83, 77);
			this.mtRefresh.TabIndex = 0;
			this.mtRefresh.Text = "Refresh";
			this.mtRefresh.TileImage = ((System.Drawing.Image)(resources.GetObject("mtRefresh.TileImage")));
			this.mtRefresh.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtRefresh.UseTileImage = true;
			this.mtRefresh.Click += new System.EventHandler(this.mtRefresh_Click);
			// 
			// mtAdd
			// 
			this.mtAdd.Location = new System.Drawing.Point(112, 85);
			this.mtAdd.Name = "mtAdd";
			this.mtAdd.Size = new System.Drawing.Size(83, 77);
			this.mtAdd.TabIndex = 0;
			this.mtAdd.Text = "Add";
			this.mtAdd.TileImage = ((System.Drawing.Image)(resources.GetObject("mtAdd.TileImage")));
			this.mtAdd.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtAdd.UseTileImage = true;
			this.mtAdd.Click += new System.EventHandler(this.mtAdd_Click);
			// 
			// mtEdit
			// 
			this.mtEdit.Location = new System.Drawing.Point(201, 85);
			this.mtEdit.Name = "mtEdit";
			this.mtEdit.Size = new System.Drawing.Size(83, 77);
			this.mtEdit.TabIndex = 0;
			this.mtEdit.Text = "Edit";
			this.mtEdit.TileImage = ((System.Drawing.Image)(resources.GetObject("mtEdit.TileImage")));
			this.mtEdit.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtEdit.UseTileImage = true;
			this.mtEdit.Click += new System.EventHandler(this.mtEdit_Click);
			// 
			// mtDelete
			// 
			this.mtDelete.Location = new System.Drawing.Point(290, 85);
			this.mtDelete.Name = "mtDelete";
			this.mtDelete.Size = new System.Drawing.Size(83, 77);
			this.mtDelete.TabIndex = 0;
			this.mtDelete.Text = "Delete";
			this.mtDelete.TileImage = ((System.Drawing.Image)(resources.GetObject("mtDelete.TileImage")));
			this.mtDelete.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtDelete.UseTileImage = true;
			this.mtDelete.Click += new System.EventHandler(this.mtDelete_Click);
			// 
			// mtSave
			// 
			this.mtSave.Location = new System.Drawing.Point(379, 85);
			this.mtSave.Name = "mtSave";
			this.mtSave.Size = new System.Drawing.Size(83, 77);
			this.mtSave.TabIndex = 0;
			this.mtSave.Text = "Save";
			this.mtSave.TileImage = ((System.Drawing.Image)(resources.GetObject("mtSave.TileImage")));
			this.mtSave.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtSave.UseTileImage = true;
			this.mtSave.Click += new System.EventHandler(this.mtSave_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.TypeID,
            this.CookingTime,
            this.Weight,
            this.Price,
            this.menuIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.typeIDDataGridViewTextBoxColumn,
            this.cookingTimeDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn,
            this.weightDataGridViewTextBoxColumn,
            this.ingredientsDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.menuBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(23, 168);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(681, 211);
			this.dataGridView1.TabIndex = 1;
			// 
			// Name
			// 
			this.Name.DataPropertyName = "Name";
			this.Name.HeaderText = "Name";
			this.Name.Name = "Name";
			// 
			// TypeID
			// 
			this.TypeID.DataPropertyName = "TypeID";
			this.TypeID.DataSource = this.typeBindingSource;
			this.TypeID.DisplayMember = "Name";
			this.TypeID.HeaderText = "Type";
			this.TypeID.Name = "TypeID";
			this.TypeID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.TypeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.TypeID.ValueMember = "TypeID";
			// 
			// typeBindingSource
			// 
			this.typeBindingSource.DataSource = typeof(Manager.Type);
			// 
			// CookingTime
			// 
			this.CookingTime.DataPropertyName = "CookingTime";
			this.CookingTime.HeaderText = "CookingTime";
			this.CookingTime.Name = "CookingTime";
			// 
			// Weight
			// 
			this.Weight.DataPropertyName = "Weight";
			this.Weight.HeaderText = "Weight";
			this.Weight.Name = "Weight";
			// 
			// Price
			// 
			this.Price.DataPropertyName = "Price";
			this.Price.HeaderText = "Price";
			this.Price.Name = "Price";
			// 
			// menuIDDataGridViewTextBoxColumn
			// 
			this.menuIDDataGridViewTextBoxColumn.DataPropertyName = "MenuID";
			this.menuIDDataGridViewTextBoxColumn.HeaderText = "MenuID";
			this.menuIDDataGridViewTextBoxColumn.Name = "menuIDDataGridViewTextBoxColumn";
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			// 
			// typeIDDataGridViewTextBoxColumn
			// 
			this.typeIDDataGridViewTextBoxColumn.DataPropertyName = "TypeID";
			this.typeIDDataGridViewTextBoxColumn.HeaderText = "TypeID";
			this.typeIDDataGridViewTextBoxColumn.Name = "typeIDDataGridViewTextBoxColumn";
			// 
			// cookingTimeDataGridViewTextBoxColumn
			// 
			this.cookingTimeDataGridViewTextBoxColumn.DataPropertyName = "CookingTime";
			this.cookingTimeDataGridViewTextBoxColumn.HeaderText = "CookingTime";
			this.cookingTimeDataGridViewTextBoxColumn.Name = "cookingTimeDataGridViewTextBoxColumn";
			// 
			// imageDataGridViewImageColumn
			// 
			this.imageDataGridViewImageColumn.DataPropertyName = "Image";
			this.imageDataGridViewImageColumn.HeaderText = "Image";
			this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
			// 
			// weightDataGridViewTextBoxColumn
			// 
			this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
			this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
			this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
			// 
			// ingredientsDataGridViewTextBoxColumn
			// 
			this.ingredientsDataGridViewTextBoxColumn.DataPropertyName = "Ingredients";
			this.ingredientsDataGridViewTextBoxColumn.HeaderText = "Ingredients";
			this.ingredientsDataGridViewTextBoxColumn.Name = "ingredientsDataGridViewTextBoxColumn";
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			// 
			// menuBindingSource
			// 
			this.menuBindingSource.DataSource = typeof(Manager.Menu);
			// 
			// mtEmployeePanelSave
			// 
			this.mtEmployeePanelSave.Location = new System.Drawing.Point(614, 84);
			this.mtEmployeePanelSave.Name = "mtEmployeePanelSave";
			this.mtEmployeePanelSave.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelSave.TabIndex = 3;
			this.mtEmployeePanelSave.Text = "Close";
			this.mtEmployeePanelSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mtEmployeePanelSave.TileImage = ((System.Drawing.Image)(resources.GetObject("mtEmployeePanelSave.TileImage")));
			this.mtEmployeePanelSave.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtEmployeePanelSave.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.mtEmployeePanelSave.UseTileImage = true;
			this.mtEmployeePanelSave.Click += new System.EventHandler(this.mtEmployeePanelSave_Click);
			// 
			// MenuPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(727, 402);
			this.Controls.Add(this.mtEmployeePanelSave);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.mtSave);
			this.Controls.Add(this.mtDelete);
			this.Controls.Add(this.mtEdit);
			this.Controls.Add(this.mtAdd);
			this.Controls.Add(this.mtRefresh);
			this.Text = "Menu Panel";
			this.Load += new System.EventHandler(this.MenuPanel_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtRefresh;
        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Controls.MetroTile mtEdit;
        private MetroFramework.Controls.MetroTile mtDelete;
        private MetroFramework.Controls.MetroTile mtSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypeID;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CookingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn menuIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cookingTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ingredientsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private MetroFramework.Controls.MetroTile mtEmployeePanelSave;
	}
}