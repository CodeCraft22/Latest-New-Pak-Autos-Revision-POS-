namespace Csharp_Project
{
    partial class FORM_SEARCH_PRODUCT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_search = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.cmbBarcode = new System.Windows.Forms.ComboBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_search)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_search
            // 
            this.dg_search.AllowUserToResizeColumns = false;
            this.dg_search.AllowUserToResizeRows = false;
            this.dg_search.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg_search.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_search.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_search.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_search.Location = new System.Drawing.Point(8, 59);
            this.dg_search.Name = "dg_search";
            this.dg_search.Size = new System.Drawing.Size(1307, 495);
            this.dg_search.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(447, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 54;
            this.label8.Text = "Barcode";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchName.Location = new System.Drawing.Point(9, 32);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(116, 18);
            this.lblSearchName.TabIndex = 53;
            this.lblSearchName.Text = "Product Name";
            // 
            // cmbBarcode
            // 
            this.cmbBarcode.FormattingEnabled = true;
            this.cmbBarcode.Location = new System.Drawing.Point(524, 32);
            this.cmbBarcode.Name = "cmbBarcode";
            this.cmbBarcode.Size = new System.Drawing.Size(240, 21);
            this.cmbBarcode.TabIndex = 52;
            this.cmbBarcode.SelectedIndexChanged += new System.EventHandler(this.cmbBarcode_SelectedIndexChanged);
            this.cmbBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBarcode_KeyDown);
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(131, 32);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(255, 21);
            this.cmbName.TabIndex = 51;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            this.cmbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbName_KeyDown);
            // 
            // FORM_SEARCH_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 566);
            this.Controls.Add(this.dg_search);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.cmbBarcode);
            this.Controls.Add(this.cmbName);
            this.Name = "FORM_SEARCH_PRODUCT";
            this.Text = "FORM_SEARCH_PRODUCT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dg_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.ComboBox cmbBarcode;
        private System.Windows.Forms.ComboBox cmbName;
    }
}