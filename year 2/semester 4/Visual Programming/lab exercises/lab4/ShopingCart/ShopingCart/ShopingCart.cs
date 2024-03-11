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
    public partial class ShopingCart : Form
    {
        public ShopingCart()
        {
            InitializeComponent();
        }
        private void UpdateTotalPrice(object sender, EventArgs e)
        {
            float totalPrice = 0;
            for(int i=0;i<lbCart.Items.Count;i++)
            {
                ProductInCart product = lbCart.Items[i] as ProductInCart;
                totalPrice += product.totalPrice();
            }
            tbTotal.Text = String.Format("{0:0.00}", totalPrice);
        }
        private void btnClearProductList_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Испразни ја листата со придукти?"
                ,"Дали сте сигурни дека сакате да ја испразните листата со продукти?"
                ,MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                lbProductList.Items.Clear();
            }
            lbProductList_SelectedIndexChanged(null,null);
        }

        private void btnEmptyCart_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Испразни ја потрошувачката кошничка?"
                , "Дали сте сигурни дека сакате да ја испразните потрошувачката кошница?"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                lbCart.Items.Clear();
            }
            UpdateTotalPrice(null, null);
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            AddProductForm frm = new AddProductForm();
            DialogResult dialogResult=frm.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {   
                string productName = frm.Product.Name;
                for(int i = 0; i < lbProductList.Items.Count; i++)
                {
                    Product product=lbProductList.Items[i] as Product;
                    if(product.Name == productName) 
                    { 
                        product.Category = frm.Product.Category;
                        product.Price = frm.Product.Price;
                        lbProductList.Items.RemoveAt(i);
                    }


                }
                lbProductList.Items.Add(frm.Product);
                comboBoxUpdate();
            }
        }

        private void comboBoxUpdate()
        {
            Product product;
            cb1.Items.Clear();
            cb1.Items.Add("-1");
            for(int i = 0; i < lbProductList.Items.Count; i++)
            {
                product=lbProductList.Items[i] as Product;
                if (!cb1.Items.Contains(product.Category))
                {
                    cb1.Items.Add(product.Category);
                }
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(lbProductList.SelectedItem != null && nudQuantity.Value!=0)
            {   
                Product product = lbProductList.SelectedItem as Product;
                float quantity = (float)nudQuantity.Value;
                for(int i = 0; i < lbCart.Items.Count; i++)
                {
                    string productName = product.Name;
                    ProductInCart tmpProductInCart=lbCart.Items[i] as ProductInCart;
                    if (tmpProductInCart.Product.Name == productName)
                    {
                        quantity+=(lbCart.Items[i] as ProductInCart).Quantity;
                        lbCart.Items.RemoveAt(i);
                        break;
                    }
                }
                ProductInCart productInCart = new ProductInCart(product, quantity);
                lbCart.Items.Add(productInCart);
            }
            UpdateTotalPrice(null,null);
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (lbProductList.SelectedItem != null)
            {
                lbProductList.Items.Remove(lbProductList.SelectedItem);
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lbCart.SelectedItem != null)
            {
                lbCart.Items.Remove(lbCart.SelectedItem);
            }
            UpdateTotalPrice(null, null);
        }

        private void lbProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = lbProductList.SelectedItem as Product;
            if (product != null)
            {
                tbName.Text = product.Name;
                tbCategory.Text = product.Category;
                tbPrice.Text = String.Format("{0:0.00}", product.Price);
            }
            else
            {
                tbName.Text = tbCategory.Text = tbPrice.Text = "";
            }
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
