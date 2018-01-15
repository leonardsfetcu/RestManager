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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
			this.metroTile3 = new MetroFramework.Controls.MetroTile();
			this.mt = new MetroFramework.Controls.MetroTile();
			this.mtEmployees = new MetroFramework.Controls.MetroTile();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.metroTileProducts = new MetroFramework.Controls.MetroTile();
			this.metroInvoices = new MetroFramework.Controls.MetroTile();
			this.metroTile2 = new MetroFramework.Controls.MetroTile();
			this.metroTile4 = new MetroFramework.Controls.MetroTile();
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
			this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
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
			this.mt.Click += new System.EventHandler(this.mt_Click);
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
			this.metroTile1.Location = new System.Drawing.Point(409, 93);
			this.metroTile1.Name = "metroTile1";
			this.metroTile1.Size = new System.Drawing.Size(90, 78);
			this.metroTile1.TabIndex = 1;
			this.metroTile1.Text = "Suppliers";
			this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
			this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile1.UseTileImage = true;
			this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
			// 
			// metroTileProducts
			// 
			this.metroTileProducts.Location = new System.Drawing.Point(313, 93);
			this.metroTileProducts.Name = "metroTileProducts";
			this.metroTileProducts.Size = new System.Drawing.Size(90, 78);
			this.metroTileProducts.TabIndex = 1;
			this.metroTileProducts.Text = "Products";
			this.metroTileProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTileProducts.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileProducts.TileImage")));
			this.metroTileProducts.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.metroTileProducts.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTileProducts.UseTileImage = true;
			this.metroTileProducts.Click += new System.EventHandler(this.metroTileProducts_Click);
			// 
			// metroInvoices
			// 
			this.metroInvoices.Location = new System.Drawing.Point(601, 93);
			this.metroInvoices.Name = "metroInvoices";
			this.metroInvoices.Size = new System.Drawing.Size(90, 78);
			this.metroInvoices.TabIndex = 0;
			this.metroInvoices.Text = "Invoices";
			this.metroInvoices.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroInvoices.TileImage = ((System.Drawing.Image)(resources.GetObject("metroInvoices.TileImage")));
			this.metroInvoices.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.metroInvoices.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroInvoices.UseTileImage = true;
			this.metroInvoices.Click += new System.EventHandler(this.metroInvoices_Click);
			// 
			// metroTile2
			// 
			this.metroTile2.Location = new System.Drawing.Point(505, 93);
			this.metroTile2.Name = "metroTile2";
			this.metroTile2.Size = new System.Drawing.Size(90, 78);
			this.metroTile2.TabIndex = 0;
			this.metroTile2.Text = "Menu";
			this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
			this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile2.UseTileImage = true;
			this.metroTile2.Click += new System.EventHandler(this.metroTile4_Click);
			// 
			// metroTile4
			// 
			this.metroTile4.Location = new System.Drawing.Point(604, 347);
			this.metroTile4.Name = "metroTile4";
			this.metroTile4.Size = new System.Drawing.Size(90, 78);
			this.metroTile4.TabIndex = 0;
			this.metroTile4.Text = "Log Out";
			this.metroTile4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile4.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile4.TileImage")));
			this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
			this.metroTile4.UseTileImage = true;
			this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click_1);
			// 
			// MainPanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(717, 448);
			this.Controls.Add(this.metroTileProducts);
			this.Controls.Add(this.metroTile1);
			this.Controls.Add(this.metroTile2);
			this.Controls.Add(this.metroInvoices);
			this.Controls.Add(this.metroTile3);
			this.Controls.Add(this.mt);
			this.Controls.Add(this.metroTile4);
			this.Controls.Add(this.mtEmployees);
			this.Name = "MainPanel";
			this.Text = "Restaurant Manager PRO";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPanel_FormClosing);
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
		private MetroFramework.Controls.MetroTile metroTile2;
		private MetroFramework.Controls.MetroTile metroTile4;
	}
}

