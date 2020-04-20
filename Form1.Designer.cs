namespace Csharp_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pdfviewerss = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.pdfviewerss)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfviewerss
            // 
            this.pdfviewerss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfviewerss.Enabled = true;
            this.pdfviewerss.Location = new System.Drawing.Point(4, 12);
            this.pdfviewerss.Name = "pdfviewerss";
            this.pdfviewerss.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfviewerss.OcxState")));
            this.pdfviewerss.Size = new System.Drawing.Size(573, 420);
            this.pdfviewerss.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 444);
            this.Controls.Add(this.pdfviewerss);
            this.Name = "Form1";
            this.Text = "VIEW INVOICES";
            ((System.ComponentModel.ISupportInitialize)(this.pdfviewerss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF pdfviewerss;
    }
}