namespace ShopingCart
{
    partial class AddProductForm
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btdAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Име";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(22, 81);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(79, 16);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Категорија";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(22, 140);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 16);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Цена";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(25, 47);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(249, 22);
            this.tbName.TabIndex = 4;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(26, 159);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(147, 22);
            this.tbPrice.TabIndex = 0;
            this.tbPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrice_Validating);
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(25, 105);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(249, 22);
            this.tbCategory.TabIndex = 5;
            this.tbCategory.Validating += new System.ComponentModel.CancelEventHandler(this.tbCategory_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(116, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btdAdd
            // 
            this.btdAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btdAdd.Location = new System.Drawing.Point(204, 198);
            this.btdAdd.Name = "btdAdd";
            this.btdAdd.Size = new System.Drawing.Size(75, 23);
            this.btdAdd.TabIndex = 7;
            this.btdAdd.Text = "Додади";
            this.btdAdd.UseVisualStyleBackColor = true;
            this.btdAdd.Click += new System.EventHandler(this.btdAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddProductForm
            // 
            this.AcceptButton = this.btdAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(342, 233);
            this.Controls.Add(this.btdAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblName);
            this.Name = "AddProductForm";
            this.Text = "Нов продукт";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btdAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}