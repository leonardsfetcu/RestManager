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
	public partial class ProductsPanel : MetroFramework.Forms.MetroForm
	{
		RestaurantDBEntities context;

		public ProductsPanel()
		{
			InitializeComponent();
			context = new RestaurantDBEntities();
		}

		private void ProductsPanel_Load(object sender, EventArgs e)
		{
			productBindingSource.DataSource = context.Products.ToList();
			categoryBindingSource.DataSource = context.Categories.ToList();
			unitBindingSource.DataSource = context.Units.ToList();
		}

		private async void mtEmployeePanelAdd_Click(object sender, EventArgs e)
		{
			using (ProductsDetails prodDetails = new ProductsDetails(new Product() { ProductID = -1 }))
			{
				if (prodDetails.ShowDialog() == DialogResult.OK)
				{
					try
					{
						productBindingSource.Add(prodDetails.ProductInfo);
						context.Products.Add(prodDetails.ProductInfo);
						await context.SaveChangesAsync();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void mtEmployeePanelRefresh_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			productBindingSource.DataSource = context.Products.ToList();
			categoryBindingSource.DataSource = context.Categories.ToList();
			unitBindingSource.DataSource = context.Units.ToList();
			Cursor.Current = Cursors.Default;
		}

		private async void mtEmployeePanelEdit_Click(object sender, EventArgs e)
		{
			Product obj = productBindingSource.Current as Product;
			if (obj != null)
			{
				using (ProductsDetails prodDetailsForm = new ProductsDetails(obj))
				{
					if (prodDetailsForm.ShowDialog() == DialogResult.OK)
					{
						try
						{
							productBindingSource.EndEdit();
							await context.SaveChangesAsync();
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
		}

		private void mtEmployeePanelDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Do you want to delete the record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					context.Products.Remove(productBindingSource.Current as Product);
					productBindingSource.Remove(productBindingSource.Current as Product);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void mtEmployeePanelSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					productBindingSource.EndEdit();
					await context.SaveChangesAsync();
					//isUpdated = true;
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
