namespace ShopingCart
{
    partial class ShopingCart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbProductList = new System.Windows.Forms.ListBox();
            this.lblProductList = new System.Windows.Forms.Label();
            this.btnClearProductList = new System.Windows.Forms.Button();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lbCart = new System.Windows.Forms.ListBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnEmptyCart = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProductList
            // 
            this.lbProductList.FormattingEnabled = true;
            this.lbProductList.ItemHeight = 16;
            this.lbProductList.Location = new System.Drawing.Point(12, 32);
            this.lbProductList.Name = "lbProductList";
            this.lbProductList.Size = new System.Drawing.Size(253, 372);
            this.lbProductList.TabIndex = 0;
            this.lbProductList.SelectedIndexChanged += new System.EventHandler(this.lbProductList_SelectedIndexChanged);
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Location = new System.Drawing.Point(13, 13);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(129, 16);
            this.lblProductList.TabIndex = 1;
            this.lblProductList.Text = "Листа со продукти";
            // 
            // btnClearProductList
            // 
            this.btnClearProductList.Location = new System.Drawing.Point(16, 415);
            this.btnClearProductList.Name = "btnClearProductList";
            this.btnClearProductList.Size = new System.Drawing.Size(249, 23);
            this.btnClearProductList.TabIndex = 2;
            this.btnClearProductList.Text = "Изпразни ја листата со продукти?";
            this.btnClearProductList.UseVisualStyleBackColor = true;
            this.btnClearProductList.Click += new System.EventHandler(this.btnClearProductList_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.tbPrice);
            this.gbDetails.Controls.Add(this.tbCategory);
            this.gbDetails.Controls.Add(this.tbName);
            this.gbDetails.Controls.Add(this.lblPrice);
            this.gbDetails.Controls.Add(this.lblCategory);
            this.gbDetails.Controls.Add(this.lblName);
            this.gbDetails.Location = new System.Drawing.Point(287, 32);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(237, 176);
            this.gbDetails.TabIndex = 3;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Детали за продукт";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(9, 134);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(123, 22);
            this.tbPrice.TabIndex = 5;
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(6, 90);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.ReadOnly = true;
            this.tbCategory.Size = new System.Drawing.Size(225, 22);
            this.tbCategory.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(6, 46);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(225, 22);
            this.tbName.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 115);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Цена";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 71);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(79, 16);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Категорија";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Име";
            // 
            // lbCart
            // 
            this.lbCart.FormattingEnabled = true;
            this.lbCart.ItemHeight = 16;
            this.lbCart.Location = new System.Drawing.Point(543, 32);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(245, 340);
            this.lbCart.TabIndex = 4;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(287, 228);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(166, 23);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Додади во кошничка >>";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(287, 267);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(237, 23);
            this.btnRemoveFromCart.TabIndex = 6;
            this.btnRemoveFromCart.Text = "Избриши од кошничка";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(287, 317);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(237, 23);
            this.btnAddNewProduct.TabIndex = 7;
            this.btnAddNewProduct.Text = "Додади нов продукт";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(287, 359);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(237, 23);
            this.btnRemoveProduct.TabIndex = 8;
            this.btnRemoveProduct.Text = "Избриши продукт";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnEmptyCart
            // 
            this.btnEmptyCart.Location = new System.Drawing.Point(543, 415);
            this.btnEmptyCart.Name = "btnEmptyCart";
            this.btnEmptyCart.Size = new System.Drawing.Size(245, 23);
            this.btnEmptyCart.TabIndex = 9;
            this.btnEmptyCart.Text = "Испразни ја кошничката?";
            this.btnEmptyCart.UseVisualStyleBackColor = true;
            this.btnEmptyCart.Click += new System.EventHandler(this.btnEmptyCart_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(558, 379);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 16);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Вкупно";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(619, 379);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(169, 22);
            this.tbTotal.TabIndex = 11;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(543, 12);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(71, 16);
            this.lblCart.TabIndex = 12;
            this.lblCart.Text = "Кошничка";
            // 
            // nudQuantity
            // 
            this.nudQuantity.DecimalPlaces = 1;
            this.nudQuantity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudQuantity.Location = new System.Drawing.Point(459, 229);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(65, 22);
            this.nudQuantity.TabIndex = 6;
            // 
            // cb1
            // 
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "-1"});
            this.cb1.Location = new System.Drawing.Point(287, 401);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(237, 24);
            this.cb1.TabIndex = 13;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // ShopingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnEmptyCart);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lbCart);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.btnClearProductList);
            this.Controls.Add(this.lblProductList);
            this.Controls.Add(this.lbProductList);
            this.Name = "ShopingCart";
            this.Text = "Потрошувачка кошничка";
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProductList;
        private System.Windows.Forms.Label lblProductList;
        private System.Windows.Forms.Button btnClearProductList;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lbCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnEmptyCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.ComboBox cb1;
    }
}

