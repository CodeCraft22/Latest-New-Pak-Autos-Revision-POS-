namespace Csharp_Project
{
    partial class FORM_NEW_PRODUCT
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
            this.COMBO_CATEGORIES = new System.Windows.Forms.ComboBox();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.TB_DESCRIPTION = new System.Windows.Forms.TextBox();
            this.TB_QUANTITY = new System.Windows.Forms.TextBox();
            this.TB_PRICE = new System.Windows.Forms.TextBox();
            this.PB_BROWSE_IMAGE = new System.Windows.Forms.PictureBox();
            this.BTN_ADD_CATEGORY = new System.Windows.Forms.Button();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.txthexadecimalBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinimumQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.txtQuantityUnit = new System.Windows.Forms.Label();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPurchase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWholesale = new System.Windows.Forms.TextBox();
            this.WholeSale = new System.Windows.Forms.Label();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.lbllocation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Cancel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel_Min = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BROWSE_IMAGE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Cancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Panel_Min.SuspendLayout();
            this.SuspendLayout();
            // 
            // COMBO_CATEGORIES
            // 
            this.COMBO_CATEGORIES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_CATEGORIES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMBO_CATEGORIES.FormattingEnabled = true;
            this.COMBO_CATEGORIES.Location = new System.Drawing.Point(154, 125);
            this.COMBO_CATEGORIES.Name = "COMBO_CATEGORIES";
            this.COMBO_CATEGORIES.Size = new System.Drawing.Size(193, 21);
            this.COMBO_CATEGORIES.TabIndex = 1;
            // 
            // TB_NAME
            // 
            this.TB_NAME.Location = new System.Drawing.Point(154, 184);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(250, 20);
            this.TB_NAME.TabIndex = 4;
            // 
            // TB_DESCRIPTION
            // 
            this.TB_DESCRIPTION.Location = new System.Drawing.Point(154, 230);
            this.TB_DESCRIPTION.Multiline = true;
            this.TB_DESCRIPTION.Name = "TB_DESCRIPTION";
            this.TB_DESCRIPTION.Size = new System.Drawing.Size(250, 58);
            this.TB_DESCRIPTION.TabIndex = 6;
            // 
            // TB_QUANTITY
            // 
            this.TB_QUANTITY.Location = new System.Drawing.Point(154, 308);
            this.TB_QUANTITY.Name = "TB_QUANTITY";
            this.TB_QUANTITY.Size = new System.Drawing.Size(250, 20);
            this.TB_QUANTITY.TabIndex = 8;
            this.TB_QUANTITY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_QUANTITY_KeyPress);
            // 
            // TB_PRICE
            // 
            this.TB_PRICE.Location = new System.Drawing.Point(154, 372);
            this.TB_PRICE.Name = "TB_PRICE";
            this.TB_PRICE.Size = new System.Drawing.Size(250, 20);
            this.TB_PRICE.TabIndex = 10;
            this.TB_PRICE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_PRICE_KeyPress);
            // 
            // PB_BROWSE_IMAGE
            // 
            this.PB_BROWSE_IMAGE.BackColor = System.Drawing.Color.Transparent;
            this.PB_BROWSE_IMAGE.Location = new System.Drawing.Point(170, 451);
            this.PB_BROWSE_IMAGE.Name = "PB_BROWSE_IMAGE";
            this.PB_BROWSE_IMAGE.Size = new System.Drawing.Size(290, 152);
            this.PB_BROWSE_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_BROWSE_IMAGE.TabIndex = 8;
            this.PB_BROWSE_IMAGE.TabStop = false;
            this.PB_BROWSE_IMAGE.Click += new System.EventHandler(this.PB_BROWSE_IMAGE_Click);
            // 
            // BTN_ADD_CATEGORY
            // 
            this.BTN_ADD_CATEGORY.BackColor = System.Drawing.Color.Black;
            this.BTN_ADD_CATEGORY.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_ADD_CATEGORY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_ADD_CATEGORY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_ADD_CATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD_CATEGORY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADD_CATEGORY.ForeColor = System.Drawing.Color.White;
            this.BTN_ADD_CATEGORY.Location = new System.Drawing.Point(359, 118);
            this.BTN_ADD_CATEGORY.Name = "BTN_ADD_CATEGORY";
            this.BTN_ADD_CATEGORY.Size = new System.Drawing.Size(132, 33);
            this.BTN_ADD_CATEGORY.TabIndex = 2;
            this.BTN_ADD_CATEGORY.Text = "Add New Categorie";
            this.BTN_ADD_CATEGORY.UseVisualStyleBackColor = false;
            this.BTN_ADD_CATEGORY.Click += new System.EventHandler(this.BTN_ADD_CATEGORY_Click);
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.BackColor = System.Drawing.Color.Black;
            this.BTN_CANCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_CANCEL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_CANCEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_CANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CANCEL.ForeColor = System.Drawing.Color.White;
            this.BTN_CANCEL.Location = new System.Drawing.Point(98, 638);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(115, 40);
            this.BTN_CANCEL.TabIndex = 14;
            this.BTN_CANCEL.Text = "Cancel";
            this.BTN_CANCEL.UseVisualStyleBackColor = false;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.BackColor = System.Drawing.Color.Black;
            this.BTN_ADD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_ADD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_ADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADD.ForeColor = System.Drawing.Color.White;
            this.BTN_ADD.Location = new System.Drawing.Point(232, 638);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(115, 40);
            this.BTN_ADD.TabIndex = 13;
            this.BTN_ADD.Text = "Add";
            this.BTN_ADD.UseVisualStyleBackColor = false;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // txthexadecimalBarcode
            // 
            this.txthexadecimalBarcode.Location = new System.Drawing.Point(154, 157);
            this.txthexadecimalBarcode.Name = "txthexadecimalBarcode";
            this.txthexadecimalBarcode.Size = new System.Drawing.Size(250, 20);
            this.txthexadecimalBarcode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "PRODUCT BARCODE";
            // 
            // txtMinimumQuantity
            // 
            this.txtMinimumQuantity.Location = new System.Drawing.Point(154, 398);
            this.txtMinimumQuantity.Name = "txtMinimumQuantity";
            this.txtMinimumQuantity.Size = new System.Drawing.Size(250, 20);
            this.txtMinimumQuantity.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Minimum Quantity";
            // 
            // cmbQuantity
            // 
            this.cmbQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbQuantity.FormattingEnabled = true;
            this.cmbQuantity.Location = new System.Drawing.Point(154, 334);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(250, 21);
            this.cmbQuantity.TabIndex = 9;
            // 
            // txtQuantityUnit
            // 
            this.txtQuantityUnit.AutoSize = true;
            this.txtQuantityUnit.Location = new System.Drawing.Point(48, 337);
            this.txtQuantityUnit.Name = "txtQuantityUnit";
            this.txtQuantityUnit.Size = new System.Drawing.Size(71, 13);
            this.txtQuantityUnit.TabIndex = 27;
            this.txtQuantityUnit.Text = " Quantity Unit";
            // 
            // txtbrand
            // 
            this.txtbrand.Location = new System.Drawing.Point(154, 210);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(250, 20);
            this.txtbrand.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Brand Name";
            // 
            // txtPurchase
            // 
            this.txtPurchase.Location = new System.Drawing.Point(154, 288);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Size = new System.Drawing.Size(250, 20);
            this.txtPurchase.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Purchase Price";
            // 
            // txtWholesale
            // 
            this.txtWholesale.Location = new System.Drawing.Point(154, 609);
            this.txtWholesale.Name = "txtWholesale";
            this.txtWholesale.Size = new System.Drawing.Size(250, 20);
            this.txtWholesale.TabIndex = 12;
            // 
            // WholeSale
            // 
            this.WholeSale.AutoSize = true;
            this.WholeSale.Location = new System.Drawing.Point(61, 612);
            this.WholeSale.Name = "WholeSale";
            this.WholeSale.Size = new System.Drawing.Size(87, 13);
            this.WholeSale.TabIndex = 33;
            this.WholeSale.Text = "Whole sale Price";
            // 
            // txtlocation
            // 
            this.txtlocation.Location = new System.Drawing.Point(154, 99);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(250, 20);
            this.txtlocation.TabIndex = 0;
            // 
            // lbllocation
            // 
            this.lbllocation.AutoSize = true;
            this.lbllocation.Location = new System.Drawing.Point(61, 102);
            this.lbllocation.Name = "lbllocation";
            this.lbllocation.Size = new System.Drawing.Size(48, 13);
            this.lbllocation.TabIndex = 35;
            this.lbllocation.Text = "Location";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Csharp_Project.Properties.Resources.small_close;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 31);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Panel_Cancel
            // 
            this.Panel_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Cancel.Controls.Add(this.pictureBox1);
            this.Panel_Cancel.Location = new System.Drawing.Point(347, 0);
            this.Panel_Cancel.Name = "Panel_Cancel";
            this.Panel_Cancel.Size = new System.Drawing.Size(57, 37);
            this.Panel_Cancel.TabIndex = 40;
            this.Panel_Cancel.Click += new System.EventHandler(this.PANEL_CLOSE_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Csharp_Project.Properties.Resources.small_minimize;
            this.pictureBox2.Location = new System.Drawing.Point(14, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 31);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Panel_Min
            // 
            this.Panel_Min.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Min.Controls.Add(this.pictureBox2);
            this.Panel_Min.Location = new System.Drawing.Point(410, 0);
            this.Panel_Min.Name = "Panel_Min";
            this.Panel_Min.Size = new System.Drawing.Size(75, 37);
            this.Panel_Min.TabIndex = 41;
            // 
            // FORM_NEW_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Csharp_Project.Properties.Resources.New_Product;
            this.ClientSize = new System.Drawing.Size(497, 701);
            this.Controls.Add(this.Panel_Min);
            this.Controls.Add(this.Panel_Cancel);
            this.Controls.Add(this.lbllocation);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.WholeSale);
            this.Controls.Add(this.txtWholesale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPurchase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbrand);
            this.Controls.Add(this.txtQuantityUnit);
            this.Controls.Add(this.cmbQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinimumQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthexadecimalBarcode);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.BTN_ADD_CATEGORY);
            this.Controls.Add(this.PB_BROWSE_IMAGE);
            this.Controls.Add(this.TB_PRICE);
            this.Controls.Add(this.TB_QUANTITY);
            this.Controls.Add(this.TB_DESCRIPTION);
            this.Controls.Add(this.TB_NAME);
            this.Controls.Add(this.COMBO_CATEGORIES);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_NEW_PRODUCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product";
            ((System.ComponentModel.ISupportInitialize)(this.PB_BROWSE_IMAGE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Cancel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Panel_Min.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_NAME;
        private System.Windows.Forms.TextBox TB_DESCRIPTION;
        private System.Windows.Forms.TextBox TB_QUANTITY;
        private System.Windows.Forms.TextBox TB_PRICE;
        private System.Windows.Forms.PictureBox PB_BROWSE_IMAGE;
        private System.Windows.Forms.Button BTN_ADD_CATEGORY;
        public System.Windows.Forms.ComboBox COMBO_CATEGORIES;
        private System.Windows.Forms.Button BTN_CANCEL;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.TextBox txthexadecimalBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinimumQuantity;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbQuantity;
        private System.Windows.Forms.Label txtQuantityUnit;
        private System.Windows.Forms.TextBox txtbrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPurchase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWholesale;
        private System.Windows.Forms.Label WholeSale;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.Label lbllocation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Panel_Cancel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Panel_Min;
    }
}