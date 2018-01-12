namespace Manager
{
    partial class MainPanel
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
          this.metroTile3 = new MetroFramework.Controls.MetroTile();
          this.mt = new MetroFramework.Controls.MetroTile();
          this.mtEmployees = new MetroFramework.Controls.MetroTile();
          this.metroTile1 = new MetroFramework.Controls.MetroTile();
          this.metroTileProducts = new MetroFramework.Controls.MetroTile();
          this.metroInvoices = new MetroFramework.Controls.MetroTile();
          this.SuspendLayout();
          // 
          // metroTile3
          // 
          this.metroTile3.Location = new System.Drawing.Point(217, 93);
          this.metroTile3.Name = "metroTile3";
          this.metroTile3.Size = new System.Drawing.Size(90, 78);
          this.metroTile3.TabIndex = 0;
          this.metroTile3.Text = "Kitchen";
          this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
          this.metroTile3.TileImage = global::Manager.Properties.Resources.icons8_kitchen_64;
          this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
          this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
          this.metroTile3.UseTileImage = true;
          // 
          // mt
          // 
          this.mt.Location = new System.Drawing.Point(119, 93);
          this.mt.Name = "mt";
          this.mt.Size = new System.Drawing.Size(90, 78);
          this.mt.TabIndex = 0;
          this.mt.Text = "Store";
          this.mt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
          this.mt.TileImage = global::Manager.Properties.Resources.icons8_warehouse_641;
          this.mt.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
          this.mt.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
          this.mt.UseTileImage = true;
          // 
          // mtEmployees
          // 
          this.mtEmployees.Location = new System.Drawing.Point(23, 93);
          this.mtEmployees.Name = "mtEmployees";
          this.mtEmployees.Size = new System.Drawing.Size(90, 78);
          this.mtEmployees.TabIndex = 0;
          this.mtEmployees.Text = "Employees";
          this.mtEmployees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
          this.mtEmployees.TileImage = global::Manager.Properties.Resources.user_291;
          this.mtEmployees.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
          this.mtEmployees.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
          this.mtEmployees.UseTileImage = true;
          this.mtEmployees.Click += new System.EventHandler(this.mtEmployees_Click);
          // 
          // metroTile1
          // 
          this.metroTile1.Location = new System.Drawing.Point(119, 421);
          this.metroTile1.Name = "metroTile1";
          this.metroTile1.Size = new System.Drawing.Size(90, 78);
          this.metroTile1.TabIndex = 1;
          this.metroTile1.Text = "Suppliers";
          this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
          this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
          this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
          // 
          // metroTileProducts
          // 
          this.metroTileProducts.Location = new System.Drawing.Point(23, 421);
          this.metroTileProducts.Name = "metroTileProducts";
          this.metroTileProducts.Size = new System.Drawing.Size(90, 78);
          this.metroTileProducts.TabIndex = 1;
          this.metroTileProducts.Text = "Products";
          this.metroTileProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
          this.metroTileProducts.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
          this.metroTileProducts.Click += new System.EventHandler(this.metroTileProducts_Click);
          // 
          // metroInvoices
          // 
          this.metroInvoices.Location = new System.Drawing.Point(217, 177);
          this.metroInvoices.Name = "metroInvoices";
          this.metroInvoices.Size = new System.Drawing.Size(90, 78);
          this.metroInvoices.TabIndex = 0;
          this.metroInvoices.Text = "Invoices";
          this.metroInvoices.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
          this.metroInvoices.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
          this.metroInvoices.Click += new System.EventHandler(this.metroInvoices_Click);
          // 
          // MainPanel
          // 
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
          this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
          this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
          this.ClientSize = new System.Drawing.Size(793, 534);
          this.Controls.Add(this.metroTileProducts);
          this.Controls.Add(this.metroTile1);
          this.Controls.Add(this.metroInvoices);
          this.Controls.Add(this.metroTile3);
          this.Controls.Add(this.mt);
          this.Controls.Add(this.mtEmployees);
          this.Name = "MainPanel";
          this.Text = "Restaurant Manager PRO";
          this.Load += new System.EventHandler(this.MainPanel_Load);
          this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtEmployees;
        private MetroFramework.Controls.MetroTile mt;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile mtMenu;
        private MetroFramework.Controls.MetroTile metroTile1;
		private MetroFramework.Controls.MetroTile metroTileProducts;
		private MetroFramework.Controls.MetroTile metroInvoices;
	}
}

