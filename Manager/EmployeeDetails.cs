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
    public partial class EmployeeDetails : MetroFramework.Forms.MetroForm
    {
        public EmployeeDetails(Employee obj)
        {
            InitializeComponent();
            employeeBindingSource.DataSource = obj;
        }
        /// <summary>
        /// returns the current bindingsource
        /// </summary>
        public Employee EmployeeInfo
        {
            get
            {
                return employeeBindingSource.Current as Employee;
            }
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {

            metroComboBoxRole.DisplayMember = "Name";
            metroComboBoxRole.ValueMember = "RoleID";
        
            using (RestaurantDBEntities context = new RestaurantDBEntities("name=RestaurantDBEntities"))
            {
                metroComboBoxRole.DataSource = context.Roles.ToList();
            }
        }

        private void metroTileSave_Click(object sender, EventArgs e)
        {
            employeeBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void metroTileCancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
	}
}
