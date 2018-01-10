namespace Manager
{
    partial class EmployeeDetails
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
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTileSave = new MetroFramework.Controls.MetroTile();
            this.metroTileCancel = new MetroFramework.Controls.MetroTile();
            this.metroComboBoxRole = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelRole = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxAdress = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxCNP = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxLastName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxFirstName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelAdress = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPhone = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCNP = new MetroFramework.Controls.MetroLabel();
            this.metroLabelLastName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelFirstName = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Manager.Employee);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroTileSave);
            this.panel1.Controls.Add(this.metroTileCancel);
            this.panel1.Controls.Add(this.metroComboBoxRole);
            this.panel1.Controls.Add(this.metroLabelRole);
            this.panel1.Controls.Add(this.metroTextBoxAdress);
            this.panel1.Controls.Add(this.metroTextBoxPhone);
            this.panel1.Controls.Add(this.metroTextBoxCNP);
            this.panel1.Controls.Add(this.metroTextBoxLastName);
            this.panel1.Controls.Add(this.metroTextBoxFirstName);
            this.panel1.Controls.Add(this.metroLabelAdress);
            this.panel1.Controls.Add(this.metroLabelPhone);
            this.panel1.Controls.Add(this.metroLabelCNP);
            this.panel1.Controls.Add(this.metroLabelLastName);
            this.panel1.Controls.Add(this.metroLabelFirstName);
            this.panel1.Location = new System.Drawing.Point(23, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 376);
            this.panel1.TabIndex = 22;
            // 
            // metroTileSave
            // 
            this.metroTileSave.CustomBackground = true;
            this.metroTileSave.Location = new System.Drawing.Point(404, 287);
            this.metroTileSave.Name = "metroTileSave";
            this.metroTileSave.Size = new System.Drawing.Size(64, 64);
            this.metroTileSave.TabIndex = 35;
            this.metroTileSave.TileImage = global::Manager.Properties.Resources.icons8_checkmark_64;
            this.metroTileSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSave.UseTileImage = true;
            this.metroTileSave.Click += new System.EventHandler(this.metroTileSave_Click);
            // 
            // metroTileCancel
            // 
            this.metroTileCancel.CustomBackground = true;
            this.metroTileCancel.Location = new System.Drawing.Point(319, 287);
            this.metroTileCancel.Name = "metroTileCancel";
            this.metroTileCancel.Size = new System.Drawing.Size(64, 64);
            this.metroTileCancel.TabIndex = 34;
            this.metroTileCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileCancel.TileImage = global::Manager.Properties.Resources.icons8_delete_64;
            this.metroTileCancel.UseTileImage = true;
            this.metroTileCancel.Click += new System.EventHandler(this.metroTileCancel_Click);
            // 
            // metroComboBoxRole
            // 
            this.metroComboBoxRole.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "RoleID", true));
            this.metroComboBoxRole.FormattingEnabled = true;
            this.metroComboBoxRole.ItemHeight = 24;
            this.metroComboBoxRole.Location = new System.Drawing.Point(111, 88);
            this.metroComboBoxRole.Name = "metroComboBoxRole";
            this.metroComboBoxRole.Size = new System.Drawing.Size(152, 30);
            this.metroComboBoxRole.TabIndex = 24;
            // 
            // metroLabelRole
            // 
            this.metroLabelRole.AutoSize = true;
            this.metroLabelRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabelRole.CustomBackground = true;
            this.metroLabelRole.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelRole.Location = new System.Drawing.Point(22, 88);
            this.metroLabelRole.Name = "metroLabelRole";
            this.metroLabelRole.Size = new System.Drawing.Size(42, 20);
            this.metroLabelRole.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabelRole.TabIndex = 31;
            this.metroLabelRole.Text = "Role:";
            // 
            // metroTextBoxAdress
            // 
            this.metroTextBoxAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroTextBoxAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Adress", true));
            this.metroTextBoxAdress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxAdress.Location = new System.Drawing.Point(110, 187);
            this.metroTextBoxAdress.Multiline = true;
            this.metroTextBoxAdress.Name = "metroTextBoxAdress";
            this.metroTextBoxAdress.Size = new System.Drawing.Size(358, 80);
            this.metroTextBoxAdress.TabIndex = 33;
            // 
            // metroTextBoxPhone
            // 
            this.metroTextBoxPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroTextBoxPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Phone", true));
            this.metroTextBoxPhone.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxPhone.Location = new System.Drawing.Point(110, 156);
            this.metroTextBoxPhone.Name = "metroTextBoxPhone";
            this.metroTextBoxPhone.Size = new System.Drawing.Size(291, 23);
            this.metroTextBoxPhone.TabIndex = 32;
            // 
            // metroTextBoxCNP
            // 
            this.metroTextBoxCNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroTextBoxCNP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "CNP", true));
            this.metroTextBoxCNP.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxCNP.Location = new System.Drawing.Point(111, 127);
            this.metroTextBoxCNP.Name = "metroTextBoxCNP";
            this.metroTextBoxCNP.Size = new System.Drawing.Size(291, 23);
            this.metroTextBoxCNP.TabIndex = 30;
            // 
            // metroTextBoxLastName
            // 
            this.metroTextBoxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroTextBoxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "LastName", true));
            this.metroTextBoxLastName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxLastName.Location = new System.Drawing.Point(111, 54);
            this.metroTextBoxLastName.Name = "metroTextBoxLastName";
            this.metroTextBoxLastName.Size = new System.Drawing.Size(291, 23);
            this.metroTextBoxLastName.TabIndex = 23;
            // 
            // metroTextBoxFirstName
            // 
            this.metroTextBoxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroTextBoxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "FirstName", true));
            this.metroTextBoxFirstName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxFirstName.Location = new System.Drawing.Point(111, 25);
            this.metroTextBoxFirstName.Name = "metroTextBoxFirstName";
            this.metroTextBoxFirstName.Size = new System.Drawing.Size(291, 23);
            this.metroTextBoxFirstName.TabIndex = 22;
            // 
            // metroLabelAdress
            // 
            this.metroLabelAdress.AutoSize = true;
            this.metroLabelAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabelAdress.CustomBackground = true;
            this.metroLabelAdress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelAdress.Location = new System.Drawing.Point(22, 188);
            this.metroLabelAdress.Name = "metroLabelAdress";
            this.metroLabelAdress.Size = new System.Drawing.Size(56, 20);
            this.metroLabelAdress.TabIndex = 25;
            this.metroLabelAdress.Text = "Adress:";
            // 
            // metroLabelPhone
            // 
            this.metroLabelPhone.AutoSize = true;
            this.metroLabelPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabelPhone.CustomBackground = true;
            this.metroLabelPhone.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelPhone.Location = new System.Drawing.Point(22, 157);
            this.metroLabelPhone.Name = "metroLabelPhone";
            this.metroLabelPhone.Size = new System.Drawing.Size(53, 20);
            this.metroLabelPhone.TabIndex = 26;
            this.metroLabelPhone.Text = "Phone:";
            // 
            // metroLabelCNP
            // 
            this.metroLabelCNP.AutoSize = true;
            this.metroLabelCNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabelCNP.CustomBackground = true;
            this.metroLabelCNP.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelCNP.Location = new System.Drawing.Point(22, 128);
            this.metroLabelCNP.Name = "metroLabelCNP";
            this.metroLabelCNP.Size = new System.Drawing.Size(40, 20);
            this.metroLabelCNP.TabIndex = 27;
            this.metroLabelCNP.Text = "CNP:";
            // 
            // metroLabelLastName
            // 
            this.metroLabelLastName.AutoSize = true;
            this.metroLabelLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabelLastName.CustomBackground = true;
            this.metroLabelLastName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelLastName.Location = new System.Drawing.Point(22, 55);
            this.metroLabelLastName.Name = "metroLabelLastName";
            this.metroLabelLastName.Size = new System.Drawing.Size(82, 20);
            this.metroLabelLastName.TabIndex = 28;
            this.metroLabelLastName.Text = "Last Name:";
            // 
            // metroLabelFirstName
            // 
            this.metroLabelFirstName.AutoSize = true;
            this.metroLabelFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabelFirstName.CustomBackground = true;
            this.metroLabelFirstName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelFirstName.Location = new System.Drawing.Point(22, 26);
            this.metroLabelFirstName.Name = "metroLabelFirstName";
            this.metroLabelFirstName.Size = new System.Drawing.Size(83, 20);
            this.metroLabelFirstName.TabIndex = 29;
            this.metroLabelFirstName.Text = "First Name:";
            // 
            // EmployeeDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeDetails";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile metroTileSave;
        private MetroFramework.Controls.MetroTile metroTileCancel;
        private MetroFramework.Controls.MetroComboBox metroComboBoxRole;
        private MetroFramework.Controls.MetroLabel metroLabelRole;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAdress;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPhone;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCNP;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLastName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFirstName;
        private MetroFramework.Controls.MetroLabel metroLabelAdress;
        private MetroFramework.Controls.MetroLabel metroLabelPhone;
        private MetroFramework.Controls.MetroLabel metroLabelCNP;
        private MetroFramework.Controls.MetroLabel metroLabelLastName;
        private MetroFramework.Controls.MetroLabel metroLabelFirstName;
    }
}