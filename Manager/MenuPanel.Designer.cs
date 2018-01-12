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
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CookingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
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
            this.Name,
            this.TypeID,
            this.CookingTime,
            this.Weight,
            this.Price});
            this.dataGridView1.DataSource = this.menuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(681, 211);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataSource = typeof(Manager.Menu);
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataSource = typeof(Manager.Type);
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
          //  this.Name = "Menu Panel";
            this.Text = "Menu Panel";
            this.Load += new System.EventHandler(this.MenuPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
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
    }
}