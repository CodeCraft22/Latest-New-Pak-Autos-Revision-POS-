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
using System.Configuration;
//using Code4Bugs.SimpleDataGridViewPaging;


namespace Csharp_Project
{
    public partial class FORM_MANAGE_PRODUCT : Form
    {

        Product product = new Product();


        public FORM_MANAGE_PRODUCT()
        {
            InitializeComponent();

           // this.BindGrid(1);

            DGV_PRODUCTS.DataSource = product.GetLast10Products();
            //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();

            DGV_PRODUCTS.AllowUserToAddRows = false;
            DGV_PRODUCTS.RowTemplate.Height = 50;
         

        }

        //int PageSize = 5;


        //private void BindGrid(int pageIndex)
        //{
        //    string constring = "Data Source=.;Initial Catalog=MY_DB;Integrated Security=true";
        //    using (SqlConnection con = new SqlConnection(constring))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("spr_get_Products", con))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@PageIndex", pageIndex);
        //            cmd.Parameters.AddWithValue("@PageSize", PageSize);
        //            cmd.Parameters.Add("@RecordCount", SqlDbType.Int, 4);
        //            cmd.Parameters["@RecordCount"].Direction = ParameterDirection.Output;
        //            con.Open();
        //            DataTable dt = new DataTable();
        //            dt.Load(cmd.ExecuteReader());
        //            DGV_PRODUCTS.DataSource = dt;        
        //            con.Close();
        //            int recordCount = Convert.ToInt32(cmd.Parameters["@RecordCount"].Value);
        //            this.PopulatePager(recordCount, pageIndex);
        //        }
        //    }
        //}

      
       

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TB_SEARCH.Text) || string.IsNullOrWhiteSpace(TB_SEARCH.Text))
            {
                MessageBox.Show("Please provide information to Search");

            }

            else
            {
                
                string cs = "Data Source=.;Initial Catalog=MY_DB;Integrated Security=true";
                SqlConnection con;
                SqlDataAdapter adapt;
                DataTable dt;

                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select [PRO_ID] as ID,[PRO_NAME] as [NAME],[STOCK_QTE] as QUANTITY ,[PRICE] as PRICE,[DESCRIPTION],[CAT_NAME] as [CATEGORY],[PRODUCT_BARCODE] as BARCODE,[Quantity_unit] as [UNIT QTY],[Minimum_Quantity] as [MIN QTY],[Brand] as [BRAND],[WholeSale] as [WHOLE SALE PRICE],[purchase] as [PURCHASE],[location] as [LOCATION] from PRODUCT INNER JOIN CATEGORY ON CATEGORY.CAT_ID = PRODUCT.CAT_ID   where [PRODUCT_BARCODE] like '" + TB_SEARCH.Text + "%'", con);
                
                
           
                dt = new DataTable();
                adapt.Fill(dt);
                DGV_PRODUCTS.DataSource = dt;
                con.Close();
            }
        }


               
 
        private void BTN_NEW_PRODUCT_Click(object sender, EventArgs e)
        {

           
            FORM_NEW_PRODUCT fnp = new FORM_NEW_PRODUCT();
     
            fnp.Show();
           // DGV_PRODUCTS.DataSource = product.getProducts();

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
          

            if (string.IsNullOrEmpty(txtsearchbyName.Text) || string.IsNullOrWhiteSpace(txtsearchbyName.Text))
            {
                MessageBox.Show("Please provide information to Search");
            }
           
            else
            {

                string cs = "Data Source=.;Initial Catalog=MY_DB;Integrated Security=true";
                SqlConnection con;
                SqlDataAdapter adapt;
                DataTable dt;

                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select [PRO_ID] as ID,[PRO_NAME] as [NAME],[STOCK_QTE] as QUANTITY ,[PRICE] as PRICE,[DESCRIPTION],[CAT_NAME] as [CATEGORY],[PRODUCT_BARCODE] as BARCODE,[Quantity_unit] as [UNIT QTY],[Minimum_Quantity]as [MIN QTY],[Brand]as [BRAND],[WholeSale] as [WHOLE SALE PRICE],[purchase] as [PURCHASE],[location] as [LOCATION] from PRODUCT INNER JOIN CATEGORY ON CATEGORY.CAT_ID = PRODUCT.CAT_ID where [PRO_NAME] like '" + txtsearchbyName.Text + "%'", con);
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
                DGV_PRODUCTS.DataSource = product.GetLast10Products();
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
                DGV_PRODUCTS.DataSource = product.GetLast10Products();
            }
        }


        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
          //  DGV_PRODUCTS.DataSource = product.getProducts();
           // BindGrid(1);
            DGV_PRODUCTS.DataSource = product.GetLast10Products();
           
            DGV_PRODUCTS.AllowUserToAddRows = false;
            DGV_PRODUCTS.RowTemplate.Height = 50;
          
            txtsearchbyName.Text = "";
            TB_SEARCH.Text = "";
        }

      
       

        private void FORM_MANAGE_PRODUCT_Load(object sender, EventArgs e)
        {
          //  this.BindGrid(1);
        }

        private void DGV_PRODUCTS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarcodeForm bf = new BarcodeForm();
            bf.Show();
        }

        private void DGV_PRODUCTS_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        //private void PopulatePager(int recordCount, int currentPage)
        //{
        //    List<Page> pages = new List<Page>();
        //    int startIndex, endIndex;
        //    int pagerSpan = 5;

        //    //Calculate the Start and End Index of pages to be displayed.
        //    double dblPageCount = (double)((decimal)recordCount / Convert.ToDecimal(PageSize));
        //    int pageCount = (int)Math.Ceiling(dblPageCount);
        //    startIndex = currentPage > 1 && currentPage + pagerSpan - 1 < pagerSpan ? currentPage : 1;
        //    endIndex = pageCount > pagerSpan ? pagerSpan : pageCount;
        //    if (currentPage > pagerSpan % 2)
        //    {
        //        if (currentPage == 2)
        //        {
        //            endIndex = 5;
        //        }
        //        else
        //        {
        //            endIndex = currentPage + 2;
        //        }
        //    }
        //    else
        //    {
        //        endIndex = (pagerSpan - currentPage) + 1;
        //    }

        //    if (endIndex - (pagerSpan - 1) > startIndex)
        //    {
        //        startIndex = endIndex - (pagerSpan - 1);
        //    }

        //    if (endIndex > pageCount)
        //    {
        //        endIndex = pageCount;
        //        startIndex = ((endIndex - pagerSpan) + 1) > 0 ? (endIndex - pagerSpan) + 1 : 1;
        //    }

        //    //Add the First Page Button.
        //    if (currentPage > 1)
        //    {
        //        pages.Add(new Page { Text = "First", Value = "1" });
        //    }

        //    //Add the Previous Button.
        //    if (currentPage > 1)
        //    {
        //        pages.Add(new Page { Text = "<<", Value = (currentPage - 1).ToString() });
        //    }

        //    for (int i = startIndex; i <= endIndex; i++)
        //    {
        //        pages.Add(new Page { Text = i.ToString(), Value = i.ToString(), Selected = i == currentPage });
        //    }

        //    //Add the Next Button.
        //    if (currentPage < pageCount)
        //    {
        //        pages.Add(new Page { Text = ">>", Value = (currentPage + 1).ToString() });
        //    }

        //    //Add the Last Button.
        //    if (currentPage != pageCount)
        //    {
        //        pages.Add(new Page { Text = "Last", Value = pageCount.ToString() });
        //    }

        //    //Clear existing Pager Buttons.
        //    pnlPager.Controls.Clear();

        //    //Loop and add Buttons for Pager.
        //    int count = 0;
        //    foreach (Page page in pages)
        //    {
        //        Button btnPage = new Button();
        //        btnPage.Location = new System.Drawing.Point(38 * count, 5);
        //        btnPage.Size = new System.Drawing.Size(35, 20);
        //        btnPage.Name = page.Value;
        //        btnPage.Text = page.Text;
        //        btnPage.Enabled = !page.Selected;
        //        btnPage.Click += new System.EventHandler(this.Page_Click);
        //        pnlPager.Controls.Add(btnPage);
        //        count++;
        //    }
        //}

        //private void Page_Click(object sender, EventArgs e)
        //{
        //    Button btnPager = (sender as Button);
        //    this.BindGrid(int.Parse(btnPager.Name));
        //}

        //public class Page
        //{
        //    public string Text { get; set; }
        //    public string Value { get; set; }
        //    public bool Selected { get; set; }
        //}










    }
}
