using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Globalization;

namespace Csharp_Project
{
    public partial class FORM_UPDATE_PRODUCT : Form
    {
        Product product = new Product();
        Categorie catg = new Categorie();
        
        public FORM_UPDATE_PRODUCT()
        {
            InitializeComponent();
            
            COMBO_CATEGORIES.DataSource = catg.getCategories();
            COMBO_CATEGORIES.DisplayMember = "CAT_NAME";
            COMBO_CATEGORIES.ValueMember = "CAT_ID";

            loadComboCategoryUnit();
      
        }


        public void loadComboCategoryUnit()
        {
            cmbUnit.DisplayMember = "Text";
            cmbUnit.ValueMember = "Value";

            var items = new[] { 
             new { Text = "PER EACH", Value = "EACH" }, 
             new { Text = "DOZEN", Value = "DOZEN" }, 
             new { Text = "KG", Value = "KG" },
             new { Text = "SETS", Value = "SETS" },
             };

            cmbUnit.DataSource = items;
        }

       

        private void PB_BROWSE_IMAGE_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImagefileDialog = new OpenFileDialog();
            ImagefileDialog.Filter = "Image |*.JPG; *.PNG; *.GIF";
            if (ImagefileDialog.ShowDialog() == DialogResult.OK)
            {
                PB_BROWSE_IMAGE.Image = Image.FromFile(ImagefileDialog.FileName);
            }
        }

  
        private void TB_QUANTITY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TB_PRICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            char separator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != separator)
            {
                e.Handled = true;
            }
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
           

            if (TB_PRICE.Text == string.Empty && TB_QUANTITY.Text == string.Empty)
            {
                MessageBox.Show("Quantity and Price Can't Be Empty | But Can Be Equal To 0", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (PB_BROWSE_IMAGE.Image == null)
            {

                product.updateProductwithoutImage(Convert.ToInt32(LBL_PID.Text), Convert.ToInt32(COMBO_CATEGORIES.SelectedValue), TB_NAME.Text,
                                TB_PRICE.Text,  Convert.ToInt32(TB_QUANTITY.Text), TB_DESCRIPTION.Text, txtBarcode.Text, cmbUnit.Text, Convert.ToInt32(txtMinimum.Text), txtbrand.Text, txtWholesale.Text, txtPurchase.Text,txtlocations.Text);
                MessageBox.Show("Product Updated Successfully", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MemoryStream ms = new MemoryStream();
                PB_BROWSE_IMAGE.Image.Save(ms, PB_BROWSE_IMAGE.Image.RawFormat);
                byte[] image = ms.ToArray();
                product.updateProduct(Convert.ToInt32(LBL_PID.Text), Convert.ToInt32(COMBO_CATEGORIES.SelectedValue), TB_NAME.Text,
                                TB_PRICE.Text, image, Convert.ToInt32(TB_QUANTITY.Text), TB_DESCRIPTION.Text, txtBarcode.Text, cmbUnit.Text, Convert.ToInt32(txtMinimum.Text),txtbrand.Text,txtWholesale.Text,txtPurchase.Text,txtlocations.Text);
                MessageBox.Show("Product Updated Successfully", "Update Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void COMBO_CATEGORIES_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;
            FORM_MANAGE_PRODUCT FMP = new FORM_MANAGE_PRODUCT();
            FMP.WindowState = FormWindowState.Normal;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
