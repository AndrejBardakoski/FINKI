using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopingCart
{
    public partial class AddProductForm : Form
    {
        public Product Product { get; set; }
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btdAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) 
            {
                String name = tbName.Text;
                String Categorry = tbCategory.Text;
                float price = 0;
                float.TryParse(tbPrice.Text, out price);
                Product = new Product(tbName.Text, tbCategory.Text, float.Parse(tbPrice.Text));
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                errorProvider1.SetError(tbName, "Продуктот мора да содржи име!");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(tbName, null);
        }

        private void tbCategory_Validating(object sender, CancelEventArgs e)
        {
            if (tbCategory.Text == "")
            {
                e.Cancel = false;
                errorProvider1.SetError(tbCategory, "Продуктот мора да содржи категорија!");


            }
            else
                errorProvider1.SetError(tbCategory, null);
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            float price = 0;
            float.TryParse(tbPrice.Text, out price);
            if (price <= 0)
            {
                errorProvider1.SetError(tbPrice, "Продуктот мора да содржи валидна цена!");
                e.Cancel = true;
            }
            else 
            { 
            errorProvider1.SetError(tbPrice, null);
            }
        }
    }
}
