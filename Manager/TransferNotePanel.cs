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
    public partial class TransferNotePanel : MetroFramework.Forms.MetroForm
    {
        RestaurantDBEntities context;
        public TransferNotePanel()
        {
            InitializeComponent();
        }

        private void TransferNotePanel_Load(object sender, EventArgs e)
        {
            using (context = new RestaurantDBEntities())
            {
                productBindingSource.DataSource = context.Products.ToList();
                employeeBindingSource.DataSource = context.Employees.ToList();
                transferNoteBindingSource.DataSource = context.TransferNotes.ToList();
            }
        }

        private void mtEmployeePanelEdit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private async void mtEmployeePanelAdd_Click(object sender, EventArgs e)
        {
            using (TransferNoteUnitPanel transferDetailsPanel = new TransferNoteUnitPanel(new TransfetNoteUnit() { TransferNoteUnitID = -1 }))
            {
                using (context = new RestaurantDBEntities())
                {
                    if (transferDetailsPanel.ShowDialog() == DialogResult.OK)
                    {
                       
                        try
                        {
                            List<Product> list = transferDetailsPanel.productList;
                            TransferNote transferNote = new TransferNote()
                            {
                                TransferNoteID = -1,
                                Date = DateTime.Now,
                                EmployeeID = LoginForm.User.EmployeeID
                            };

                            context.TransferNotes.Add(transferNote);
                            context.SaveChanges();

                            foreach (var transferUnit in list)
                            {
                                TransfetNoteUnit temp = new TransfetNoteUnit()
                                {
                                    TransferNoteUnitID = -1,
                                    TransferNoteID = transferNote.TransferNoteID,
                                    ProductID = transferUnit.ProductID,
                                    Quantity = (int)transferUnit.UnitsInStore
                                };
                                        
                                context.TransfetNoteUnits.Add(temp);
                                await context.SaveChangesAsync();
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
}
                        
                    }
                }
            }
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                using (context = new RestaurantDBEntities())
                {
                    TransferNote transferNote = transferNoteBindingSource.Current as TransferNote;
                    if( transferNote!=null)
                        dataGridView2.DataSource=context.TransfetNoteUnits.Where(x=>x.TransferNoteID==transferNote.TransferNoteID).ToList();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void mtEmployeePanelRefresh_Click(object sender, EventArgs e)
        {
            using (context = new RestaurantDBEntities())
            {
                productBindingSource.DataSource = context.Products.ToList();
                employeeBindingSource.DataSource = context.Employees.ToList();
                transferNoteBindingSource.DataSource = context.TransferNotes.ToList();
            }
        }

		private void mtEmployeePanelSave_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
