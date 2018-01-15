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
    public partial class TransferNoteUnitPanel : MetroFramework.Forms.MetroForm
    {
        RestaurantDBEntities context;
        public List<Product> productList
        {
            get;
            set;
        }

        public TransferNoteUnitPanel(TransfetNoteUnit obj)
        {
            InitializeComponent();
            productList = new List<Product>();
            panelBindingSource.DataSource = obj;
        }

        private void TransferNoteDetailsPanel_Load(object sender, EventArgs e)
        {
            using (context = new RestaurantDBEntities())
            {
                unitBindingSource.DataSource = context.Units.ToList();
                categoryBindingSource.DataSource = context.Categories.ToList();
                metroComboBoxProduct.DataSource = context.Products.ToList();
                metroComboBoxProduct.DisplayMember = "Name";
                metroComboBoxProduct.ValueMember = "ProductID";

            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            var data = panelBindingSource.Current as TransfetNoteUnit;

            using (context = new RestaurantDBEntities())
            {
                var product = context.Products.Find(data.ProductID);
                product.UnitsInStore = data.Quantity;
                productBindingSource.Add(product);
                productList.Add(product);

            }
        }

        private void metroTileFinish_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
