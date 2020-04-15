using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Csharp_Project
{
    public partial class FORM_SEARCH_PRODUCT : Form
    {
        public FORM_SEARCH_PRODUCT()
        {
            InitializeComponent();

            SqlConnection cs = new SqlConnection("Data Source=.; Initial Catalog=MY_DB; Integrated Security=TRUE");
            SqlDataAdapter da = new SqlDataAdapter("SELECT [PRO_NAME],[PRODUCT_BARCODE] FROM [PRODUCT] INNER JOIN CATEGORY ON CATEGORY.CAT_ID = PRODUCT.CAT_ID", cs);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbName.AutoCompleteSource = AutoCompleteSource.ListItems;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbName.Items.Add(dt.Rows[i]["PRO_NAME"]);

            }

            da.Fill(dt);
            cmbBarcode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBarcode.AutoCompleteSource = AutoCompleteSource.ListItems;



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbBarcode.Items.Add(dt.Rows[i]["PRODUCT_BARCODE"]);
            }
        }


   

        private void cmbName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (cmbName.SelectedIndex > -1)
                {

                    string cs = "Data Source=.;Initial Catalog=MY_DB;Integrated Security=true";
                    SqlConnection con;
                    SqlDataAdapter adapt;
                    DataTable dt;

                    con = new SqlConnection(cs);
                    con.Open();
                    adapt = new SqlDataAdapter("select [PRO_ID] as ID,[PRO_NAME] as [NAME],[STOCK_QTE] as QUANTITY ,[PRICE] as PRICE,[DESCRIPTION],[CAT_NAME] as [CATEGORY],[PRODUCT_BARCODE] as BARCODE,[Quantity_unit] as [UNIT QTY],[Minimum_Quantity]as [MIN QTY],[Brand]as [BRAND],[WholeSale] as [WHOLE SALE PRICE],[purchase] as [PURCHASE],[location] as [LOCATION] from PRODUCT INNER JOIN CATEGORY ON CATEGORY.CAT_ID = PRODUCT.CAT_ID where [PRO_NAME] = '" + cmbName.SelectedItem + "'", con);
                    dt = new DataTable();
                    adapt.Fill(dt);
                    dg_search.DataSource = dt;
                    con.Close();

                }




            }

            if (e.KeyCode == Keys.Back)
            {
                dg_search.DataSource = "";

            }



        }

        private void cmbBarcode_KeyDown(object sender, KeyEventArgs e)
        {

            if (cmbBarcode.SelectedIndex > -1)
            {

                string cs = "Data Source=.;Initial Catalog=MY_DB;Integrated Security=true";
                SqlConnection con;
                SqlDataAdapter adapt;
                DataTable dt;

                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select [PRO_ID] as ID,[PRO_NAME] as [NAME],[STOCK_QTE] as QUANTITY ,[PRICE] as PRICE,[DESCRIPTION],[CAT_NAME] as [CATEGORY],[PRODUCT_BARCODE] as BARCODE,[Quantity_unit] as [UNIT QTY],[Minimum_Quantity] as [MIN QTY],[Brand] as [BRAND],[WholeSale] as [WHOLE SALE PRICE],[purchase] as [PURCHASE],[location] as [LOCATION] from PRODUCT INNER JOIN CATEGORY ON CATEGORY.CAT_ID = PRODUCT.CAT_ID   where [PRODUCT_BARCODE] = '" + cmbBarcode.SelectedItem + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dg_search.DataSource = dt;
                con.Close();

            }


            if (e.KeyCode == Keys.Back)
            {
                dg_search.DataSource = "";

            }


        }


        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
                if (cmbName.SelectedIndex > -1)
                {

                    string cs = "Data Source=.;Initial Catalog=MY_DB;Integrated Security=true";
                    SqlConnection con;
                    SqlDataAdapter adapt;
                    DataTable dt;

                    con = new SqlConnection(cs);
                    con.Open();
                    adapt = new SqlDataAdapter("select [PRO_ID] as ID,[PRO_NAME] as [NAME],[STOCK_QTE] as QUANTITY ,[PRICE] as PRICE,[DESCRIPTION],[CAT_NAME] as [CATEGORY],[PRODUCT_BARCODE] as BARCODE,[Quantity_unit] as [UNIT QTY],[Minimum_Quantity]as [MIN QTY],[Brand]as [BRAND],[WholeSale] as [WHOLE SALE PRICE],[purchase] as [PURCHASE],[location] as [LOCATION] from PRODUCT INNER JOIN CATEGORY ON CATEGORY.CAT_ID = PRODUCT.CAT_ID where [PRO_NAME] = '" + cmbName.SelectedItem + "'", con);
                    dt = new DataTable();
                    adapt.Fill(dt);
                    dg_search.DataSource = dt;
                    con.Close();

                }

           //}
        }



        private void cmbBarcode_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbBarcode.SelectedIndex > -1)
            {

                string cs = "Data Source=.;Initial Catalog=MY_DB;Integrated Security=true";
                SqlConnection con;
                SqlDataAdapter adapt;
                DataTable dt;

                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select [PRO_ID] as ID,[PRO_NAME] as [NAME],[STOCK_QTE] as QUANTITY ,[PRICE] as PRICE,[DESCRIPTION],[CAT_NAME] as [CATEGORY],[PRODUCT_BARCODE] as BARCODE,[Quantity_unit] as [UNIT QTY],[Minimum_Quantity] as [MIN QTY],[Brand] as [BRAND],[WholeSale] as [WHOLE SALE PRICE],[purchase] as [PURCHASE],[location] as [LOCATION] from PRODUCT INNER JOIN CATEGORY ON CATEGORY.CAT_ID = PRODUCT.CAT_ID   where [PRODUCT_BARCODE] = '" + cmbBarcode.SelectedItem + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dg_search.DataSource = dt;
                con.Close();

            }


        }


    }
}
