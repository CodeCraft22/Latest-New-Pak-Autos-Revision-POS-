using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.SqlClient;


namespace Csharp_Project
{
    public partial class FORM_MANAGE_PRODUCT : Form
    {

        Product product = new Product();


        public FORM_MANAGE_PRODUCT()
        {
            InitializeComponent();


            DGV_PRODUCTS.DataSource = product.getProducts();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //imageColumn = (DataGridViewImageColumn)DGV_PRODUCTS.Columns[4];
            //imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DGV_PRODUCTS.AllowUserToAddRows = false;
            DGV_PRODUCTS.RowTemplate.Height = 50;
            //  autocomplete(TB_SEARCH);


        }




        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(TB_SEARCH.Text) || string.IsNullOrWhiteSpace(TB_SEARCH.Text))
            {
                MessageBox.Show("Please provide information to Search");

            }


            //if (TB_SEARCH.Text == string.Empty)
            //{
            //    MessageBox.Show("Please provide information to Search");
            //}
            else
            {
                // string SearchByBarcode = TB_SEARCH.Text;
                // DGV_PRODUCTS.DataSource = product.SearchbyProductsBarcode(SearchByBarcode);
                //Connection String  
                // connection = new SqlConnection(@"Server= DESKTOP-BQAOM0A; Database = MY_DB; Integrated Security = true");
                string cs = "Data Source=.;Initial Catalog=MY_DB;Integrated Security=true";
                SqlConnection con;
                SqlDataAdapter adapt;
                DataTable dt;

                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select [PRO_ID],[PRO_NAME],[STOCK_QTE],[PRICE],[DESCRIPTION],[CAT_NAME],[PRODUCT_BARCODE],[Quantity_unit],[Minimum_Quantity],[Brand],[WholeSale],[purchase],[location] from [PRODUCT] INNER JOIN CATEGORY ON CATEGORY.CAT_ID = PRODUCT.CAT_ID where [PRODUCT_BARCODE] like '" + TB_SEARCH.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                DGV_PRODUCTS.DataSource = dt;
                con.Close();
            }
        }


               
 
        private void BTN_NEW_PRODUCT_Click(object sender, EventArgs e)
        {

           
            FORM_NEW_PRODUCT fnp = new FORM_NEW_PRODUCT();
            //fnp.ShowDialog();
            fnp.Show();
            DGV_PRODUCTS.DataSource = product.getProducts();


        }


        private void BTN_DELETE_PRODUCT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you really want to delete this product", "Remove Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                product.deleteProducts(Convert.ToInt32(DGV_PRODUCTS.CurrentRow.Cells[0].Value));
                DGV_PRODUCTS.DataSource = product.getProducts();
                MessageBox.Show("Product Deleted Successfully", "Remove Product");
            }
        }

        private void BTN_PRODUCT_PRODUCT_Click(object sender, EventArgs e)
        {
           


            FORM_UPDATE_PRODUCT fup = new FORM_UPDATE_PRODUCT();
            fup.LBL_PID.Text = DGV_PRODUCTS.CurrentRow.Cells[0].Value.ToString();
            fup.TB_NAME.Text = DGV_PRODUCTS.CurrentRow.Cells[1].Value.ToString();
            fup.TB_QUANTITY.Text = DGV_PRODUCTS.CurrentRow.Cells[2].Value.ToString();
            fup.TB_PRICE.Text = DGV_PRODUCTS.CurrentRow.Cells[3].Value.ToString();
            fup.TB_DESCRIPTION.Text = DGV_PRODUCTS.CurrentRow.Cells[4].Value.ToString();
            fup.COMBO_CATEGORIES.Text = DGV_PRODUCTS.CurrentRow.Cells[5].Value.ToString();
            fup.txtBarcode.Text = DGV_PRODUCTS.CurrentRow.Cells[6].Value.ToString();
            fup.cmbUnit.Text = DGV_PRODUCTS.CurrentRow.Cells[7].Value.ToString();
            fup.txtMinimum.Text = DGV_PRODUCTS.CurrentRow.Cells[8].Value.ToString();
            fup.txtbrand.Text = DGV_PRODUCTS.CurrentRow.Cells[9].Value.ToString();
            fup.txtWholesale.Text = DGV_PRODUCTS.CurrentRow.Cells[10].Value.ToString();
            fup.txtPurchase.Text = DGV_PRODUCTS.CurrentRow.Cells[11].Value.ToString();
            fup.txtlocations.Text = DGV_PRODUCTS.CurrentRow.Cells[12].Value.ToString();






            if (fup.PB_BROWSE_IMAGE.Image == null)
            {
                fup.Show();
                //fup.ShowDialog();
                //this is used to avoid exception
            }
            else
            {
                byte[] img = (byte[])DGV_PRODUCTS.CurrentRow.Cells[4].Value;
                MemoryStream ms = new MemoryStream(img);
                fup.PB_BROWSE_IMAGE.Image = Image.FromStream(ms);
                // fup.ShowDialog();
                fup.Show();
                DGV_PRODUCTS.DataSource = product.getProducts();

            }
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PANEL_MENI_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       

        private void btnsearhbyProduct_Click(object sender, EventArgs e)
        {
            // string SearchByBarcode = TB_SEARCH.Text;
            // DGV_PRODUCTS.DataSource = product.SearchbyProductsBarcode(SearchByBarcode);
            //Connection String  
            // connection = new SqlConnection(@"Server= DESKTOP-BQAOM0A; Database = MY_DB; Integrated Security = true");

            if (string.IsNullOrEmpty(txtsearchbyName.Text) || string.IsNullOrWhiteSpace(txtsearchbyName.Text))
            {
                MessageBox.Show("Please provide information to Search");
            }
            //if (txtsearchbyName.Text == string.Empty)
            //{
            //    MessageBox.Show("Please provide information to Search");
            //}
            else
            {

                string cs = "Data Source=.;Initial Catalog=MY_DB;Integrated Security=true";
                SqlConnection con;
                SqlDataAdapter adapt;
                DataTable dt;

                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select [PRO_ID],[PRO_NAME],[STOCK_QTE],[PRICE],[DESCRIPTION],[CAT_NAME],[PRODUCT_BARCODE],[Quantity_unit],[Minimum_Quantity],[Brand],[WholeSale],[purchase],[location] from[PRODUCT] INNER JOIN CATEGORY ON CATEGORY.CAT_ID = PRODUCT.CAT_ID where [PRO_NAME] like '" + txtsearchbyName.Text + "%'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                DGV_PRODUCTS.DataSource = dt;
                con.Close();
            }
        }


     



        private void txtsearchbyName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                 btnsearhbyProduct_Click(sender,  e);
            }


            if (e.KeyCode == Keys.Back)
            {
                ReadRecord();
            }

          
        }

        private void TB_SEARCH_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                BTN_SEARCH_Click(sender, e);
               
            }

            if(e.KeyCode == Keys.Back)
            {
                ReadRecord();
            }
        }


        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DGV_PRODUCTS.DataSource = product.getProducts();
            //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //imageColumn = (DataGridViewImageColumn)DGV_PRODUCTS.Columns[4];
            //imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DGV_PRODUCTS.AllowUserToAddRows = false;
            DGV_PRODUCTS.RowTemplate.Height = 50;
            //autocomplete(TB_SEARCH);
        }

      
        public void ReadRecord()
        {
            DGV_PRODUCTS.DataSource = product.getProducts();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //imageColumn = (DataGridViewImageColumn)DGV_PRODUCTS.Columns[4];
            //imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DGV_PRODUCTS.AllowUserToAddRows = false;
            DGV_PRODUCTS.RowTemplate.Height = 50;
        }

        private void FORM_MANAGE_PRODUCT_Load(object sender, EventArgs e)
        {

        }

        private void DGV_PRODUCTS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
