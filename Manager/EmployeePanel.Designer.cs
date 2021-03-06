﻿namespace Manager
{
    partial class EmployeePanel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePanel));
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.mtEmployeePanelSave = new MetroFramework.Controls.MetroTile();
			this.mtEmployeePanelDelete = new MetroFramework.Controls.MetroTile();
			this.mtEmployeePanelEdit = new MetroFramework.Controls.MetroTile();
			this.mtEmployeePanelAdd = new MetroFramework.Controls.MetroTile();
			this.mtEmployeePanelRefresh = new MetroFramework.Controls.MetroTile();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Role";
			this.dataGridViewTextBoxColumn1.HeaderText = "Role";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Role";
			this.dataGridViewTextBoxColumn2.HeaderText = "Role";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Role";
			this.dataGridViewTextBoxColumn3.HeaderText = "Role";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.roleIDDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.employeeBindingSource;
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView1.Location = new System.Drawing.Point(23, 180);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(765, 367);
			this.dataGridView1.TabIndex = 2;
			// 
			// mtEmployeePanelSave
			// 
			this.mtEmployeePanelSave.Location = new System.Drawing.Point(407, 93);
			this.mtEmployeePanelSave.Name = "mtEmployeePanelSave";
			this.mtEmployeePanelSave.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelSave.TabIndex = 1;
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
			this.mtEmployeePanelDelete.Location = new System.Drawing.Point(311, 93);
			this.mtEmployeePanelDelete.Name = "mtEmployeePanelDelete";
			this.mtEmployeePanelDelete.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelDelete.TabIndex = 1;
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
			this.mtEmployeePanelEdit.Location = new System.Drawing.Point(215, 93);
			this.mtEmployeePanelEdit.Name = "mtEmployeePanelEdit";
			this.mtEmployeePanelEdit.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelEdit.TabIndex = 1;
			this.mtEmployeePanelEdit.Text = "Edit";
			this.mtEmployeePanelEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mtEmployeePanelEdit.TileImage = global::Manager.Properties.Resources.rsz_user_32;
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
			this.mtEmployeePanelAdd.TabIndex = 1;
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
			this.mtEmployeePanelRefresh.Location = new System.Drawing.Point(23, 93);
			this.mtEmployeePanelRefresh.Name = "mtEmployeePanelRefresh";
			this.mtEmployeePanelRefresh.Size = new System.Drawing.Size(90, 78);
			this.mtEmployeePanelRefresh.TabIndex = 1;
			this.mtEmployeePanelRefresh.Text = "Refresh";
			this.mtEmployeePanelRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.mtEmployeePanelRefresh.TileImage = global::Manager.Properties.Resources.rsz_user_35;
			this.mtEmployeePanelRefresh.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.mtEmployeePanelRefresh.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.mtEmployeePanelRefresh.UseTileImage = true;
			this.mtEmployeePanelRefresh.Click += new System.EventHandler(this.mtEmployeePanelRefresh_Click);
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			// 
			// roleIDDataGridViewTextBoxColumn
			// 
			this.roleIDDataGridViewTextBoxColumn.DataPropertyName = "RoleID";
			this.roleIDDataGridViewTextBoxColumn.DataSource = this.roleBindingSource;
			this.roleIDDataGridViewTextBoxColumn.DisplayMember = "Name";
			this.roleIDDataGridViewTextBoxColumn.HeaderText = "Role";
			this.roleIDDataGridViewTextBoxColumn.Name = "roleIDDataGridViewTextBoxColumn";
			this.roleIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.roleIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.roleIDDataGridViewTextBoxColumn.ValueMember = "RoleID";
			// 
			// roleBindingSource
			// 
			this.roleBindingSource.DataSource = typeof(Manager.Role);
			// 
			// cNPDataGridViewTextBoxColumn
			// 
			this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
			this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
			this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
			// 
			// phoneDataGridViewTextBoxColumn
			// 
			this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
			this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
			this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
			// 
			// adressDataGridViewTextBoxColumn
			// 
			this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
			this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
			this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
			this.adressDataGridViewTextBoxColumn.Width = 120;
			// 
			// employeeBindingSource
			// 
			this.employeeBindingSource.DataSource = typeof(Manager.Employee);
			// 
			// metroTile1
			// 
			this.metroTile1.Location = new System.Drawing.Point(697, 93);
			this.metroTile1.Name = "metroTile1";
			this.metroTile1.Size = new System.Drawing.Size(90, 78);
			this.metroTile1.TabIndex = 3;
			this.metroTile1.Text = "Close";
			this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
			this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile1.UseTileImage = true;
			this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
			// 
			// EmployeePanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(810, 570);
			this.Controls.Add(this.metroTile1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.mtEmployeePanelSave);
			this.Controls.Add(this.mtEmployeePanelDelete);
			this.Controls.Add(this.mtEmployeePanelEdit);
			this.Controls.Add(this.mtEmployeePanelAdd);
			this.Controls.Add(this.mtEmployeePanelRefresh);
			this.Name = "EmployeePanel";
			this.Text = "Employee Panel";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeePanel_FormClosing);
			this.Load += new System.EventHandler(this.EmployeePanel_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtEmployeePanelRefresh;
        private MetroFramework.Controls.MetroTile mtEmployeePanelAdd;
        private MetroFramework.Controls.MetroTile mtEmployeePanelEdit;
        private MetroFramework.Controls.MetroTile mtEmployeePanelDelete;
        private MetroFramework.Controls.MetroTile mtEmployeePanelSave;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn roleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
		private MetroFramework.Controls.MetroTile metroTile1;
	}
}