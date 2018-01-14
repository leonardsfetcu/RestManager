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
    public partial class SignUpForm : MetroFramework.Forms.MetroForm
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void mtCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void mtSignUp_Click(object sender, EventArgs e)
        {
            using (RestaurantDBEntities context = new RestaurantDBEntities())
            {
                List<Employee> empl = context.Employees.ToList();
                if (!mtPass.Text.Equals(mtConfirm.Text))
                {
                    MessageBox.Show("Passwords do not match!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool found = false;
                foreach (var item in empl)
                {
                    if (item.FirstName.Equals(mtFirstName.Text) && item.LastName.Equals(mtLastName.Text))
                    {
                        if (item.Username != null)
                        {
                            MessageBox.Show("Account exists for this name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            DialogResult = DialogResult.OK;
                            return;
                        }
                        context.updateEmployee(mtFirstName.Text, mtLastName.Text, mtPass.Text, mtConfirm.Text);
                        found = true;
                        MessageBox.Show("Account created!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                }
                if (!found)
                    MessageBox.Show("Firstnamd and Last name do not exist in database! Please contact an admin!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
