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
            this.metroTileSave = new MetroFramework.Controls.MetroTile();
            this.metroTileCancel = new MetroFramework.Controls.MetroTile();
            this.metroComboBoxRole = new MetroFramework.Controls.MetroComboBox();
            this.metroLabelRole = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxAdress = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxCNP = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxLastName = new MetroFramework.Controls.MetroTextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroTextBoxFirstName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelAdress = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPhone = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCNP = new MetroFramework.Controls.MetroLabel();
            this.metroLabelLastName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelFirstName = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTileSave
            // 
            this.metroTileSave.CustomBackground = true;
            this.metroTileSave.Location = new System.Drawing.Point(422, 372);
            this.metroTileSave.Name = "metroTileSave";
            this.metroTileSave.Size = new System.Drawing.Size(64, 64);
            this.metroTileSave.TabIndex = 21;
            this.metroTileSave.TileImage = global::Manager.Properties.Resources.icons8_checkmark_64;
            this.metroTileSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSave.UseTileImage = true;
            this.metroTileSave.Click += new System.EventHandler(this.metroTileSave_Click);
            // 
            // metroTileCancel
            // 
            this.metroTileCancel.CustomBackground = true;
            this.metroTileCancel.Location = new System.Drawing.Point(337, 372);
            this.metroTileCancel.Name = "metroTileCancel";
            this.metroTileCancel.Size = new System.Drawing.Size(64, 64);
            this.metroTileCancel.TabIndex = 20;
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
            this.metroComboBoxRole.Location = new System.Drawing.Point(129, 173);
            this.metroComboBoxRole.Name = "metroComboBoxRole";
            this.metroComboBoxRole.Size = new System.Drawing.Size(152, 30);
            this.metroComboBoxRole.TabIndex = 10;
            // 
            // metroLabelRole
            // 
            this.metroLabelRole.AutoSize = true;
            this.metroLabelRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabelRole.CustomBackground = true;
            this.metroLabelRole.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelRole.Location = new System.Drawing.Point(40, 173);
            this.metroLabelRole.Name = "metroLabelRole";
            this.metroLabelRole.Size = new System.Drawing.Size(42, 20);
            this.metroLabelRole.TabIndex = 17;
            this.metroLabelRole.Text = "Role:";
            // 
            // metroTextBoxAdress
            // 
            this.metroTextBoxAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroTextBoxAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Adress", true));
            this.metroTextBoxAdress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxAdress.Location = new System.Drawing.Point(128, 272);
            this.metroTextBoxAdress.Multiline = true;
            this.metroTextBoxAdress.Name = "metroTextBoxAdress";
            this.metroTextBoxAdress.Size = new System.Drawing.Size(358, 80);
            this.metroTextBoxAdress.TabIndex = 19;
            // 
            // metroTextBoxPhone
            // 
            this.metroTextBoxPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroTextBoxPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Phone", true));
            this.metroTextBoxPhone.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxPhone.Location = new System.Drawing.Point(128, 241);
            this.metroTextBoxPhone.Name = "metroTextBoxPhone";
            this.metroTextBoxPhone.Size = new System.Drawing.Size(291, 23);
            this.metroTextBoxPhone.TabIndex = 18;
            // 
            // metroTextBoxCNP
            // 
            this.metroTextBoxCNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroTextBoxCNP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "CNP", true));
            this.metroTextBoxCNP.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxCNP.Location = new System.Drawing.Point(129, 212);
            this.metroTextBoxCNP.Name = "metroTextBoxCNP";
            this.metroTextBoxCNP.Size = new System.Drawing.Size(291, 23);
            this.metroTextBoxCNP.TabIndex = 16;
            // 
            // metroTextBoxLastName
            // 
            this.metroTextBoxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroTextBoxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "LastName", true));
            this.metroTextBoxLastName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxLastName.Location = new System.Drawing.Point(129, 139);
            this.metroTextBoxLastName.Name = "metroTextBoxLastName";
            this.metroTextBoxLastName.Size = new System.Drawing.Size(291, 23);
            this.metroTextBoxLastName.TabIndex = 9;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Manager.Employee);
            // 
            // metroTextBoxFirstName
            // 
            this.metroTextBoxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroTextBoxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "FirstName", true));
            this.metroTextBoxFirstName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBoxFirstName.Location = new System.Drawing.Point(129, 110);
            this.metroTextBoxFirstName.Name = "metroTextBoxFirstName";
            this.metroTextBoxFirstName.Size = new System.Drawing.Size(291, 23);
            this.metroTextBoxFirstName.TabIndex = 8;
            // 
            // metroLabelAdress
            // 
            this.metroLabelAdress.AutoSize = true;
            this.metroLabelAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabelAdress.CustomBackground = true;
            this.metroLabelAdress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelAdress.Location = new System.Drawing.Point(40, 273);
            this.metroLabelAdress.Name = "metroLabelAdress";
            this.metroLabelAdress.Size = new System.Drawing.Size(56, 20);
            this.metroLabelAdress.TabIndex = 11;
            this.metroLabelAdress.Text = "Adress:";
            // 
            // metroLabelPhone
            // 
            this.metroLabelPhone.AutoSize = true;
            this.metroLabelPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabelPhone.CustomBackground = true;
            this.metroLabelPhone.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelPhone.Location = new System.Drawing.Point(40, 242);
            this.metroLabelPhone.Name = "metroLabelPhone";
            this.metroLabelPhone.Size = new System.Drawing.Size(53, 20);
            this.metroLabelPhone.TabIndex = 12;
            this.metroLabelPhone.Text = "Phone:";
            // 
            // metroLabelCNP
            // 
            this.metroLabelCNP.AutoSize = true;
            this.metroLabelCNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabelCNP.CustomBackground = true;
            this.metroLabelCNP.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelCNP.Location = new System.Drawing.Point(40, 213);
            this.metroLabelCNP.Name = "metroLabelCNP";
            this.metroLabelCNP.Size = new System.Drawing.Size(40, 20);
            this.metroLabelCNP.TabIndex = 13;
            this.metroLabelCNP.Text = "CNP:";
            // 
            // metroLabelLastName
            // 
            this.metroLabelLastName.AutoSize = true;
            this.metroLabelLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabelLastName.CustomBackground = true;
            this.metroLabelLastName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelLastName.Location = new System.Drawing.Point(40, 140);
            this.metroLabelLastName.Name = "metroLabelLastName";
            this.metroLabelLastName.Size = new System.Drawing.Size(82, 20);
            this.metroLabelLastName.TabIndex = 14;
            this.metroLabelLastName.Text = "Last Name:";
            // 
            // metroLabelFirstName
            // 
            this.metroLabelFirstName.AutoSize = true;
            this.metroLabelFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabelFirstName.CustomBackground = true;
            this.metroLabelFirstName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelFirstName.Location = new System.Drawing.Point(40, 111);
            this.metroLabelFirstName.Name = "metroLabelFirstName";
            this.metroLabelFirstName.Size = new System.Drawing.Size(83, 20);
            this.metroLabelFirstName.TabIndex = 15;
            this.metroLabelFirstName.Text = "First Name:";
            // 
            // EmployeeDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(536, 462);
            this.Controls.Add(this.metroTileSave);
            this.Controls.Add(this.metroTileCancel);
            this.Controls.Add(this.metroComboBoxRole);
            this.Controls.Add(this.metroLabelRole);
            this.Controls.Add(this.metroTextBoxAdress);
            this.Controls.Add(this.metroTextBoxPhone);
            this.Controls.Add(this.metroTextBoxCNP);
            this.Controls.Add(this.metroTextBoxLastName);
            this.Controls.Add(this.metroTextBoxFirstName);
            this.Controls.Add(this.metroLabelAdress);
            this.Controls.Add(this.metroLabelPhone);
            this.Controls.Add(this.metroLabelCNP);
            this.Controls.Add(this.metroLabelLastName);
            this.Controls.Add(this.metroLabelFirstName);
            this.Name = "EmployeeDetails";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.BindingSource employeeBindingSource;
    }
}