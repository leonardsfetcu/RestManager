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
    public partial class MenuPanel : MetroFramework.Forms.MetroForm
    {
        RestaurantDBEntities context;

        public MenuPanel()
        {
            InitializeComponent();
            context = new RestaurantDBEntities();   
        }

        private void mtRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            menuBindingSource.DataSource = context.Menus.ToList();
           // roleBindingSource.DataSource = context.Roles.ToList();
            Cursor.Current = Cursors.Default;
        }

        private async void mtAdd_Click(object sender, EventArgs e)
        {
            using (MenuDetails menuDetails = new MenuDetails(new Menu() { MenuID = -1 }))
            {
                if (menuDetails.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        menuBindingSource.Add(menuDetails.menuInfo);
                        context.Menus.Add(menuDetails.menuInfo);
                        await context.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void mtEdit_Click(object sender, EventArgs e)
        {
            Menu obj = menuBindingSource.Current as Menu;
            if (obj != null)
            {
                using (MenuDetails menuDetailsForm = new MenuDetails(obj))
                {
                    if (menuDetailsForm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            menuBindingSource.EndEdit();
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

        private void mtDelete_Click(object sender, EventArgs e)
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
                            context.Menus.Remove(dataGridView1.Rows[i].DataBoundItem as Menu);
                            menuBindingSource.RemoveAt(dataGridView1.Rows[i].Index);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void mtSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    menuBindingSource.EndEdit();
                    await context.SaveChangesAsync();
                   // isUpdated = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuPanel_Load(object sender, EventArgs e)
        {
            menuBindingSource.DataSource = context.Menus.ToList();
            typeBindingSource.DataSource = context.Types.ToList();
            //roleBindingSource.DataSource = context.Roles.ToList();
        }

		private void mtEmployeePanelSave_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
