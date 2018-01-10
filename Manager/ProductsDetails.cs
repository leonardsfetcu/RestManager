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
	public partial class ProductsDetails : MetroFramework.Forms.MetroForm
	{
		public Product ProductInfo
		{
			get
			{
				return productBindingSource.Current as Product;
			}
		}

		public ProductsDetails(Product obj)
		{
			InitializeComponent();
			productBindingSource.DataSource = obj;
		}

		private void ProductsDetails_Load(object sender, EventArgs e)
		{
			metroComboBoxCategory.DisplayMember = "Name";
			metroComboBoxCategory.ValueMember = "CategoryID";
			metroComboBoxUnit.DisplayMember = "Name";
			metroComboBoxUnit.ValueMember = "UnitID";

			using (RestaurantDBEntities context = new RestaurantDBEntities())
			{
				metroComboBoxCategory.DataSource = context.Categories.ToList();
				metroComboBoxUnit.DataSource = context.Units.ToList();
			}
		}

		private void metroTrackBarTVA_ValueChanged(object sender, EventArgs e)
		{
			metroLabelTVA.Text = metroTrackBarTVA.Value.ToString() + "%";
		}

		private void metroTileSave_Click(object sender, EventArgs e)
		{
			productBindingSource.EndEdit();
			double x = metroTrackBarTVA.Value;
			x /= 100.0;
			ProductInfo.TVA = x;
			DialogResult = DialogResult.OK;
		}
	}
}
