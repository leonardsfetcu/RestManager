namespace Manager
{
    partial class SignUpForm
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
            this.mtNume = new MetroFramework.Controls.MetroLabel();
            this.mtPrenume = new MetroFramework.Controls.MetroLabel();
            this.mtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.mtLastName = new MetroFramework.Controls.MetroTextBox();
            this.mtUserName = new MetroFramework.Controls.MetroLabel();
            this.mtUser = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtPass = new MetroFramework.Controls.MetroTextBox();
            this.mtSignUp = new MetroFramework.Controls.MetroButton();
            this.mtCancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtConfirm = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // mtNume
            // 
            this.mtNume.AutoSize = true;
            this.mtNume.Location = new System.Drawing.Point(23, 125);
            this.mtNume.Name = "mtNume";
            this.mtNume.Size = new System.Drawing.Size(73, 19);
            this.mtNume.TabIndex = 0;
            this.mtNume.Text = "First Name";
            // 
            // mtPrenume
            // 
            this.mtPrenume.AutoSize = true;
            this.mtPrenume.Location = new System.Drawing.Point(21, 172);
            this.mtPrenume.Name = "mtPrenume";
            this.mtPrenume.Size = new System.Drawing.Size(71, 19);
            this.mtPrenume.TabIndex = 1;
            this.mtPrenume.Text = "Last Name";
            // 
            // mtFirstName
            // 
            this.mtFirstName.Location = new System.Drawing.Point(110, 125);
            this.mtFirstName.Name = "mtFirstName";
            this.mtFirstName.Size = new System.Drawing.Size(158, 23);
            this.mtFirstName.TabIndex = 1;
            // 
            // mtLastName
            // 
            this.mtLastName.Location = new System.Drawing.Point(110, 172);
            this.mtLastName.Name = "mtLastName";
            this.mtLastName.Size = new System.Drawing.Size(158, 23);
            this.mtLastName.TabIndex = 2;
            // 
            // mtUserName
            // 
            this.mtUserName.AutoSize = true;
            this.mtUserName.Location = new System.Drawing.Point(21, 221);
            this.mtUserName.Name = "mtUserName";
            this.mtUserName.Size = new System.Drawing.Size(75, 19);
            this.mtUserName.TabIndex = 1;
            this.mtUserName.Text = "User Name";
            // 
            // mtUser
            // 
            this.mtUser.Location = new System.Drawing.Point(110, 221);
            this.mtUser.Name = "mtUser";
            this.mtUser.Size = new System.Drawing.Size(158, 23);
            this.mtUser.TabIndex = 3;
            this.mtUser.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(21, 270);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Password";
            // 
            // mtPass
            // 
            this.mtPass.Location = new System.Drawing.Point(110, 270);
            this.mtPass.Name = "mtPass";
            this.mtPass.PasswordChar = '•';
            this.mtPass.Size = new System.Drawing.Size(158, 23);
            this.mtPass.TabIndex = 4;
            // 
            // mtSignUp
            // 
            this.mtSignUp.Location = new System.Drawing.Point(112, 380);
            this.mtSignUp.Name = "mtSignUp";
            this.mtSignUp.Size = new System.Drawing.Size(75, 23);
            this.mtSignUp.TabIndex = 6;
            this.mtSignUp.Text = "Sign Up";
            this.mtSignUp.Click += new System.EventHandler(this.mtSignUp_Click);
            // 
            // mtCancel
            // 
            this.mtCancel.Location = new System.Drawing.Point(193, 380);
            this.mtCancel.Name = "mtCancel";
            this.mtCancel.Size = new System.Drawing.Size(75, 23);
            this.mtCancel.TabIndex = 7;
            this.mtCancel.Text = "Cancel";
            this.mtCancel.Click += new System.EventHandler(this.mtCancel_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 324);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Confirm";
            // 
            // mtConfirm
            // 
            this.mtConfirm.Location = new System.Drawing.Point(112, 324);
            this.mtConfirm.Name = "mtConfirm";
            this.mtConfirm.PasswordChar = '•';
            this.mtConfirm.Size = new System.Drawing.Size(158, 23);
            this.mtConfirm.TabIndex = 5;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 501);
            this.Controls.Add(this.mtCancel);
            this.Controls.Add(this.mtSignUp);
            this.Controls.Add(this.mtConfirm);
            this.Controls.Add(this.mtPass);
            this.Controls.Add(this.mtUser);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mtLastName);
            this.Controls.Add(this.mtUserName);
            this.Controls.Add(this.mtFirstName);
            this.Controls.Add(this.mtPrenume);
            this.Controls.Add(this.mtNume);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mtNume;
        private MetroFramework.Controls.MetroLabel mtPrenume;
        private MetroFramework.Controls.MetroTextBox mtFirstName;
        private MetroFramework.Controls.MetroTextBox mtLastName;
        private MetroFramework.Controls.MetroLabel mtUserName;
        private MetroFramework.Controls.MetroTextBox mtUser;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mtPass;
        private MetroFramework.Controls.MetroButton mtSignUp;
        private MetroFramework.Controls.MetroButton mtCancel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtConfirm;
    }
}