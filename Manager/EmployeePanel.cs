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
        bool isUpdated;

        public EmployeePanel()
        {
            InitializeComponent();
            context = new RestaurantDBEntities();

        }
     

        private void EmployeePanel_Load(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = context.Employees.ToList();
            roleBindingSource.DataSource = context.Roles.ToList();
            isUpdated = false;

        }

        private async void mtEmployeePanelAdd_Click(object sender, EventArgs e)
        {
            using (EmployeeDetails employeeDetails = new EmployeeDetails(new Employee() ))
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

        private async void mtEmployeePanelSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save the changes?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    employeeBindingSource.EndEdit();
                    await context.SaveChangesAsync();
                    isUpdated = true;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtEmployeePanelDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete the record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rows = dataGridView1.RowCount;
                    for(int i=rows-1;i>=0;i--)
                    {
                        if(dataGridView1.SelectedRows.Contains(dataGridView1.Rows[i]))
                        {
                            context.Employees.Remove(dataGridView1.Rows[i].DataBoundItem as Employee);
                            employeeBindingSource.RemoveAt(dataGridView1.Rows[i].Index);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void mtEmployeePanelEdit_Click(object sender, EventArgs e)
        {
            Employee obj = employeeBindingSource.Current as Employee;
            if(obj!=null)
            {
                using (EmployeeDetails employeeDetailsForm = new EmployeeDetails(obj))
                {
                    if(employeeDetailsForm.ShowDialog()==DialogResult.OK)
                    {
                        try
                        {
                            employeeBindingSource.EndEdit();
                            await context.SaveChangesAsync();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void EmployeePanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isUpdated==false)
            {
                if(MessageBox.Show("Do you want to exit without save?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                }
                
            }
        }
    }
}
