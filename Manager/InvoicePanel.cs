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
	public partial class InvoicePanel : MetroFramework.Forms.MetroForm
	{
		RestaurantDBEntities context;
		public InvoicePanel()
		{
			InitializeComponent();
			context = new RestaurantDBEntities();
		}

		private void InvoicePanel_Load(object sender, EventArgs e)
		{
			supplierBindingSource.DataSource = context.Suppliers.ToList();
			invoiceBindingSource.DataSource = context.Invoices.ToList();
			employeeBindingSource.DataSource = context.Employees.ToList();

			dataGridView1.DataSource = supplierBindingSource;
		}

		private async void metroTileAdd_Click(object sender, EventArgs e)
		{
			using (InvoiceDetails invoiceDetails = new InvoiceDetails(new Invoice() { InvoiceID = -1 }))
			{
				if (invoiceDetails.ShowDialog() == DialogResult.OK)
				{
					try
					{
						invoiceBindingSource.Add(invoiceDetails.InvoiceInfo);
						context.Invoices.Add(invoiceDetails.InvoiceInfo);
						await context.SaveChangesAsync();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			Supplier s = supplierBindingSource.Current as Supplier;
			if (s != null) dataGridView2.DataSource = context.Invoices.Where(a => a.SupplierID == s.SupplierID).ToList();
		}
	}
}
