namespace Manager
{
    partial class SupplierDetails
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTileSave = new MetroFramework.Controls.MetroTile();
            this.metroTileCancel = new MetroFramework.Controls.MetroTile();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTileSave);
            this.metroPanel1.Controls.Add(this.metroTileCancel);
            this.metroPanel1.Controls.Add(this.metroTextBox3);
            this.metroPanel1.Controls.Add(this.metroTextBox2);
            this.metroPanel1.Controls.Add(this.metroTextBox1);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 87);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(494, 340);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 53);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Company Name:";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Name", true));
            this.metroTextBox1.Location = new System.Drawing.Point(151, 53);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(191, 23);
            this.metroTextBox1.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 93);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(31, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "CIF:";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "CIF", true));
            this.metroTextBox2.Location = new System.Drawing.Point(151, 96);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(191, 23);
            this.metroTextBox2.TabIndex = 3;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.Location = new System.Drawing.Point(32, 139);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Adress:";
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Adress", true));
            this.metroTextBox3.Location = new System.Drawing.Point(151, 142);
            this.metroTextBox3.Multiline = true;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(323, 108);
            this.metroTextBox3.TabIndex = 3;
            // 
            // metroTileSave
            // 
            this.metroTileSave.CustomBackground = true;
            this.metroTileSave.Location = new System.Drawing.Point(429, 273);
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
            this.metroTileCancel.Location = new System.Drawing.Point(344, 273);
            this.metroTileCancel.Name = "metroTileCancel";
            this.metroTileCancel.Size = new System.Drawing.Size(64, 64);
            this.metroTileCancel.TabIndex = 36;
            this.metroTileCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileCancel.TileImage = global::Manager.Properties.Resources.icons8_delete_64;
            this.metroTileCancel.UseTileImage = true;
            this.metroTileCancel.Click += new System.EventHandler(this.metroTileCancel_Click);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(Manager.Supplier);
            // 
            // SupplierDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.metroPanel1);
            this.Name = "SupplierDetails";
            this.Text = "SupplierDetails";
            this.Load += new System.EventHandler(this.SupplierDetails_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTileSave;
        private MetroFramework.Controls.MetroTile metroTileCancel;
        private System.Windows.Forms.BindingSource supplierBindingSource;
    }
}