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
    public partial class MenuDetails : MetroFramework.Forms.MetroForm
    {
        public MenuDetails(Menu obj)
        {
            InitializeComponent();
            bindingSourceMenu.DataSource = obj;
        }

        public Menu menuInfo { get { return bindingSourceMenu.Current as Menu; } }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bindingSourceMenu.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void MenuDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtCook_Validating(object sender, CancelEventArgs e)
        {
            int x = int.Parse(txtCook.Text);
            if(x<5 || x>120)
            {
                e.Cancel = true;
                MessageBox.Show("Valoare cuprinsa intre 5 si 120", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            bindingSourceMenu.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
