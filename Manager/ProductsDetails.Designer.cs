namespace Manager
{
	partial class ProductsDetails
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
			this.lbl1 = new MetroFramework.Controls.MetroLabel();
			this.metroTextBoxProductName = new MetroFramework.Controls.MetroTextBox();
			this.metroTextBoxUnitPrice = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroComboBoxCategory = new MetroFramework.Controls.MetroComboBox();
			this.metroComboBoxUnit = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroTrackBarTVA = new MetroFramework.Controls.MetroTrackBar();
			this.metroLabelTVA = new MetroFramework.Controls.MetroLabel();
			this.metroTileSave = new MetroFramework.Controls.MetroTile();
			this.metroTileCancel = new MetroFramework.Controls.MetroTile();
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lbl1.CustomBackground = true;
			this.lbl1.Location = new System.Drawing.Point(23, 92);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(95, 19);
			this.lbl1.TabIndex = 0;
			this.lbl1.Text = "Product name:";
			// 
			// metroTextBoxProductName
			// 
			this.metroTextBoxProductName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
			this.metroTextBoxProductName.Location = new System.Drawing.Point(192, 88);
			this.metroTextBoxProductName.Name = "metroTextBoxProductName";
			this.metroTextBoxProductName.Size = new System.Drawing.Size(255, 23);
			this.metroTextBoxProductName.TabIndex = 1;
			// 
			// metroTextBoxUnitPrice
			// 
			this.metroTextBoxUnitPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "UnitPrice", true));
			this.metroTextBoxUnitPrice.Location = new System.Drawing.Point(192, 129);
			this.metroTextBoxUnitPrice.Name = "metroTextBoxUnitPrice";
			this.metroTextBoxUnitPrice.Size = new System.Drawing.Size(75, 23);
			this.metroTextBoxUnitPrice.TabIndex = 2;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.metroLabel2.CustomBackground = true;
			this.metroLabel2.Location = new System.Drawing.Point(23, 133);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(68, 19);
			this.metroLabel2.TabIndex = 0;
			this.metroLabel2.Text = "Unit Price:";
			// 
			// metroComboBoxCategory
			// 
			this.metroComboBoxCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "CategoryID", true));
			this.metroComboBoxCategory.FormattingEnabled = true;
			this.metroComboBoxCategory.ItemHeight = 23;
			this.metroComboBoxCategory.Location = new System.Drawing.Point(192, 218);
			this.metroComboBoxCategory.Name = "metroComboBoxCategory";
			this.metroComboBoxCategory.Size = new System.Drawing.Size(121, 29);
			this.metroComboBoxCategory.TabIndex = 4;
			// 
			// metroComboBoxUnit
			// 
			this.metroComboBoxUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "UnitID", true));
			this.metroComboBoxUnit.FormattingEnabled = true;
			this.metroComboBoxUnit.ItemHeight = 23;
			this.metroComboBoxUnit.Location = new System.Drawing.Point(192, 266);
			this.metroComboBoxUnit.Name = "metroComboBoxUnit";
			this.metroComboBoxUnit.Size = new System.Drawing.Size(121, 29);
			this.metroComboBoxUnit.TabIndex = 4;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.metroLabel4.CustomBackground = true;
			this.metroLabel4.Location = new System.Drawing.Point(23, 228);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(67, 19);
			this.metroLabel4.TabIndex = 0;
			this.metroLabel4.Text = "Category:";
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.metroLabel5.CustomBackground = true;
			this.metroLabel5.Location = new System.Drawing.Point(23, 276);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(35, 19);
			this.metroLabel5.TabIndex = 0;
			this.metroLabel5.Text = "Unit:";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.metroLabel3.CustomBackground = true;
			this.metroLabel3.Location = new System.Drawing.Point(23, 178);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(35, 19);
			this.metroLabel3.TabIndex = 0;
			this.metroLabel3.Text = "TVA:";
			// 
			// metroTrackBarTVA
			// 
			this.metroTrackBarTVA.BackColor = System.Drawing.Color.Transparent;
			this.metroTrackBarTVA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "TVA", true));
			this.metroTrackBarTVA.Location = new System.Drawing.Point(192, 174);
			this.metroTrackBarTVA.MouseWheelBarPartitions = 100;
			this.metroTrackBarTVA.Name = "metroTrackBarTVA";
			this.metroTrackBarTVA.Size = new System.Drawing.Size(75, 23);
			this.metroTrackBarTVA.TabIndex = 3;
			this.metroTrackBarTVA.Text = "metroTrackBar1";
			this.metroTrackBarTVA.Value = 24;
			this.metroTrackBarTVA.ValueChanged += new System.EventHandler(this.metroTrackBarTVA_ValueChanged);
			// 
			// metroLabelTVA
			// 
			this.metroLabelTVA.AutoSize = true;
			this.metroLabelTVA.BackColor = System.Drawing.Color.White;
			this.metroLabelTVA.Location = new System.Drawing.Point(273, 178);
			this.metroLabelTVA.Name = "metroLabelTVA";
			this.metroLabelTVA.Size = new System.Drawing.Size(34, 19);
			this.metroLabelTVA.TabIndex = 0;
			this.metroLabelTVA.Text = "24%";
			// 
			// metroTileSave
			// 
			this.metroTileSave.CustomBackground = true;
			this.metroTileSave.Location = new System.Drawing.Point(383, 337);
			this.metroTileSave.Name = "metroTileSave";
			this.metroTileSave.Size = new System.Drawing.Size(64, 64);
			this.metroTileSave.TabIndex = 37;
			this.metroTileSave.TileImage = global::Manager.Properties.Resources.icons8_checkmark_64;
			this.metroTileSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTileSave.UseTileImage = true;
			this.metroTileSave.Click += new System.EventHandler(this.metroTileSave_Click);
			// 
			// metroTileCancel
			// 
			this.metroTileCancel.CustomBackground = true;
			this.metroTileCancel.Location = new System.Drawing.Point(298, 337);
			this.metroTileCancel.Name = "metroTileCancel";
			this.metroTileCancel.Size = new System.Drawing.Size(64, 64);
			this.metroTileCancel.TabIndex = 36;
			this.metroTileCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTileCancel.TileImage = global::Manager.Properties.Resources.icons8_delete_64;
			this.metroTileCancel.UseTileImage = true;
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataSource = typeof(Manager.Product);
			// 
			// ProductsDetails
			// 
			this.AcceptButton = this.metroTileSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(498, 424);
			this.Controls.Add(this.metroTileSave);
			this.Controls.Add(this.metroTileCancel);
			this.Controls.Add(this.metroComboBoxUnit);
			this.Controls.Add(this.metroComboBoxCategory);
			this.Controls.Add(this.metroTrackBarTVA);
			this.Controls.Add(this.metroTextBoxUnitPrice);
			this.Controls.Add(this.metroTextBoxProductName);
			this.Controls.Add(this.metroLabel5);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabelTVA);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.lbl1);
			this.Name = "ProductsDetails";
			this.Text = "ProductsDetails";
			this.Load += new System.EventHandler(this.ProductsDetails_Load);
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel lbl1;
		private MetroFramework.Controls.MetroTextBox metroTextBoxProductName;
		private MetroFramework.Controls.MetroTextBox metroTextBoxUnitPrice;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroComboBox metroComboBoxCategory;
		private MetroFramework.Controls.MetroComboBox metroComboBoxUnit;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private System.Windows.Forms.BindingSource productBindingSource;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroTrackBar metroTrackBarTVA;
		private MetroFramework.Controls.MetroLabel metroLabelTVA;
		private MetroFramework.Controls.MetroTile metroTileSave;
		private MetroFramework.Controls.MetroTile metroTileCancel;
	}
}