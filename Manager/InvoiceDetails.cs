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
	public partial class InvoiceDetails : MetroFramework.Forms.MetroForm
	{
		private Product CurrentProduct;
		public Invoice InvoiceInfo
		{
			get
			{
				return invoiceBindingSource.Current as Invoice;
			}
		}
		public List<Product> ProductList;
		public InvoiceDetails(Invoice obj)
		{
			InitializeComponent();
			invoiceBindingSource.DataSource = obj;
			ProductList = new List<Product>();
		}

		private void InvoiceDetails_Load(object sender, EventArgs e)
		{
			metroComboBoxSuppliers.DisplayMember = "Name";
			metroComboBoxSuppliers.ValueMember = "SupplierID";
			metroComboBoxEmployee.DisplayMember = "FirstName";
			metroComboBoxEmployee.ValueMember = "EmployeeID";
			metroComboBoxProduct.DisplayMember = "Name";
			metroComboBoxProduct.ValueMember = "ProductID";


			using (RestaurantDBEntities context = new RestaurantDBEntities())
			{
				metroComboBoxSuppliers.DataSource = context.Suppliers.ToList();
				metroComboBoxEmployee.DataSource = context.Employees.ToList();
				metroComboBoxProduct.DataSource = context.Products.ToList();
				categoryBindingSource.DataSource = context.Categories.ToList();
				unitBindingSource.DataSource = context.Units.ToList();
			}

			dataGridViewProducts.DataSource = productBindingSource;
		}

		private async void metroButtonAddSupplier_Click(object sender, EventArgs e)
		{
			using (SupplierDetails supplierDetails = new SupplierDetails(new Supplier() { SupplierID = -1 }))
			{
				if (supplierDetails.ShowDialog() == DialogResult.OK)
				{
					using (RestaurantDBEntities context = new RestaurantDBEntities())
					{
						try
						{
							supplierBindingSource.Add(supplierDetails.SupplierInfo);
							context.Suppliers.Add(supplierDetails.SupplierInfo);
							await context.SaveChangesAsync();
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
			InvoiceDetails_Load(this, new EventArgs());
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{

		}

		private void metroButton3_Click(object sender, EventArgs e)
		{
			using (ProductsDetails productDetails = new ProductsDetails(new Product() { ProductID = -1 }))
			{
				if (productDetails.ShowDialog() == DialogResult.OK)
				{
					using (RestaurantDBEntities context = new RestaurantDBEntities())
					{
						try
						{
							CurrentProduct = productDetails.ProductInfo;
							CurrentProduct.ProductID = -1;
							CurrentProduct.UnitsInStore = 0;
							CurrentProduct.UnitsInKitchen = 0;
							context.Products.Add(CurrentProduct);
							context.SaveChanges();
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
		}

		private void metroButton2_Click_1(object sender, EventArgs e)
		{
			if (CurrentProduct == null)
			{
				using (RestaurantDBEntities context = new RestaurantDBEntities())
				{
					CurrentProduct = context.Products.Find(metroComboBoxProduct.SelectedValue);
				}
			}
			CurrentProduct.UnitsInStore = int.Parse(metroTextBoxQuantity.Text);
			productBindingSource.Add(CurrentProduct);
			CurrentProduct = null;
		}

		private async void metroTileFinish_Click(object sender, EventArgs e)
		{
			using (RestaurantDBEntities context = new RestaurantDBEntities())
			{
				Invoice invoice = new Invoice();
				InvoiceUnit invoiceUnit = new InvoiceUnit();
				invoice.InvoiceID = -1;
				invoice.SupplierID = (int)metroComboBoxSuppliers.SelectedValue;
				invoice.Date = dateTimePicker1.Value;
				invoice.EmployeeID = (int)metroComboBoxEmployee.SelectedValue;

				context.Invoices.Add(invoice);
				context.SaveChanges();

				invoiceUnit.InvoiceUnitID = -1;
				invoiceUnit.InvoiceID = invoice.InvoiceID; ;
				foreach (Product prod in productBindingSource.List)
				{
					invoiceUnit.ProductID = prod.ProductID;
					invoiceUnit.Quantity = (int)prod.UnitsInStore;
					context.InvoiceUnits.Add(invoiceUnit);
				}
				await context.SaveChangesAsync();
			}
		}
	}
}
