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
	public partial class Store : MetroFramework.Forms.MetroForm
	{
		public Store()
		{
			InitializeComponent();
		}

		private void StorePanel_Load(object sender, EventArgs e)
		{
			try
			{
				using (RestaurantDBEntities context = new RestaurantDBEntities())
				{
					storeViewBindingSource.DataSource = context.StoreViews.ToList();
					dataGridView1.DataSource = storeViewBindingSource;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		private void metroTile4_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void metroInvoices_Click(object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Name; Quantity; UnitPrice; TVA; Category");
			foreach (var item in storeViewBindingSource)
			{
				StoreView i = item as StoreView;
				sb.AppendLine(i.Name + "; " + i.Quatity + "; " + i.UnitPrice + "; " + i.TVA + "; " + i.Category);
			}
			System.IO.File.WriteAllText("store.csv", sb.ToString());
			System.Diagnostics.Process.Start("store.csv");
		}
	}
}
