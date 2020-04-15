namespace Csharp_Project
{
    partial class FORM_UPDATE_PRODUCT
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
            this.PB_BROWSE_IMAGE = new System.Windows.Forms.PictureBox();
            this.TB_PRICE = new System.Windows.Forms.TextBox();
            this.TB_QUANTITY = new System.Windows.Forms.TextBox();
            this.TB_DESCRIPTION = new System.Windows.Forms.TextBox();
            this.TB_NAME = new System.Windows.Forms.TextBox();
            this.COMBO_CATEGORIES = new System.Windows.Forms.ComboBox();
            this.LBL_PID = new System.Windows.Forms.Label();
            this.BTN_UPDATE = new System.Windows.Forms.Button();
            this.BTN_CANCEL = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.Unit = new System.Windows.Forms.Label();
            this.txtMinimum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPurchase = new System.Windows.Forms.TextBox();
            this.WholeSale = new System.Windows.Forms.Label();
            this.txtWholesale = new System.Windows.Forms.TextBox();
            this.txtlocations = new System.Windows.Forms.TextBox();
            this.lbllocation = new System.Windows.Forms.Label();
            this.Panel_Min = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel_Cancel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BROWSE_IMAGE)).BeginInit();
            this.Panel_Min.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Panel_Cancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_BROWSE_IMAGE
            // 
            this.PB_BROWSE_IMAGE.BackColor = System.Drawing.Color.Transparent;
            this.PB_BROWSE_IMAGE.Location = new System.Drawing.Point(170, 430);
            this.PB_BROWSE_IMAGE.Name = "PB_BROWSE_IMAGE";
            this.PB_BROWSE_IMAGE.Size = new System.Drawing.Size(290, 174);
            this.PB_BROWSE_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_BROWSE_IMAGE.TabIndex = 14;
            this.PB_BROWSE_IMAGE.TabStop = false;
            this.PB_BROWSE_IMAGE.Click += new System.EventHandler(this.PB_BROWSE_IMAGE_Click);
            // 
            // TB_PRICE
            // 
            this.TB_PRICE.Location = new System.Drawing.Point(153, 362);
            this.TB_PRICE.Name = "TB_PRICE";
            this.TB_PRICE.Size = new System.Drawing.Size(250, 20);
            this.TB_PRICE.TabIndex = 8;
            this.TB_PRICE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_PRICE_KeyPress);
            // 
            // TB_QUANTITY
            // 
            this.TB_QUANTITY.Location = new System.Drawing.Point(154, 309);
            this.TB_QUANTITY.Name = "TB_QUANTITY";
            this.TB_QUANTITY.Size = new System.Drawing.Size(250, 20);
            this.TB_QUANTITY.TabIndex = 6;
            this.TB_QUANTITY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_QUANTITY_KeyPress);
            // 
            // TB_DESCRIPTION
            // 
            this.TB_DESCRIPTION.Location = new System.Drawing.Point(154, 231);
            this.TB_DESCRIPTION.Multiline = true;
            this.TB_DESCRIPTION.Name = "TB_DESCRIPTION";
            this.TB_DESCRIPTION.Size = new System.Drawing.Size(250, 53);
            this.TB_DESCRIPTION.TabIndex = 4;
            // 
            // TB_NAME
            // 
            this.TB_NAME.Location = new System.Drawing.Point(154, 185);
            this.TB_NAME.Name = "TB_NAME";
            this.TB_NAME.Size = new System.Drawing.Size(250, 20);
            this.TB_NAME.TabIndex = 2;
            // 
            // COMBO_CATEGORIES
            // 
            this.COMBO_CATEGORIES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_CATEGORIES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMBO_CATEGORIES.FormattingEnabled = true;
            this.COMBO_CATEGORIES.Location = new System.Drawing.Point(154, 126);
            this.COMBO_CATEGORIES.Name = "COMBO_CATEGORIES";
            this.COMBO_CATEGORIES.Size = new System.Drawing.Size(250, 21);
            this.COMBO_CATEGORIES.TabIndex = 0;
            this.COMBO_CATEGORIES.SelectedIndexChanged += new System.EventHandler(this.COMBO_CATEGORIES_SelectedIndexChanged);
            // 
            // LBL_PID
            // 
            this.LBL_PID.AutoSize = true;
            this.LBL_PID.Location = new System.Drawing.Point(158, 110);
            this.LBL_PID.Name = "LBL_PID";
            this.LBL_PID.Size = new System.Drawing.Size(0, 13);
            this.LBL_PID.TabIndex = 17;
            this.LBL_PID.Visible = false;
            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.BackColor = System.Drawing.Color.Black;
            this.BTN_UPDATE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_UPDATE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_UPDATE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UPDATE.ForeColor = System.Drawing.Color.White;
            this.BTN_UPDATE.Location = new System.Drawing.Point(243, 639);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(115, 40);
            this.BTN_UPDATE.TabIndex = 12;
            this.BTN_UPDATE.Text = "Update";
            this.BTN_UPDATE.UseVisualStyleBackColor = false;
            this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // BTN_CANCEL
            // 
            this.BTN_CANCEL.BackColor = System.Drawing.Color.Black;
            this.BTN_CANCEL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_CANCEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_CANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BTN_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CANCEL.ForeColor = System.Drawing.Color.White;
            this.BTN_CANCEL.Location = new System.Drawing.Point(109, 639);
            this.BTN_CANCEL.Name = "BTN_CANCEL";
            this.BTN_CANCEL.Size = new System.Drawing.Size(115, 40);
            this.BTN_CANCEL.TabIndex = 13;
            this.BTN_CANCEL.Text = "Cancel";
            this.BTN_CANCEL.UseVisualStyleBackColor = false;
            this.BTN_CANCEL.Click += new System.EventHandler(this.BTN_CANCEL_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Enabled = false;
            this.txtBarcode.Location = new System.Drawing.Point(154, 159);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(250, 20);
            this.txtBarcode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Product Barcode";
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(154, 335);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(250, 21);
            this.cmbUnit.TabIndex = 7;
            // 
            // Unit
            // 
            this.Unit.AutoSize = true;
            this.Unit.Location = new System.Drawing.Point(91, 343);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(26, 13);
            this.Unit.TabIndex = 23;
            this.Unit.Text = "Unit";
            // 
            // txtMinimum
            // 
            this.txtMinimum.Location = new System.Drawing.Point(153, 385);
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.Size = new System.Drawing.Size(250, 20);
            this.txtMinimum.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Minimum Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Brand Name";
            // 
            // txtbrand
            // 
            this.txtbrand.Location = new System.Drawing.Point(154, 208);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(250, 20);
            this.txtbrand.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Purchase Price";
            // 
            // txtPurchase
            // 
            this.txtPurchase.Location = new System.Drawing.Point(154, 287);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Size = new System.Drawing.Size(250, 20);
            this.txtPurchase.TabIndex = 5;
            // 
            // WholeSale
            // 
            this.WholeSale.AutoSize = true;
            this.WholeSale.Location = new System.Drawing.Point(82, 607);
            this.WholeSale.Name = "WholeSale";
            this.WholeSale.Size = new System.Drawing.Size(87, 13);
            this.WholeSale.TabIndex = 39;
            this.WholeSale.Text = "Whole sale Price";
            // 
            // txtWholesale
            // 
            this.txtWholesale.Location = new System.Drawing.Point(170, 610);
            this.txtWholesale.Name = "txtWholesale";
            this.txtWholesale.Size = new System.Drawing.Size(250, 20);
            this.txtWholesale.TabIndex = 11;
            // 
            // txtlocations
            // 
            this.txtlocations.Location = new System.Drawing.Point(153, 408);
            this.txtlocations.Name = "txtlocations";
            this.txtlocations.Size = new System.Drawing.Size(250, 20);
            this.txtlocations.TabIndex = 10;
            // 
            // lbllocation
            // 
            this.lbllocation.AutoSize = true;
            this.lbllocation.Location = new System.Drawing.Point(61, 411);
            this.lbllocation.Name = "lbllocation";
            this.lbllocation.Size = new System.Drawing.Size(48, 13);
            this.lbllocation.TabIndex = 41;
            this.lbllocation.Text = "Location";
            // 
            // Panel_Min
            // 
            this.Panel_Min.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Min.Controls.Add(this.pictureBox2);
            this.Panel_Min.Location = new System.Drawing.Point(413, 6);
            this.Panel_Min.Name = "Panel_Min";
            this.Panel_Min.Size = new System.Drawing.Size(75, 37);
            this.Panel_Min.TabIndex = 43;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Csharp_Project.Properties.Resources.small_minimize;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 31);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Panel_Cancel
            // 
            this.Panel_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Cancel.Controls.Add(this.pictureBox1);
            this.Panel_Cancel.Location = new System.Drawing.Point(347, 6);
            this.Panel_Cancel.Name = "Panel_Cancel";
            this.Panel_Cancel.Size = new System.Drawing.Size(57, 37);
            this.Panel_Cancel.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Csharp_Project.Properties.Resources.small_close;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 31);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FORM_UPDATE_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Csharp_Project.Properties.Resources.Edit_Product;
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.Panel_Min);
            this.Controls.Add(this.Panel_Cancel);
            this.Controls.Add(this.lbllocation);
            this.Controls.Add(this.txtlocations);
            this.Controls.Add(this.WholeSale);
            this.Controls.Add(this.txtWholesale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPurchase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinimum);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.BTN_CANCEL);
            this.Controls.Add(this.BTN_UPDATE);
            this.Controls.Add(this.LBL_PID);
            this.Controls.Add(this.PB_BROWSE_IMAGE);
            this.Controls.Add(this.TB_PRICE);
            this.Controls.Add(this.TB_QUANTITY);
            this.Controls.Add(this.TB_DESCRIPTION);
            this.Controls.Add(this.TB_NAME);
            this.Controls.Add(this.COMBO_CATEGORIES);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_UPDATE_PRODUCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPDATE PRODUCT";
            ((System.ComponentModel.ISupportInitialize)(this.PB_BROWSE_IMAGE)).EndInit();
            this.Panel_Min.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Panel_Cancel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox PB_BROWSE_IMAGE;
        public System.Windows.Forms.TextBox TB_PRICE;
        public System.Windows.Forms.TextBox TB_QUANTITY;
        public System.Windows.Forms.TextBox TB_DESCRIPTION;
        public System.Windows.Forms.TextBox TB_NAME;
        public System.Windows.Forms.ComboBox COMBO_CATEGORIES;
        public System.Windows.Forms.Label LBL_PID;
        private System.Windows.Forms.Button BTN_UPDATE;
        private System.Windows.Forms.Button BTN_CANCEL;
        public System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label Unit;
        public System.Windows.Forms.TextBox txtMinimum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label WholeSale;
        public System.Windows.Forms.TextBox txtbrand;
        public System.Windows.Forms.TextBox txtPurchase;
        public System.Windows.Forms.TextBox txtWholesale;
        public System.Windows.Forms.TextBox txtlocations;
        private System.Windows.Forms.Label lbllocation;
        private System.Windows.Forms.Panel Panel_Min;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Panel_Cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}