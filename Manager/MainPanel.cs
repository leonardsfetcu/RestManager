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
    public partial class MainPanel : MetroFramework.Forms.MetroForm
    {
        public MainPanel()
        {
            InitializeComponent();
        }

       

        private void mtEmployees_Click(object sender, EventArgs e)
        {
            using (EmployeePanel employeePanel = new EmployeePanel())
            {
                employeePanel.ShowDialog();
            }
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {

        }

		private void metroTile1_Click(object sender, EventArgs e)
		{
			using (SupplierPanel supplierPanel = new SupplierPanel())
			{
				supplierPanel.ShowDialog();
			}
		}

		private void metroTileProducts_Click(object sender, EventArgs e)
		{
			using (ProductsPanel productsPanel = new ProductsPanel())
			{
				productsPanel.ShowDialog();
			}
		}
	}
}
