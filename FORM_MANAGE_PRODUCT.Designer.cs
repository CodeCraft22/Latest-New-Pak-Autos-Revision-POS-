namespace Csharp_Project
{
    partial class FORM_MANAGE_PRODUCT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_MANAGE_PRODUCT));
            this.BTN_NEW_PRODUCT = new System.Windows.Forms.Button();
            this.BTN_DELETE_PRODUCT = new System.Windows.Forms.Button();
            this.BTN_PRODUCT_PRODUCT = new System.Windows.Forms.Button();
            this.TB_SEARCH = new System.Windows.Forms.TextBox();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.PANEL_CLOSE = new System.Windows.Forms.Panel();
            this.PANEL_MENI = new System.Windows.Forms.Panel();
            this.txtsearchbyName = new System.Windows.Forms.TextBox();
            this.btnsearhbyProduct = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DGV_PRODUCTS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_NEW_PRODUCT
            // 
            this.BTN_NEW_PRODUCT.BackColor = System.Drawing.Color.ForestGreen;
            this.BTN_NEW_PRODUCT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEW_PRODUCT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_NEW_PRODUCT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_NEW_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW_PRODUCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NEW_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.BTN_NEW_PRODUCT.Location = new System.Drawing.Point(12, 188);
            this.BTN_NEW_PRODUCT.Name = "BTN_NEW_PRODUCT";
            this.BTN_NEW_PRODUCT.Size = new System.Drawing.Size(118, 37);
            this.BTN_NEW_PRODUCT.TabIndex = 3;
            this.BTN_NEW_PRODUCT.Text = "New Product";
            this.BTN_NEW_PRODUCT.UseVisualStyleBackColor = false;
            this.BTN_NEW_PRODUCT.Click += new System.EventHandler(this.BTN_NEW_PRODUCT_Click);
            // 
            // BTN_DELETE_PRODUCT
            // 
            this.BTN_DELETE_PRODUCT.BackColor = System.Drawing.Color.ForestGreen;
            this.BTN_DELETE_PRODUCT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_DELETE_PRODUCT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_DELETE_PRODUCT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_DELETE_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE_PRODUCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETE_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.BTN_DELETE_PRODUCT.Location = new System.Drawing.Point(12, 242);
            this.BTN_DELETE_PRODUCT.Name = "BTN_DELETE_PRODUCT";
            this.BTN_DELETE_PRODUCT.Size = new System.Drawing.Size(118, 37);
            this.BTN_DELETE_PRODUCT.TabIndex = 4;
            this.BTN_DELETE_PRODUCT.Text = "Remove Product";
            this.BTN_DELETE_PRODUCT.UseVisualStyleBackColor = false;
            this.BTN_DELETE_PRODUCT.Click += new System.EventHandler(this.BTN_DELETE_PRODUCT_Click);
            // 
            // BTN_PRODUCT_PRODUCT
            // 
            this.BTN_PRODUCT_PRODUCT.BackColor = System.Drawing.Color.ForestGreen;
            this.BTN_PRODUCT_PRODUCT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_PRODUCT_PRODUCT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_PRODUCT_PRODUCT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_PRODUCT_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PRODUCT_PRODUCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PRODUCT_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.BTN_PRODUCT_PRODUCT.Location = new System.Drawing.Point(12, 302);
            this.BTN_PRODUCT_PRODUCT.Name = "BTN_PRODUCT_PRODUCT";
            this.BTN_PRODUCT_PRODUCT.Size = new System.Drawing.Size(118, 37);
            this.BTN_PRODUCT_PRODUCT.TabIndex = 5;
            this.BTN_PRODUCT_PRODUCT.Text = "Update Product";
            this.BTN_PRODUCT_PRODUCT.UseVisualStyleBackColor = false;
            this.BTN_PRODUCT_PRODUCT.Click += new System.EventHandler(this.BTN_PRODUCT_PRODUCT_Click);
            // 
            // TB_SEARCH
            // 
            this.TB_SEARCH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TB_SEARCH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TB_SEARCH.Location = new System.Drawing.Point(1018, 110);
            this.TB_SEARCH.Name = "TB_SEARCH";
            this.TB_SEARCH.Size = new System.Drawing.Size(148, 20);
            this.TB_SEARCH.TabIndex = 1;
            this.TB_SEARCH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_SEARCH_KeyDown);
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.BackColor = System.Drawing.Color.ForestGreen;
            this.BTN_SEARCH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_SEARCH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.BTN_SEARCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.BTN_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SEARCH.ForeColor = System.Drawing.Color.White;
            this.BTN_SEARCH.Location = new System.Drawing.Point(1172, 110);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(132, 23);
            this.BTN_SEARCH.TabIndex = 6;
            this.BTN_SEARCH.Text = "Search By Barcode";
            this.BTN_SEARCH.UseVisualStyleBackColor = false;
            this.BTN_SEARCH.Click += new System.EventHandler(this.BTN_SEARCH_Click);
            // 
            // PANEL_CLOSE
            // 
            this.PANEL_CLOSE.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_CLOSE.Location = new System.Drawing.Point(1274, 12);
            this.PANEL_CLOSE.Name = "PANEL_CLOSE";
            this.PANEL_CLOSE.Size = new System.Drawing.Size(45, 43);
            this.PANEL_CLOSE.TabIndex = 10;
            this.PANEL_CLOSE.Click += new System.EventHandler(this.PANEL_CLOSE_Click);
            // 
            // PANEL_MENI
            // 
            this.PANEL_MENI.BackColor = System.Drawing.Color.Transparent;
            this.PANEL_MENI.Location = new System.Drawing.Point(1229, 12);
            this.PANEL_MENI.Name = "PANEL_MENI";
            this.PANEL_MENI.Size = new System.Drawing.Size(40, 43);
            this.PANEL_MENI.TabIndex = 9;
            this.PANEL_MENI.Click += new System.EventHandler(this.PANEL_MENI_Click);
            // 
            // txtsearchbyName
            // 
            this.txtsearchbyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtsearchbyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtsearchbyName.Location = new System.Drawing.Point(1018, 78);
            this.txtsearchbyName.Name = "txtsearchbyName";
            this.txtsearchbyName.Size = new System.Drawing.Size(148, 20);
            this.txtsearchbyName.TabIndex = 0;
            this.txtsearchbyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearchbyName_KeyDown);
            // 
            // btnsearhbyProduct
            // 
            this.btnsearhbyProduct.BackColor = System.Drawing.Color.ForestGreen;
            this.btnsearhbyProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.btnsearhbyProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btnsearhbyProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.btnsearhbyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearhbyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearhbyProduct.ForeColor = System.Drawing.Color.White;
            this.btnsearhbyProduct.Location = new System.Drawing.Point(1172, 78);
            this.btnsearhbyProduct.Name = "btnsearhbyProduct";
            this.btnsearhbyProduct.Size = new System.Drawing.Size(132, 26);
            this.btnsearhbyProduct.TabIndex = 8;
            this.btnsearhbyProduct.Text = "Search By Name";
            this.btnsearhbyProduct.UseVisualStyleBackColor = false;
            this.btnsearhbyProduct.Click += new System.EventHandler(this.btnsearhbyProduct_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(12, 136);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 37);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(74)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(86)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Generate Barcode";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGV_PRODUCTS
            // 
            this.DGV_PRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCTS.Location = new System.Drawing.Point(136, 139);
            this.DGV_PRODUCTS.Name = "DGV_PRODUCTS";
            this.DGV_PRODUCTS.Size = new System.Drawing.Size(1229, 402);
            this.DGV_PRODUCTS.TabIndex = 12;
            this.DGV_PRODUCTS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PRODUCTS_CellContentClick_1);
            // 
            // FORM_MANAGE_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1344, 567);
            this.Controls.Add(this.DGV_PRODUCTS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnsearhbyProduct);
            this.Controls.Add(this.txtsearchbyName);
            this.Controls.Add(this.PANEL_MENI);
            this.Controls.Add(this.PANEL_CLOSE);
            this.Controls.Add(this.BTN_SEARCH);
            this.Controls.Add(this.TB_SEARCH);
            this.Controls.Add(this.BTN_PRODUCT_PRODUCT);
            this.Controls.Add(this.BTN_DELETE_PRODUCT);
            this.Controls.Add(this.BTN_NEW_PRODUCT);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FORM_MANAGE_PRODUCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANAGE PRODUCT";
            this.Load += new System.EventHandler(this.FORM_MANAGE_PRODUCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_NEW_PRODUCT;
        private System.Windows.Forms.Button BTN_DELETE_PRODUCT;
        private System.Windows.Forms.Button BTN_PRODUCT_PRODUCT;
        private System.Windows.Forms.Button BTN_SEARCH;
        private System.Windows.Forms.Panel PANEL_CLOSE;
        private System.Windows.Forms.Panel PANEL_MENI;
        private System.Windows.Forms.TextBox txtsearchbyName;
        private System.Windows.Forms.Button btnsearhbyProduct;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.TextBox TB_SEARCH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGV_PRODUCTS;
    }
}