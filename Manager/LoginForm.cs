using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public static Employee User { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           // Cursor = Cursors.WaitCursor;
            using (RestaurantDBEntities context = new RestaurantDBEntities())
            {
                List<Employee> list = context.Employees.Where(x => x.Username == mtUser.Text).ToList();
               // Cursor = Cursors.Arrow;
                foreach (Employee user in list)
                {
                    if(user.Password == mtPass.Text)
                    {
                        User = user;
                        MainPanel mainPanel = new MainPanel();
                        this.Hide();
                        mainPanel.ShowDialog();
                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("User name or password incorrect!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.ShowDialog();
        }
        
        private void LoginForm_Shown(object sender, EventArgs e)
        {
          Activate();
          Focus();
        }
	}
}
