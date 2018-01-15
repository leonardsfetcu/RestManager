namespace Manager
{
    partial class TransferNoteUnitPanel
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
            this.panelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitsInStoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.metroTileFinish = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxProduct = new MetroFramework.Controls.MetroComboBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxQuantity = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBindingSource
            // 
            this.panelBindingSource.DataSource = typeof(Manager.TransfetNoteUnit);
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
            // unitsInStoreDataGridViewTextBoxColumn
            // 
            this.unitsInStoreDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStore";
            this.unitsInStoreDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.unitsInStoreDataGridViewTextBoxColumn.Name = "unitsInStoreDataGridViewTextBoxColumn";
            this.unitsInStoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitsInStoreDataGridViewTextBoxColumn.Width = 70;
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.DataSource = this.unitBindingSource;
            this.unitIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unitIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unitIDDataGridViewTextBoxColumn.ValueMember = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.Width = 70;
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
            // tVADataGridViewTextBoxColumn
            // 
            this.tVADataGridViewTextBoxColumn.DataPropertyName = "TVA";
            this.tVADataGridViewTextBoxColumn.HeaderText = "TVA";
            this.tVADataGridViewTextBoxColumn.Name = "tVADataGridViewTextBoxColumn";
            this.tVADataGridViewTextBoxColumn.ReadOnly = true;
            this.tVADataGridViewTextBoxColumn.Width = 60;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AutoGenerateColumns = false;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.tVADataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.unitsInStoreDataGridViewTextBoxColumn});
            this.dataGridViewProducts.DataSource = this.productBindingSource;
            this.dataGridViewProducts.Location = new System.Drawing.Point(15, 255);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.Size = new System.Drawing.Size(598, 239);
            this.dataGridViewProducts.TabIndex = 58;
            // 
            // metroTileFinish
            // 
            this.metroTileFinish.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.metroTileFinish.Location = new System.Drawing.Point(15, 503);
            this.metroTileFinish.Margin = new System.Windows.Forms.Padding(4);
            this.metroTileFinish.Name = "metroTileFinish";
            this.metroTileFinish.Size = new System.Drawing.Size(598, 50);
            this.metroTileFinish.TabIndex = 60;
            this.metroTileFinish.Text = "Finish Transfer";
            this.metroTileFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileFinish.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTileFinish.Click += new System.EventHandler(this.metroTileFinish_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.Location = new System.Drawing.Point(17, 144);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(143, 20);
            this.metroLabel5.TabIndex = 52;
            this.metroLabel5.Text = "Select an old product:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel6.Location = new System.Drawing.Point(193, 90);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(160, 25);
            this.metroLabel6.TabIndex = 53;
            this.metroLabel6.Text = "Product Selection: ";
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.Location = new System.Drawing.Point(17, 181);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 20);
            this.metroLabel4.TabIndex = 54;
            this.metroLabel4.Text = "Quantity:";
            // 
            // metroComboBoxProduct
            // 
            this.metroComboBoxProduct.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.panelBindingSource, "ProductID", true));
            this.metroComboBoxProduct.FormattingEnabled = true;
            this.metroComboBoxProduct.ItemHeight = 24;
            this.metroComboBoxProduct.Location = new System.Drawing.Point(193, 142);
            this.metroComboBoxProduct.Margin = new System.Windows.Forms.Padding(4);
            this.metroComboBoxProduct.Name = "metroComboBoxProduct";
            this.metroComboBoxProduct.Size = new System.Drawing.Size(299, 30);
            this.metroComboBoxProduct.TabIndex = 55;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(507, 139);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(106, 36);
            this.metroButton3.TabIndex = 56;
            this.metroButton3.Text = "Add Product";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroTextBoxQuantity
            // 
            this.metroTextBoxQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.panelBindingSource, "Quantity", true));
            this.metroTextBoxQuantity.Location = new System.Drawing.Point(193, 178);
            this.metroTextBoxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxQuantity.Name = "metroTextBoxQuantity";
            this.metroTextBoxQuantity.Size = new System.Drawing.Size(106, 28);
            this.metroTextBoxQuantity.TabIndex = 59;
            // 
            // TransferNoteUnitPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(630, 576);
            this.Controls.Add(this.metroTileFinish);
            this.Controls.Add(this.metroTextBoxQuantity);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroComboBoxProduct);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Name = "TransferNoteUnitPanel";
            this.Text = "Transfer Note Details Panel";
            this.Load += new System.EventHandler(this.TransferNoteDetailsPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.BindingSource panelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsInStoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private MetroFramework.Controls.MetroTile metroTileFinish;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox metroComboBoxProduct;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxQuantity;
    }
}