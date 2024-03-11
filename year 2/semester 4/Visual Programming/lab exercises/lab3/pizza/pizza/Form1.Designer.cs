namespace pizza
{
    partial class pizza
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbTopping = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tbPriceExtraCheese = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tbPriceKetchup = new System.Windows.Forms.TextBox();
            this.tbPricePeperoni = new System.Windows.Forms.TextBox();
            this.cbKetchup = new System.Windows.Forms.CheckBox();
            this.cbExtraCheese = new System.Windows.Forms.CheckBox();
            this.cbPepperoni = new System.Windows.Forms.CheckBox();
            this.gbDrinks = new System.Windows.Forms.GroupBox();
            this.tbBeerTotalPrice = new System.Windows.Forms.TextBox();
            this.tbJuiceTotalPrice = new System.Windows.Forms.TextBox();
            this.tbSodaTotalPrice = new System.Windows.Forms.TextBox();
            this.tbJuicePrice = new System.Windows.Forms.TextBox();
            this.tbSodaPrice = new System.Windows.Forms.TextBox();
            this.tbBeerPrice = new System.Windows.Forms.TextBox();
            this.tbSodaQuantity = new System.Windows.Forms.TextBox();
            this.tbJuiceQuantity = new System.Windows.Forms.TextBox();
            this.tbBeerQuantity = new System.Windows.Forms.TextBox();
            this.lblSoda = new System.Windows.Forms.Label();
            this.lblPriceDrinks = new System.Windows.Forms.Label();
            this.lblJuice = new System.Windows.Forms.Label();
            this.lblTotalPriceDrinks = new System.Windows.Forms.Label();
            this.lblBeer = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.gbDesert = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.tbDesertPrice = new System.Windows.Forms.TextBox();
            this.lblDesertPrice = new System.Windows.Forms.Label();
            this.lbDesert = new System.Windows.Forms.ListBox();
            this.gbPayment = new System.Windows.Forms.GroupBox();
            this.tbReturn = new System.Windows.Forms.TextBox();
            this.tbPaidPrice = new System.Windows.Forms.TextBox();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblPaidPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbBig = new System.Windows.Forms.RadioButton();
            this.tbPriceSmall = new System.Windows.Forms.TextBox();
            this.tbPriceMedium = new System.Windows.Forms.TextBox();
            this.tbPriceBig = new System.Windows.Forms.TextBox();
            this.gbTopping.SuspendLayout();
            this.gbDrinks.SuspendLayout();
            this.gbDesert.SuspendLayout();
            this.gbPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTopping
            // 
            this.gbTopping.Controls.Add(this.radioButton2);
            this.gbTopping.Controls.Add(this.tbPriceExtraCheese);
            this.gbTopping.Controls.Add(this.radioButton1);
            this.gbTopping.Controls.Add(this.tbPriceKetchup);
            this.gbTopping.Controls.Add(this.tbPricePeperoni);
            this.gbTopping.Controls.Add(this.cbKetchup);
            this.gbTopping.Controls.Add(this.cbExtraCheese);
            this.gbTopping.Controls.Add(this.cbPepperoni);
            this.gbTopping.Location = new System.Drawing.Point(396, 12);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Size = new System.Drawing.Size(393, 125);
            this.gbTopping.TabIndex = 1;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "Додатоци";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(123, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // tbPriceExtraCheese
            // 
            this.tbPriceExtraCheese.Location = new System.Drawing.Point(262, 56);
            this.tbPriceExtraCheese.Name = "tbPriceExtraCheese";
            this.tbPriceExtraCheese.Size = new System.Drawing.Size(125, 27);
            this.tbPriceExtraCheese.TabIndex = 4;
            this.tbPriceExtraCheese.Text = "30";
            this.tbPriceExtraCheese.TextChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(123, 90);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 24);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // tbPriceKetchup
            // 
            this.tbPriceKetchup.Location = new System.Drawing.Point(262, 89);
            this.tbPriceKetchup.Name = "tbPriceKetchup";
            this.tbPriceKetchup.Size = new System.Drawing.Size(125, 27);
            this.tbPriceKetchup.TabIndex = 5;
            this.tbPriceKetchup.Text = "20";
            this.tbPriceKetchup.TextChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // tbPricePeperoni
            // 
            this.tbPricePeperoni.Location = new System.Drawing.Point(262, 23);
            this.tbPricePeperoni.Name = "tbPricePeperoni";
            this.tbPricePeperoni.Size = new System.Drawing.Size(125, 27);
            this.tbPricePeperoni.TabIndex = 3;
            this.tbPricePeperoni.Text = "40";
            this.tbPricePeperoni.TextChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // cbKetchup
            // 
            this.cbKetchup.AutoSize = true;
            this.cbKetchup.Location = new System.Drawing.Point(6, 92);
            this.cbKetchup.Name = "cbKetchup";
            this.cbKetchup.Size = new System.Drawing.Size(73, 24);
            this.cbKetchup.TabIndex = 2;
            this.cbKetchup.Text = "Кечап";
            this.cbKetchup.UseVisualStyleBackColor = true;
            this.cbKetchup.CheckedChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // cbExtraCheese
            // 
            this.cbExtraCheese.AutoSize = true;
            this.cbExtraCheese.Location = new System.Drawing.Point(6, 59);
            this.cbExtraCheese.Name = "cbExtraCheese";
            this.cbExtraCheese.Size = new System.Drawing.Size(133, 24);
            this.cbExtraCheese.TabIndex = 1;
            this.cbExtraCheese.Text = "Екстра сирење";
            this.cbExtraCheese.UseVisualStyleBackColor = true;
            this.cbExtraCheese.CheckedChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // cbPepperoni
            // 
            this.cbPepperoni.AutoSize = true;
            this.cbPepperoni.Location = new System.Drawing.Point(6, 26);
            this.cbPepperoni.Name = "cbPepperoni";
            this.cbPepperoni.Size = new System.Drawing.Size(111, 24);
            this.cbPepperoni.TabIndex = 0;
            this.cbPepperoni.Text = "Феферонки";
            this.cbPepperoni.UseVisualStyleBackColor = true;
            this.cbPepperoni.CheckedChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // gbDrinks
            // 
            this.gbDrinks.Controls.Add(this.tbBeerTotalPrice);
            this.gbDrinks.Controls.Add(this.tbJuiceTotalPrice);
            this.gbDrinks.Controls.Add(this.tbSodaTotalPrice);
            this.gbDrinks.Controls.Add(this.tbJuicePrice);
            this.gbDrinks.Controls.Add(this.tbSodaPrice);
            this.gbDrinks.Controls.Add(this.tbBeerPrice);
            this.gbDrinks.Controls.Add(this.tbSodaQuantity);
            this.gbDrinks.Controls.Add(this.tbJuiceQuantity);
            this.gbDrinks.Controls.Add(this.tbBeerQuantity);
            this.gbDrinks.Controls.Add(this.lblSoda);
            this.gbDrinks.Controls.Add(this.lblPriceDrinks);
            this.gbDrinks.Controls.Add(this.lblJuice);
            this.gbDrinks.Controls.Add(this.lblTotalPriceDrinks);
            this.gbDrinks.Controls.Add(this.lblBeer);
            this.gbDrinks.Controls.Add(this.lblQuantity);
            this.gbDrinks.Location = new System.Drawing.Point(12, 143);
            this.gbDrinks.Name = "gbDrinks";
            this.gbDrinks.Size = new System.Drawing.Size(777, 148);
            this.gbDrinks.TabIndex = 2;
            this.gbDrinks.TabStop = false;
            this.gbDrinks.Text = "Пијалоци";
            // 
            // tbBeerTotalPrice
            // 
            this.tbBeerTotalPrice.Location = new System.Drawing.Point(627, 113);
            this.tbBeerTotalPrice.Name = "tbBeerTotalPrice";
            this.tbBeerTotalPrice.ReadOnly = true;
            this.tbBeerTotalPrice.Size = new System.Drawing.Size(125, 27);
            this.tbBeerTotalPrice.TabIndex = 11;
            // 
            // tbJuiceTotalPrice
            // 
            this.tbJuiceTotalPrice.Location = new System.Drawing.Point(627, 80);
            this.tbJuiceTotalPrice.Name = "tbJuiceTotalPrice";
            this.tbJuiceTotalPrice.ReadOnly = true;
            this.tbJuiceTotalPrice.Size = new System.Drawing.Size(125, 27);
            this.tbJuiceTotalPrice.TabIndex = 10;
            // 
            // tbSodaTotalPrice
            // 
            this.tbSodaTotalPrice.Location = new System.Drawing.Point(627, 47);
            this.tbSodaTotalPrice.Name = "tbSodaTotalPrice";
            this.tbSodaTotalPrice.ReadOnly = true;
            this.tbSodaTotalPrice.Size = new System.Drawing.Size(125, 27);
            this.tbSodaTotalPrice.TabIndex = 9;
            // 
            // tbJuicePrice
            // 
            this.tbJuicePrice.Location = new System.Drawing.Point(448, 82);
            this.tbJuicePrice.Name = "tbJuicePrice";
            this.tbJuicePrice.Size = new System.Drawing.Size(125, 27);
            this.tbJuicePrice.TabIndex = 7;
            this.tbJuicePrice.Text = "70";
            this.tbJuicePrice.TextChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // tbSodaPrice
            // 
            this.tbSodaPrice.Location = new System.Drawing.Point(448, 49);
            this.tbSodaPrice.Name = "tbSodaPrice";
            this.tbSodaPrice.Size = new System.Drawing.Size(125, 27);
            this.tbSodaPrice.TabIndex = 6;
            this.tbSodaPrice.Text = "60";
            this.tbSodaPrice.TextChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // tbBeerPrice
            // 
            this.tbBeerPrice.Location = new System.Drawing.Point(448, 115);
            this.tbBeerPrice.Name = "tbBeerPrice";
            this.tbBeerPrice.Size = new System.Drawing.Size(125, 27);
            this.tbBeerPrice.TabIndex = 8;
            this.tbBeerPrice.Text = "80";
            this.tbBeerPrice.TextChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // tbSodaQuantity
            // 
            this.tbSodaQuantity.Location = new System.Drawing.Point(271, 47);
            this.tbSodaQuantity.Name = "tbSodaQuantity";
            this.tbSodaQuantity.Size = new System.Drawing.Size(125, 27);
            this.tbSodaQuantity.TabIndex = 3;
            this.tbSodaQuantity.Text = "0";
            this.tbSodaQuantity.TextChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // tbJuiceQuantity
            // 
            this.tbJuiceQuantity.Location = new System.Drawing.Point(271, 80);
            this.tbJuiceQuantity.Name = "tbJuiceQuantity";
            this.tbJuiceQuantity.Size = new System.Drawing.Size(125, 27);
            this.tbJuiceQuantity.TabIndex = 4;
            this.tbJuiceQuantity.Text = "0";
            this.tbJuiceQuantity.TextChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // tbBeerQuantity
            // 
            this.tbBeerQuantity.Location = new System.Drawing.Point(271, 113);
            this.tbBeerQuantity.Name = "tbBeerQuantity";
            this.tbBeerQuantity.Size = new System.Drawing.Size(125, 27);
            this.tbBeerQuantity.TabIndex = 5;
            this.tbBeerQuantity.Text = "0";
            this.tbBeerQuantity.TextChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // lblSoda
            // 
            this.lblSoda.AutoSize = true;
            this.lblSoda.Location = new System.Drawing.Point(6, 47);
            this.lblSoda.Name = "lblSoda";
            this.lblSoda.Size = new System.Drawing.Size(201, 20);
            this.lblSoda.TabIndex = 0;
            this.lblSoda.Text = "Кока кола / Фанта  / Спрајт ";
            // 
            // lblPriceDrinks
            // 
            this.lblPriceDrinks.AutoSize = true;
            this.lblPriceDrinks.Location = new System.Drawing.Point(489, 23);
            this.lblPriceDrinks.Name = "lblPriceDrinks";
            this.lblPriceDrinks.Size = new System.Drawing.Size(45, 20);
            this.lblPriceDrinks.TabIndex = 13;
            this.lblPriceDrinks.Text = "Цена";
            // 
            // lblJuice
            // 
            this.lblJuice.AutoSize = true;
            this.lblJuice.Location = new System.Drawing.Point(6, 83);
            this.lblJuice.Name = "lblJuice";
            this.lblJuice.Size = new System.Drawing.Size(192, 20);
            this.lblJuice.TabIndex = 1;
            this.lblJuice.Text = "Сок од јаболко / протокал";
            // 
            // lblTotalPriceDrinks
            // 
            this.lblTotalPriceDrinks.AutoSize = true;
            this.lblTotalPriceDrinks.Location = new System.Drawing.Point(655, 23);
            this.lblTotalPriceDrinks.Name = "lblTotalPriceDrinks";
            this.lblTotalPriceDrinks.Size = new System.Drawing.Size(59, 20);
            this.lblTotalPriceDrinks.TabIndex = 14;
            this.lblTotalPriceDrinks.Text = "Вкупно";
            // 
            // lblBeer
            // 
            this.lblBeer.AutoSize = true;
            this.lblBeer.Location = new System.Drawing.Point(6, 112);
            this.lblBeer.Name = "lblBeer";
            this.lblBeer.Size = new System.Drawing.Size(46, 20);
            this.lblBeer.TabIndex = 2;
            this.lblBeer.Text = "Пиво";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(300, 23);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(78, 20);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Количина";
            // 
            // gbDesert
            // 
            this.gbDesert.Controls.Add(this.btnCancel);
            this.gbDesert.Controls.Add(this.btnAccept);
            this.gbDesert.Controls.Add(this.tbDesertPrice);
            this.gbDesert.Controls.Add(this.lblDesertPrice);
            this.gbDesert.Controls.Add(this.lbDesert);
            this.gbDesert.Location = new System.Drawing.Point(12, 297);
            this.gbDesert.Name = "gbDesert";
            this.gbDesert.Size = new System.Drawing.Size(378, 165);
            this.gbDesert.TabIndex = 3;
            this.gbDesert.TabStop = false;
            this.gbDesert.Text = "Десерт";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(231, 124);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(231, 82);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(128, 29);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Нарачај";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // tbDesertPrice
            // 
            this.tbDesertPrice.Location = new System.Drawing.Point(231, 49);
            this.tbDesertPrice.Name = "tbDesertPrice";
            this.tbDesertPrice.Size = new System.Drawing.Size(128, 27);
            this.tbDesertPrice.TabIndex = 2;
            this.tbDesertPrice.TextChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // lblDesertPrice
            // 
            this.lblDesertPrice.AutoSize = true;
            this.lblDesertPrice.Location = new System.Drawing.Point(234, 26);
            this.lblDesertPrice.Name = "lblDesertPrice";
            this.lblDesertPrice.Size = new System.Drawing.Size(119, 20);
            this.lblDesertPrice.TabIndex = 1;
            this.lblDesertPrice.Text = "Цена на десерт:";
            // 
            // lbDesert
            // 
            this.lbDesert.FormattingEnabled = true;
            this.lbDesert.ItemHeight = 20;
            this.lbDesert.Items.AddRange(new object[] {
            "Овошна пита",
            "Сладолед",
            "Торта"});
            this.lbDesert.Location = new System.Drawing.Point(16, 35);
            this.lbDesert.Name = "lbDesert";
            this.lbDesert.Size = new System.Drawing.Size(182, 124);
            this.lbDesert.TabIndex = 0;
            this.lbDesert.SelectedIndexChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // gbPayment
            // 
            this.gbPayment.Controls.Add(this.tbReturn);
            this.gbPayment.Controls.Add(this.tbPaidPrice);
            this.gbPayment.Controls.Add(this.tbTotalPrice);
            this.gbPayment.Controls.Add(this.lblReturn);
            this.gbPayment.Controls.Add(this.lblPaidPrice);
            this.gbPayment.Controls.Add(this.lblTotalPrice);
            this.gbPayment.Location = new System.Drawing.Point(396, 297);
            this.gbPayment.Name = "gbPayment";
            this.gbPayment.Size = new System.Drawing.Size(393, 166);
            this.gbPayment.TabIndex = 4;
            this.gbPayment.TabStop = false;
            this.gbPayment.Text = "Наплата";
            // 
            // tbReturn
            // 
            this.tbReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReturn.Location = new System.Drawing.Point(222, 119);
            this.tbReturn.Name = "tbReturn";
            this.tbReturn.ReadOnly = true;
            this.tbReturn.Size = new System.Drawing.Size(125, 34);
            this.tbReturn.TabIndex = 5;
            this.tbReturn.Text = "0";
            // 
            // tbPaidPrice
            // 
            this.tbPaidPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPaidPrice.Location = new System.Drawing.Point(222, 74);
            this.tbPaidPrice.Name = "tbPaidPrice";
            this.tbPaidPrice.Size = new System.Drawing.Size(125, 34);
            this.tbPaidPrice.TabIndex = 3;
            this.tbPaidPrice.Text = "0";
            this.tbPaidPrice.TextChanged += new System.EventHandler(this.tbPaidPrice_TextChanged);
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTotalPrice.Location = new System.Drawing.Point(222, 25);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(125, 34);
            this.tbTotalPrice.TabIndex = 1;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(54, 124);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(89, 20);
            this.lblReturn.TabIndex = 4;
            this.lblReturn.Text = "За враќање";
            // 
            // lblPaidPrice
            // 
            this.lblPaidPrice.AutoSize = true;
            this.lblPaidPrice.Location = new System.Drawing.Point(54, 82);
            this.lblPaidPrice.Name = "lblPaidPrice";
            this.lblPaidPrice.Size = new System.Drawing.Size(85, 20);
            this.lblPaidPrice.TabIndex = 2;
            this.lblPaidPrice.Text = "Наплатено";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(51, 35);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(138, 20);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "Вкупно за наплата";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(28, 38);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(67, 24);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Text = "Мала";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(28, 71);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(81, 24);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.Text = "Средна";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // rbBig
            // 
            this.rbBig.AutoSize = true;
            this.rbBig.Location = new System.Drawing.Point(28, 113);
            this.rbBig.Name = "rbBig";
            this.rbBig.Size = new System.Drawing.Size(81, 24);
            this.rbBig.TabIndex = 2;
            this.rbBig.Text = "Голема";
            this.rbBig.UseVisualStyleBackColor = true;
            this.rbBig.CheckedChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // tbPriceSmall
            // 
            this.tbPriceSmall.Location = new System.Drawing.Point(203, 35);
            this.tbPriceSmall.Name = "tbPriceSmall";
            this.tbPriceSmall.Size = new System.Drawing.Size(125, 27);
            this.tbPriceSmall.TabIndex = 3;
            this.tbPriceSmall.Text = "200";
            this.tbPriceSmall.TextChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // tbPriceMedium
            // 
            this.tbPriceMedium.Location = new System.Drawing.Point(203, 68);
            this.tbPriceMedium.Name = "tbPriceMedium";
            this.tbPriceMedium.Size = new System.Drawing.Size(125, 27);
            this.tbPriceMedium.TabIndex = 4;
            this.tbPriceMedium.Text = "300";
            this.tbPriceMedium.TextChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // tbPriceBig
            // 
            this.tbPriceBig.Location = new System.Drawing.Point(203, 110);
            this.tbPriceBig.Name = "tbPriceBig";
            this.tbPriceBig.Size = new System.Drawing.Size(125, 27);
            this.tbPriceBig.TabIndex = 5;
            this.tbPriceBig.Text = "500";
            this.tbPriceBig.TextChanged += new System.EventHandler(this.calculateTotalPrice);
            // 
            // pizza
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(888, 591);
            this.Controls.Add(this.tbPriceBig);
            this.Controls.Add(this.gbPayment);
            this.Controls.Add(this.gbDesert);
            this.Controls.Add(this.rbBig);
            this.Controls.Add(this.tbPriceMedium);
            this.Controls.Add(this.tbPriceSmall);
            this.Controls.Add(this.rbMedium);
            this.Controls.Add(this.gbDrinks);
            this.Controls.Add(this.gbTopping);
            this.Controls.Add(this.rbSmall);
            this.Name = "pizza";
            this.Text = "Нарачка на пица";
            this.Load += new System.EventHandler(this.calculateTotalPrice);
            this.gbTopping.ResumeLayout(false);
            this.gbTopping.PerformLayout();
            this.gbDrinks.ResumeLayout(false);
            this.gbDrinks.PerformLayout();
            this.gbDesert.ResumeLayout(false);
            this.gbDesert.PerformLayout();
            this.gbPayment.ResumeLayout(false);
            this.gbPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox gbTopping;
        private TextBox tbPriceExtraCheese;
        private TextBox tbPriceKetchup;
        private TextBox tbPricePeperoni;
        private CheckBox cbKetchup;
        private CheckBox cbExtraCheese;
        private CheckBox cbPepperoni;
        private GroupBox gbDrinks;
        private Label lblSoda;
        private Label lblPriceDrinks;
        private Label lblJuice;
        private Label lblTotalPriceDrinks;
        private Label lblBeer;
        private Label lblQuantity;
        private TextBox tbJuicePrice;
        private TextBox tbSodaPrice;
        private TextBox tbBeerPrice;
        private TextBox tbSodaQuantity;
        private TextBox tbJuiceQuantity;
        private TextBox tbBeerQuantity;
        private TextBox tbBeerTotalPrice;
        private TextBox tbJuiceTotalPrice;
        private TextBox tbSodaTotalPrice;
        private GroupBox gbDesert;
        private Button btnCancel;
        private Button btnAccept;
        private TextBox tbDesertPrice;
        private Label lblDesertPrice;
        private ListBox lbDesert;
        private GroupBox gbPayment;
        private TextBox tbReturn;
        private TextBox tbPaidPrice;
        private TextBox tbTotalPrice;
        private Label lblReturn;
        private Label lblPaidPrice;
        private Label lblTotalPrice;
        private RadioButton rbSmall;
        private RadioButton rbMedium;
        private RadioButton rbBig;
        private TextBox tbPriceSmall;
        private TextBox tbPriceMedium;
        private TextBox tbPriceBig;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}