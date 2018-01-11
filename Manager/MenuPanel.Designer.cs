namespace Manager
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
            this.mtRefresh = new MetroFramework.Controls.MetroTile();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.mtEdit = new MetroFramework.Controls.MetroTile();
            this.mtDelete = new MetroFramework.Controls.MetroTile();
            this.mtSave = new MetroFramework.Controls.MetroTile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.mtRefresh.Click += new System.EventHandler(this.mtRefresh_Click);
            // 
            // mtAdd
            // 
            this.mtAdd.Location = new System.Drawing.Point(112, 85);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(83, 77);
            this.mtAdd.TabIndex = 0;
            this.mtAdd.Text = "Add";
            this.mtAdd.Click += new System.EventHandler(this.mtAdd_Click);
            // 
            // mtEdit
            // 
            this.mtEdit.Location = new System.Drawing.Point(201, 85);
            this.mtEdit.Name = "mtEdit";
            this.mtEdit.Size = new System.Drawing.Size(83, 77);
            this.mtEdit.TabIndex = 0;
            this.mtEdit.Text = "Edit";
            this.mtEdit.Click += new System.EventHandler(this.mtEdit_Click);
            // 
            // mtDelete
            // 
            this.mtDelete.Location = new System.Drawing.Point(290, 85);
            this.mtDelete.Name = "mtDelete";
            this.mtDelete.Size = new System.Drawing.Size(83, 77);
            this.mtDelete.TabIndex = 0;
            this.mtDelete.Text = "Delete";
            this.mtDelete.Click += new System.EventHandler(this.mtDelete_Click);
            // 
            // mtSave
            // 
            this.mtSave.Location = new System.Drawing.Point(379, 85);
            this.mtSave.Name = "mtSave";
            this.mtSave.Size = new System.Drawing.Size(83, 77);
            this.mtSave.TabIndex = 0;
            this.mtSave.Text = "Save";
            this.mtSave.Click += new System.EventHandler(this.mtSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.cookingTimeDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.menuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(681, 211);
            this.dataGridView1.TabIndex = 1;
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
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // cookingTimeDataGridViewTextBoxColumn
            // 
            this.cookingTimeDataGridViewTextBoxColumn.DataPropertyName = "CookingTime";
            this.cookingTimeDataGridViewTextBoxColumn.HeaderText = "CookingTime";
            this.cookingTimeDataGridViewTextBoxColumn.Name = "cookingTimeDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataSource = typeof(Manager.Menu);
            // 
            // MenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 402);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mtSave);
            this.Controls.Add(this.mtDelete);
            this.Controls.Add(this.mtEdit);
            this.Controls.Add(this.mtAdd);
            this.Controls.Add(this.mtRefresh);
            this.Name = "MenuPanel";
            this.Text = "Menu Panel";
            this.Load += new System.EventHandler(this.MenuPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource menuBindingSource;
    }
}