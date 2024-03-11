namespace pizza
{
    public partial class pizza : Form
    {
        public int IceCreamPrice = 80; 
        public int CakePrice = 120; 
        public int PiePrice = 100; 
        public pizza()
        {
            InitializeComponent();
        }
        private void calculateTotalPrice(object sender, EventArgs e)
        {
            int totalPrice = 0;
            if (rbSmall.Checked)
            {
                int smallPizzaPrice = 0;
                int.TryParse(tbPriceSmall.Text, out smallPizzaPrice);
                totalPrice+=smallPizzaPrice;
            }
            else if (rbMedium.Checked)
            {
                int mediumPizzaPrice = 0;
                int.TryParse(tbPriceMedium.Text, out mediumPizzaPrice);
                totalPrice+=mediumPizzaPrice;
            }
            else if (rbBig.Checked)
            {
                int bigPizzaPrice = 0;
                int.TryParse (tbPriceBig.Text, out bigPizzaPrice);
                totalPrice+=bigPizzaPrice;
            }

            if (cbPepperoni.Checked)
            {
                int pepperoniPrice = 0;
                int.TryParse(tbPricePeperoni.Text, out pepperoniPrice);
                totalPrice += pepperoniPrice;
            }
            if (cbExtraCheese.Checked)
            {
                int extraCheesePrice = 0;
                int.TryParse(tbPriceExtraCheese.Text, out extraCheesePrice);
                totalPrice += extraCheesePrice;
            }
            if (cbKetchup.Checked)
            {
                int ketchupPrice = 0;
                int.TryParse(tbPriceKetchup.Text, out ketchupPrice);
                totalPrice += ketchupPrice;
            }

            int sodaQuantity = 0;
            int.TryParse(tbSodaQuantity.Text, out sodaQuantity);
            int sodaPrice = 0;
            int.TryParse(tbSodaPrice.Text, out sodaPrice);
            int sodaTotalPrice= sodaPrice * sodaQuantity;
            totalPrice += sodaTotalPrice;
            tbSodaTotalPrice.Text = sodaTotalPrice.ToString();

            int juiceQuantity = 0;
            int.TryParse(tbJuiceQuantity.Text, out juiceQuantity);
            int juicePrice = 0;
            int.TryParse(tbJuicePrice.Text, out juicePrice);
            totalPrice += juicePrice * juiceQuantity;
            tbJuiceTotalPrice.Text = (juicePrice*juiceQuantity).ToString();

            int beerQuantity = 0;
            int.TryParse(tbBeerQuantity.Text, out beerQuantity);
            int beerPrice = 0;
            int.TryParse(tbBeerPrice.Text, out beerPrice);
            totalPrice+=beerPrice * beerQuantity;
            tbBeerTotalPrice.Text = (beerPrice*beerQuantity).ToString();

            if(lbDesert.SelectedItems.Count > 0)
            {
                int desertPrice = 0;
                int.TryParse(tbDesertPrice.Text, out desertPrice);
                totalPrice += desertPrice;
            }

            tbTotalPrice.Text=totalPrice.ToString();
        }

        private void tbPaidPrice_TextChanged(object sender, EventArgs e)
        {
            int totalPrice=0;
            int.TryParse(tbTotalPrice.Text, out totalPrice);
            int paidPrice=0;
            int.TryParse(tbPaidPrice.Text, out paidPrice);
            if(totalPrice>0 && totalPrice<paidPrice)
            {
                tbReturn.Text = (paidPrice - totalPrice).ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сте сигурни дека сакате да ја откажете нарачката?", "Откажи",
                MessageBoxButtons.YesNo, // vid na dijalogot 
                MessageBoxIcon.Question); // ikona na dijalogot
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string msg="";
            if (rbSmall.Checked) { msg += "Мала"; }
            else if (rbMedium.Checked) { msg += "Средна"; }
            else { msg += "Голема"; }
            msg += " пица\n";
            if(cbExtraCheese.Checked || cbKetchup.Checked || cbPepperoni.Checked) { msg += "Додатоци\n"; }
            if (cbPepperoni.Checked) { msg += "Феферонки\n"; }
            if (cbExtraCheese.Checked) { msg += "Екстра сирење\n"; }
            if (cbKetchup.Checked) { msg += "Кечап\n"; }

            int juiceQuantity=0;
            int.TryParse(tbJuiceQuantity.Text, out juiceQuantity);
            int sodaQuantity=0;
            int.TryParse(tbSodaQuantity.Text, out sodaQuantity);
            int beerQuantity=0;
            int.TryParse(tbBeerQuantity.Text, out beerQuantity);
            if(juiceQuantity>0 || sodaQuantity>0 || beerQuantity > 0) { msg += "Пијалоци\n"; }
            if (sodaQuantity > 0) { msg += String.Format("{0} Кока кола / Фанта / Спрајт\n",sodaQuantity); }
            if (juiceQuantity > 0) { msg += String.Format("{0} Сок од портокал/ јаболко\n", juiceQuantity); }
            if (beerQuantity > 0) { msg += String.Format("{0} Пиво\n",beerQuantity); }

            if(lbDesert.SelectedItem != null) { msg += "Десерт\n" + lbDesert.SelectedItem.ToString(); }

            MessageBox.Show(msg);

        }
        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = !radioButton1.Checked;
        }
    }
    
}