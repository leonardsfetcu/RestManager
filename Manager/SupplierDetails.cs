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
    public partial class SupplierDetails : MetroFramework.Forms.MetroForm
    {
        public Supplier SupplierInfo
        {
            get
            {
                return supplierBindingSource.Current as Supplier;
            }
        }
        public SupplierDetails(Supplier obj)
        {
            InitializeComponent();
            supplierBindingSource.DataSource = obj;
        }

        private void SupplierDetails_Load(object sender, EventArgs e)
        {

        }

        private void metroTileSave_Click(object sender, EventArgs e)
        {
            supplierBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void metroTileCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
