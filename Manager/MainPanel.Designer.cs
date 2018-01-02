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
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.mt = new MetroFramework.Controls.MetroTile();
            this.mtEmployees = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile4
            // 
            this.metroTile4.Location = new System.Drawing.Point(313, 93);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(90, 78);
            this.metroTile4.TabIndex = 0;
            this.metroTile4.Text = "metroTile1";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
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
            // MainPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroTile4);
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
        private MetroFramework.Controls.MetroTile metroTile4;
    }
}

