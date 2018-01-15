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
	public enum PrivilegeLevel
	{
		admin, secretar, worker
	}
	public partial class LoginForm : MetroFramework.Forms.MetroForm
	{
		public static Employee User { get; set; }
		public static LoginForm Control { get; set; }
		public LoginForm()
		{
			InitializeComponent();
			Control = this;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Application.Exit();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			try
			{
				using (RestaurantDBEntities context = new RestaurantDBEntities())
				{
					List<Employee> list = context.Employees.Where(x => x.Username == mtUser.Text).ToList();
					foreach (Employee user in list)
					{
						if (user.Password == mtPass.Text)
						{
							User = user;
							MainPanel mainPanel = new MainPanel();
							this.Hide();
							mainPanel.ShowDialog();
							//this.Close();
							return;
						}
					}
					MessageBox.Show("User name or password incorrect!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		public void ClearTextBoxes()
		{
			mtUser.Text = string.Empty;
			mtPass.Text = string.Empty;
		}

		public static bool RequireAccesLevel(PrivilegeLevel level)
		{
			if (level == PrivilegeLevel.admin)
			{
				if (User.RoleID == 6 || User.RoleID == 1)
				{
					return true;
				}
			}
			else if (level == PrivilegeLevel.secretar)
			{
				if (User.RoleID == 6 || User.RoleID == 1 || User.RoleID == 2 || User.RoleID == 3)
				{
					return true;
				}
			}
			else if (level == PrivilegeLevel.worker)
			{
				return true;
			}
			MessageBox.Show("You do not have sufficient right to open this!", "Contact an admin!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return false;
		}
	}
}
