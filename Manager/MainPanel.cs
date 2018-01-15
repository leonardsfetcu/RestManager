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
			if (LoginForm.RequireAccesLevel(PrivilegeLevel.admin))
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
			if (LoginForm.RequireAccesLevel(PrivilegeLevel.secretar))
				using (SupplierPanel supplierPanel = new SupplierPanel())
			{
				supplierPanel.ShowDialog();
			}
		}

		private void metroTileProducts_Click(object sender, EventArgs e)
		{
			if (LoginForm.RequireAccesLevel(PrivilegeLevel.secretar))
				using (ProductsPanel productsPanel = new ProductsPanel())
			{
				productsPanel.ShowDialog();
			}
		}

		private void metroInvoices_Click(object sender, EventArgs e)
		{
			if (LoginForm.RequireAccesLevel(PrivilegeLevel.secretar))
			using (InvoicePanel invoicePanel = new InvoicePanel())
			{
				invoicePanel.ShowDialog();
			}
		}

        private void metroTile4_Click(object sender, EventArgs e)
		{
			if (LoginForm.RequireAccesLevel(PrivilegeLevel.worker))
				using (MenuPanel menuPanel = new MenuPanel())
            {
               menuPanel.ShowDialog();
            }
        }

		private void metroTile4_Click_1(object sender, EventArgs e)
		{
			LoginForm.Control.Show();
			LoginForm.Control.ClearTextBoxes();
			Close();
		}

		private void mt_Click(object sender, EventArgs e)
		{
			if (LoginForm.RequireAccesLevel(PrivilegeLevel.worker))
			{
				using (Store storePanel = new Store())
				{
					storePanel.ShowDialog();
				}
			}
		}

		private void metroTile3_Click(object sender, EventArgs e)
		{
			if (LoginForm.RequireAccesLevel(PrivilegeLevel.worker))
			{
				using (Kitchen kitchenPanel = new Kitchen())
				{
					kitchenPanel.ShowDialog();
				}
			}
		}

		private void MainPanel_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!LoginForm.Control.Visible)
			{
				Application.Exit();
			}
		}

		private void metroTile5_Click(object sender, EventArgs e)
		{
			if (LoginForm.RequireAccesLevel(PrivilegeLevel.secretar))
				using (TransferNotePanel tPanel = new TransferNotePanel())
				{
					tPanel.ShowDialog();
				}
		}
	}
}
