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
			dataGridView1.DataSource = context.Suppliers.ToList();
			supplierBindingSource.DataSource = context.Suppliers.ToList();
			//dataGridView2.DataSource = context.Invoices.ToList();
			invoiceBindingSource.DataSource = context.Invoices.ToList();
			employeeBindingSource.DataSource = context.Employees.ToList();
		}

		private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var stins = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			var sup = context.Suppliers.Where(a => a.Name == stins).ToList();
			Supplier s = new Supplier();
			if (sup.Count > 0)
			{
				s = sup[0];
			}
			//var sup = supplierBindingSource.Current as Supplier;
			var list = context.Invoices.Where(a => a.SupplierID == s.SupplierID).ToList();
			//dataGridView2.DataSource = null;
			dataGridView2.DataSource = list;
		}

		private void supplierBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			MessageBox.Show("DADDA", "dasa");
		}
	}
}
