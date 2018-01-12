namespace Manager
{
    partial class MenuDetails
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtType = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtCook = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtWeight = new MetroFramework.Controls.MetroTextBox();
            this.cancel = new MetroFramework.Controls.MetroTile();
            this.ok = new MetroFramework.Controls.MetroTile();
            this.bindingSourceMenu = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMenu, "Name", true));
            this.txtName.Location = new System.Drawing.Point(123, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 23);
            this.txtName.TabIndex = 1;
            this.txtName.Text = " ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMenu, "Price", true));
            this.txtPrice.Location = new System.Drawing.Point(123, 112);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(180, 23);
            this.txtPrice.TabIndex = 2;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 145);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Type";
            // 
            // txtType
            // 
            this.txtType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMenu, "Type", true));
            this.txtType.Location = new System.Drawing.Point(123, 141);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(180, 23);
            this.txtType.TabIndex = 3;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 174);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(91, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Cooking Time";
            // 
            // txtCook
            // 
            this.txtCook.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMenu, "CookingTime", true));
            this.txtCook.Location = new System.Drawing.Point(123, 170);
            this.txtCook.Name = "txtCook";
            this.txtCook.Size = new System.Drawing.Size(180, 23);
            this.txtCook.TabIndex = 4;
            this.txtCook.Validating += new System.ComponentModel.CancelEventHandler(this.txtCook_Validating);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 203);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMenu, "Weight", true));
            this.txtWeight.Location = new System.Drawing.Point(123, 199);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(180, 23);
            this.txtWeight.TabIndex = 5;
            // 
            // cancel
            // 
            this.cancel.CustomBackground = true;
            this.cancel.Location = new System.Drawing.Point(306, 230);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(64, 64);
            this.cancel.TabIndex = 36;
            this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancel.TileImage = global::Manager.Properties.Resources.icons8_delete_64;
            this.cancel.UseTileImage = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.CustomBackground = true;
            this.ok.Location = new System.Drawing.Point(391, 230);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(64, 64);
            this.ok.TabIndex = 37;
            this.ok.TileImage = global::Manager.Properties.Resources.icons8_checkmark_64;
            this.ok.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ok.UseTileImage = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // bindingSourceMenu
            // 
            this.bindingSourceMenu.DataSource = typeof(Manager.Menu);
            // 
            // MenuDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 305);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtCook);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel1);
            this.Name = "MenuDetails";
            this.Text = "Menu Details";
            this.Load += new System.EventHandler(this.MenuDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtType;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtCook;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtWeight;
        private System.Windows.Forms.BindingSource bindingSourceMenu;
        private MetroFramework.Controls.MetroTile cancel;
        private MetroFramework.Controls.MetroTile ok;
    }
}