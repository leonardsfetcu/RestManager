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
    public partial class EmployeePanel : MetroFramework.Forms.MetroForm
    {
        RestaurantDBEntities context;

        public EmployeePanel()
        {
            InitializeComponent();
            context = new RestaurantDBEntities();

        }
     

        private void EmployeePanel_Load(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = context.Employees.ToList();
            roleBindingSource.DataSource = context.Roles.ToList();

        }

        private async void mtEmployeePanelAdd_Click(object sender, EventArgs e)
        {
            using (EmployeeDetails employeeDetails = new EmployeeDetails(new Employee() { EmployeeID = -1 }))
            {
                if(employeeDetails.ShowDialog()==DialogResult.OK)
                {
                    try
                    {
                        employeeBindingSource.Add(employeeDetails.EmployeeInfo);
                        context.Employees.Add(employeeDetails.EmployeeInfo);
                        await context.SaveChangesAsync();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void mtEmployeePanelRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            employeeBindingSource.DataSource = context.Employees.ToList();
            roleBindingSource.DataSource = context.Roles.ToList();
            Cursor.Current = Cursors.Default;
            
        }
    }
}
