using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Project
{
    public partial class FORM_HOME : Form
    {
        public string userType;
        public FORM_HOME(string value)
        {
            //FORM_LOGIN FL = new FORM_LOGIN();
           
           
            InitializeComponent();
            lblWelcome.Text = value;
            lblWelcome.Visible = true;
 
        }

        public void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_CATEGORIES fmcg = new FORM_MANAGE_CATEGORIES();
            fmcg.ShowDialog();
        }

        public void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_CUSTOMER fmcm = new FORM_MANAGE_CUSTOMER();
            fmcm.ShowDialog();
        }

        public void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_RECEIPT fmo = new FORM_MANAGE_RECEIPT();
            fmo.ShowDialog();
        }

        public void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_USER fmus = new FORM_MANAGE_USER();
            fmus.ShowDialog();
        }

        public void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_PRODUCT fmp = new FORM_MANAGE_PRODUCT();
           // fmp.ShowDialog();
            fmp.Show();
        }

        public void manageReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageReceipt MReceiptfmus = new ManageReceipt(lblWelcome.Text);
          //  MReceiptfmus.ShowDialog();
            MReceiptfmus.Show();
        }

     
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_SEARCH_PRODUCT FSP = new FORM_SEARCH_PRODUCT();
            FSP.Show();
        }

    }
}
