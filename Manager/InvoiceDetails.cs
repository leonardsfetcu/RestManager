using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
			metroComboBoxProduct.DisplayMember = "Name";
			metroComboBoxProduct.ValueMember = "ProductID";


			using (RestaurantDBEntities context = new RestaurantDBEntities())
			{
				metroComboBoxSuppliers.DataSource = context.Suppliers.ToList();
				
				metroComboBoxProduct.DataSource = context.Products.ToList();
				
				categoryBindingSource.DataSource = context.Categories.ToList();
				unitBindingSource.DataSource = context.Units.ToList();
			}

			dataGridViewProducts.DataSource = productBindingSource;
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
							metroComboBoxProduct.DataSource = context.Products.ToList();
							metroComboBoxProduct.SelectedIndex = metroComboBoxProduct.FindStringExact(CurrentProduct.Name);
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
			using (RestaurantDBEntities context = new RestaurantDBEntities())
			{
				CurrentProduct = context.Products.Find(metroComboBoxProduct.SelectedValue);
			}
			CurrentProduct.UnitsInStore = int.Parse(metroTextBoxQuantity.Text);
			metroTextBoxQuantity.Text = string.Empty;
			productBindingSource.Add(CurrentProduct);
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
				invoice.EmployeeID = LoginForm.User.EmployeeID;

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
			if (MessageBox.Show("Generate PDF Invoice?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
			{
				CreatePdfDocument();
			}
			Close();
		}

		private void CreatePdfDocument()
		{
			string path = "invoice.pdf";
			using (System.IO.FileStream memoryStream = new System.IO.FileStream(path, System.IO.FileMode.Create))
			{
				Employee empl;
				Supplier supl;
				using (RestaurantDBEntities context = new RestaurantDBEntities())
				{
					empl = LoginForm.User;
					supl = context.Suppliers.Find(metroComboBoxSuppliers.SelectedValue);
				}

				Document document = new Document(PageSize.A4, 10, 10, 120, 10);
				PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);
				document.Open();
					// title
				document.AddTitle("Invoice");
					// subtitle
				BaseFont baseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
				iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 16.0f, 3);
				document.Add(new Paragraph("               INVOICE", font));
				font = new iTextSharp.text.Font(baseFont, 11.0f, 0);
				document.Add(new Paragraph("                     Date: " + dateTimePicker1.Value.ToString(), font));
				font = new iTextSharp.text.Font(baseFont, 11.0f, 2);
				document.Add(new Paragraph("                     Supplier: " + supl.Name, font));
				font = new iTextSharp.text.Font(baseFont, 11.0f, 0);
				document.Add(new Paragraph("                     CIF: " + supl.CIF, font));
				document.Add(new Paragraph("                     Adress: " + supl.Adress, font));
				document.Add(new Paragraph("                      ", font));
					// table
				PdfPTable table = new PdfPTable(4);
				table.TotalWidth = document.PageSize.Width;
				PdfPCell cell = new PdfPCell();
				cell.Border = PdfPCell.TOP_BORDER + PdfPCell.BOTTOM_BORDER;

				font = new iTextSharp.text.Font(baseFont, 12.0f, 2);
				cell.Phrase = new Phrase("Quantity", font);
				table.AddCell(cell);
				cell.Phrase = new Phrase("Description", font);
				table.AddCell(cell);
				cell.Phrase = new Phrase("Unit Price ($)", font);
				table.AddCell(cell);
				cell.Phrase = new Phrase("Amount ($)", font);
				table.AddCell(cell);

				cell.Border = PdfPCell.NO_BORDER;
				font = new iTextSharp.text.Font(baseFont, 10.0f, 0);
				float total = 0.0f;
				foreach (var i in productBindingSource.List)
				{
					Product item = i as Product;
					cell.Phrase = new Phrase(item.UnitsInStore.ToString(), font);
					table.AddCell(cell);
					cell.Phrase = new Phrase(item.Name.ToString(), font);
					table.AddCell(cell);
					cell.Phrase = new Phrase(item.UnitPrice.ToString(), font);
					table.AddCell(cell);
					cell.Phrase = new Phrase((item.UnitsInStore * item.UnitPrice).ToString(), font);
					table.AddCell(cell);
					total += (float)item.UnitsInStore * (float)item.UnitPrice;
				}
				cell.Phrase = new Phrase();
				table.AddCell(cell);
				table.AddCell(cell);
				font = new iTextSharp.text.Font(baseFont, 12.0f, 2);
				cell.Phrase = new Phrase("TOTAL", font);
				table.AddCell(cell);
				cell.Phrase = new Phrase(total.ToString(), font);
				table.AddCell(cell);

				document.Add(table);	

				font = new iTextSharp.text.Font(baseFont, 14.0f, 3);
				Paragraph p = new Paragraph(" ", font);
				p.Alignment = Element.ALIGN_RIGHT;
				document.Add(p);
				document.Add(p);
				
				p = new Paragraph("Signature: " + empl.FirstName + " " + empl.LastName + "                 ", font);
				p.Alignment = Element.ALIGN_RIGHT;
				document.Add(p);

				document.Close();
				
				System.Diagnostics.Process.Start(path);
			}
		}
	}
}
