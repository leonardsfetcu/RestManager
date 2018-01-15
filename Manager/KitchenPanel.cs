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
	public partial class Kitchen : MetroFramework.Forms.MetroForm
	{
		public Kitchen()
		{
			InitializeComponent();
			KitchenView view = new KitchenView();
		}

		private void KitchenPanel_Load(object sender, EventArgs e)
		{
			try
			{
				using (RestaurantDBEntities context = new RestaurantDBEntities())
				{
					kitchenViewBindingSource.DataSource = context.KitchenViews.ToList();
					dataGridView1.DataSource = kitchenViewBindingSource;
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
			foreach (var item in kitchenViewBindingSource)
			{
				KitchenView i = item as KitchenView;
				sb.AppendLine(i.Name + "; " + i.Quantity + "; " + i.UnitPrice + "; " + i.TVA + "; " + i.Category);
			}
			System.IO.File.WriteAllText("kitchen.csv", sb.ToString());
			System.Diagnostics.Process.Start("kitchen.csv");
		}
	}
}
