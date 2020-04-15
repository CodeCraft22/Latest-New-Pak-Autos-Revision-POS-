namespace Csharp_Project
{
    partial class BarcodeForm
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtShowAll = new System.Windows.Forms.Button();
            this.txtcopy = new System.Windows.Forms.TextBox();
            this.txtShow = new System.Windows.Forms.Button();
            this.lblCopy = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 44);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1247, 459);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // txtShowAll
            // 
            this.txtShowAll.Location = new System.Drawing.Point(1161, 13);
            this.txtShowAll.Name = "txtShowAll";
            this.txtShowAll.Size = new System.Drawing.Size(93, 22);
            this.txtShowAll.TabIndex = 1;
            this.txtShowAll.Text = "Show All";
            this.txtShowAll.UseVisualStyleBackColor = true;
            this.txtShowAll.Click += new System.EventHandler(this.txtShowAll_Click);
            // 
            // txtcopy
            // 
            this.txtcopy.Location = new System.Drawing.Point(929, 15);
            this.txtcopy.Name = "txtcopy";
            this.txtcopy.Size = new System.Drawing.Size(117, 20);
            this.txtcopy.TabIndex = 2;
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(1062, 13);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(93, 23);
            this.txtShow.TabIndex = 3;
            this.txtShow.Text = "Show";
            this.txtShow.UseVisualStyleBackColor = true;
            this.txtShow.Click += new System.EventHandler(this.txtShow_Click);
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Location = new System.Drawing.Point(859, 18);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(70, 13);
            this.lblCopy.TabIndex = 4;
            this.lblCopy.Text = "No Of Copies";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(97, 18);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(117, 20);
            this.txtProductCode.TabIndex = 5;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(22, 21);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(69, 13);
            this.lblProductCode.TabIndex = 6;
            this.lblProductCode.Text = "ProductCode";
            // 
            // BarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 500);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.txtcopy);
            this.Controls.Add(this.txtShowAll);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "BarcodeForm";
            this.Text = "BarcodeForm";
            this.Load += new System.EventHandler(this.BarcodeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button txtShowAll;
        private System.Windows.Forms.TextBox txtcopy;
        private System.Windows.Forms.Button txtShow;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductCode;
    }
}