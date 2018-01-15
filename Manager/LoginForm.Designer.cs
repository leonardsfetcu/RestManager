namespace Manager
{
    partial class LoginForm
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

			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.mtUser = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.mtPass = new MetroFramework.Controls.MetroTextBox();
			this.btnCancel = new MetroFramework.Controls.MetroButton();
			this.btnLogin = new MetroFramework.Controls.MetroButton();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(23, 60);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(35, 19);
			this.metroLabel1.TabIndex = 6;
			this.metroLabel1.Text = "User";
			// 
			// mtUser
			// 
			this.mtUser.Location = new System.Drawing.Point(110, 60);
			this.mtUser.Name = "mtUser";
			this.mtUser.Size = new System.Drawing.Size(166, 23);
			this.mtUser.TabIndex = 0;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(23, 89);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(63, 19);
			this.metroLabel2.TabIndex = 5;
			this.metroLabel2.Text = "Password";
			// 
			// mtPass
			// 
			this.mtPass.Location = new System.Drawing.Point(110, 89);
			this.mtPass.Name = "mtPass";
			this.mtPass.PasswordChar = '•';
			this.mtPass.Size = new System.Drawing.Size(166, 23);
			this.mtPass.TabIndex = 1;
			this.mtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtPass_KeyDown);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(201, 118);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(110, 118);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "&Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.linkLabel2.Location = new System.Drawing.Point(110, 148);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(56, 16);
			this.linkLabel2.TabIndex = 4;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Sign Up";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(320, 184);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.mtPass);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.mtUser);
			this.Controls.Add(this.metroLabel1);
			this.Name = "LoginForm";
			this.Text = "Login";
			this.Shown += new System.EventHandler(this.LoginForm_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtUser;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtPass;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel2;
	}
}