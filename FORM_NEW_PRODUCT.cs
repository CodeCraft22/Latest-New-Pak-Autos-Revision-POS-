﻿using System;
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
using System.Data.SqlClient;
namespace Csharp_Project
{
    public partial class FORM_NEW_PRODUCT : Form
    {

        Categorie catg = new Categorie();
        Product product = new Product();
        FORM_MANAGE_PRODUCT FMP = new FORM_MANAGE_PRODUCT();


        public FORM_NEW_PRODUCT()
        {
            InitializeComponent();
            loadComboCategory();
            loadComboCategoryUnit();



        }


        public void loadComboCategoryUnit()
        {

            cmbQuantity.DisplayMember = "Text";
            cmbQuantity.ValueMember = "Value";

            var items = new[] { 
             new { Text = "PER EACH", Value = "EACH" }, 
             new { Text = "DOZEN", Value = "DOZEN" }, 
             new { Text = "KG", Value = "KG" },
             new { Text = "SETS", Value = "SETS" },
             };

            cmbQuantity.DataSource = items;
        }

        public void loadComboCategory()
        {
            COMBO_CATEGORIES.DataSource = catg.getCategories();
            COMBO_CATEGORIES.DisplayMember = "CAT_NAME";
            COMBO_CATEGORIES.ValueMember = "CAT_ID";
            TB_QUANTITY.Text = "0";
            TB_PRICE.Text = "0";

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

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
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

        private void BTN_ADD_CATEGORY_Click(object sender, EventArgs e)
        {
            FORM_ADD_NEW_CATEGORIE faddc = new FORM_ADD_NEW_CATEGORIE();
            faddc.ShowDialog();
            loadComboCategory();
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are You sure you want to cancel", "Cancel Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);


            if (dialog == DialogResult.OK)
            {
                Close();

                //  FORM_MANAGE_PRODUCT_Load(null, null);

            }

        }


        private void BTN_ADD_Click(object sender, EventArgs e)
        {



          //  AutoGeneratedBarcode();


         //   below is Duplicate barcode check
            string cs = "Data Source=.;Initial Catalog=MY_DB;Integrated Security=true";
            SqlConnection con;
            SqlDataAdapter adapt;
            DataTable dt;

            con = new SqlConnection(cs);
            con.Open();
            // adapt = new SqlDataAdapter("select  COUNT(*) FROM [PRODUCT] where [PRODUCT_BARCODE] like '%" + txthexadecimalBarcode.Text + "%'", con);
            adapt = new SqlDataAdapter("select  COUNT(*) as barcode FROM [PRODUCT] where [PRODUCT_BARCODE] ='"  + txthexadecimalBarcode.Text + "'", con);

            dt = new DataTable();
            adapt.Fill(dt);

            string abc = dt.Rows[0]["barcode"].ToString();
            if (Convert.ToInt16(abc) > 0)
            {
                MessageBox.Show("barcode already exists", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {


            if (txthexadecimalBarcode.Text == string.Empty)
            {
                MessageBox.Show("Enter Product Barcode", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (TB_NAME.Text == string.Empty)
            {
                MessageBox.Show("Enter The Product Name", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //if (TB_PRICE.Text == string.Empty && TB_QUANTITY.Text == string.Empty)
            //{
            //    MessageBox.Show("Quantity and Price Can't Be Empty | But Can Be Equal To 0", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}



            if (TB_PRICE.Text == string.Empty)
            {
                MessageBox.Show("Price Can't Be Empty | But Can Be Equal To 0", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (PB_BROWSE_IMAGE.Image == null)
            {
                //MessageBox.Show("No Image Selected", "No Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                product.insertWithoutImageProduct(Convert.ToInt32(COMBO_CATEGORIES.SelectedValue), TB_NAME.Text,
                                    TB_PRICE.Text, Convert.ToInt32(TB_QUANTITY.Text), TB_DESCRIPTION.Text, txthexadecimalBarcode.Text, Convert.ToString(cmbQuantity.SelectedValue), Convert.ToInt32(txtMinimumQuantity.Text), txtbrand.Text, txtWholesale.Text, txtPurchase.Text, txtlocation.Text);
                MessageBox.Show("New Product Inserted Successfully", "New Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FORM_MANAGE_PRODUCT FMP = new FORM_MANAGE_PRODUCT();
                //                 FMP.FORM_MANAGE_PRODUCT_Load(null, null);
                FMP.btnRefresh.PerformClick();




            }


            else
            {
                MemoryStream ms = new MemoryStream();
                PB_BROWSE_IMAGE.Image.Save(ms, PB_BROWSE_IMAGE.Image.RawFormat);
                byte[] image = ms.ToArray();

                product.insertProduct(Convert.ToInt32(COMBO_CATEGORIES.SelectedValue), TB_NAME.Text,
                                     TB_PRICE.Text, image, Convert.ToInt32(TB_QUANTITY.Text), TB_DESCRIPTION.Text, txthexadecimalBarcode.Text, Convert.ToString(cmbQuantity.SelectedValue), Convert.ToInt32(txtMinimumQuantity.Text), txtbrand.Text, txtWholesale.Text, txtPurchase.Text, txtlocation.Text);
                MessageBox.Show("New Product Inserted Successfully", "New Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FORM_MANAGE_PRODUCT FMP = new FORM_MANAGE_PRODUCT();
                //  FMP.FORM_MANAGE_PRODUCT_Load(null, null);
                //FMP.Gridload();

                ////////////////////////////////////////////////////////////

            }
        }
    }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


            WindowState = FormWindowState.Minimized;
            FORM_MANAGE_PRODUCT FMP = new FORM_MANAGE_PRODUCT();
            FMP.WindowState = FormWindowState.Normal;

        }


        public void AutoGeneratedBarcode()
        {

            int barcode = 0;
            string cs = "Data Source=.;Initial Catalog=MY_DB;Integrated Security=true";
            // SqlConnection con;
            SqlDataAdapter adapt;
            DataTable dt;
            adapt = new SqlDataAdapter("select (max(PRODUCT_BARCODE)) + 1  as ProductBarcode  from PRODUCT", cs);
            dt = new DataTable();
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                if (row.IsNull("ProductBarcode"))
                {
                    barcode = 1;
                    txthexadecimalBarcode.Text = Convert.ToString(barcode);
                }
                else
                {
                    string output = dt.Rows[0]["ProductBarcode"].ToString();
                    txthexadecimalBarcode.Text = output;

                }

            }

            //private void PANEL_MIN_Click(object sender, EventArgs e)
            //{
            //    WindowState = FormWindowState.Minimized;
            //    FORM_MANAGE_PRODUCT FMP = new FORM_MANAGE_PRODUCT();
            //    FMP.WindowState = FormWindowState.Normal;
            //}

            //private void Panel_Min_Click_1(object sender, EventArgs e)
            //{
            //    WindowState = FormWindowState.Minimized;
            //    FORM_MANAGE_PRODUCT FMP = new FORM_MANAGE_PRODUCT();
            //    FMP.WindowState = FormWindowState.Normal;
            //}



        }


    }
}

