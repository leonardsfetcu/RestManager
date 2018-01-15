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
    public partial class SupplierPanel : MetroFramework.Forms.MetroForm
    {
        RestaurantDBEntities context;
        bool isUpdated;

        public SupplierPanel()
        {
            InitializeComponent();
            context = new RestaurantDBEntities();
        }

        private void SupplierPanel_Load(object sender, EventArgs e)
        {
            supplierBindingSource.DataSource = context.Suppliers.ToList();
            isUpdated = false;
        }

        private void mtEmployeePanelRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            supplierBindingSource.DataSource = context.Suppliers.ToList();
            Cursor.Current = Cursors.Default;
        }

        private async void mtEmployeePanelAdd_Click(object sender, EventArgs e)
        {
            using (SupplierDetails supplierDetails = new SupplierDetails(new Supplier() { SupplierID = -1 }))
            {
                if (supplierDetails.ShowDialog() == DialogResult.OK)
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

        private async void mtEmployeePanelEdit_Click(object sender, EventArgs e)
        {
            Supplier obj = supplierBindingSource.Current as Supplier;
            if (obj != null)
            {
                using (SupplierDetails supplierDetailsForm = new SupplierDetails(obj))
                {
                    if (supplierDetailsForm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            supplierBindingSource.EndEdit();
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
                    int rows = dataGridView1.RowCount;
                    for (int i = rows - 1; i >= 0; i--)
                    {
                        if (dataGridView1.SelectedRows.Contains(dataGridView1.Rows[i]))
                        {
                            context.Suppliers.Remove(dataGridView1.Rows[i].DataBoundItem as Supplier);
                            supplierBindingSource.RemoveAt(dataGridView1.Rows[i].Index);
                        }
                    }
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
                    supplierBindingSource.EndEdit();
                    await context.SaveChangesAsync();
                    isUpdated = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void metroTile1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
