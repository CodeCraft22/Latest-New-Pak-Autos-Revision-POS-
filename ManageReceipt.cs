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
    public partial class ManageReceipt : Form
    {
        int order = 1;
        double total = 0;
        double UnitPrice = 0;
        string WholeSale;
        string loginUser;

        DataTable mytable = new DataTable();
      
        public ManageReceipt(string user)
        {
            InitializeComponent();
            lbluser.Text = user;

            
        }

        private void ManageReceipt_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lbldate.Text = DateTime.Now.ToLongDateString();
                
            receiptBindingSource.DataSource = new List<Receipt>();
            txtTotal.Text = string.Format("{0}.00", total);
            txtunit.Enabled = false;
            checkBox1.Checked = false;
            txtTotal.Visible = true;
            txtBrand.Enabled = false;
            ddlCalulationMode.SelectedIndex = 0;

            dgvReceipt.Columns[3].ReadOnly = false;


            


            ///////////////////////////////////////////////////added by ali abdullah
            ///
         
          
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
            
            ////////////////////////////////

        }



        private void BTN_INSERT_ORDER_Click(object sender, EventArgs e)
        {

            //int InvoiceNo = 01;
            //string output;
            //SqlConnection cs = new SqlConnection("Data Source=.; Initial Catalog=MY_DB; Integrated Security=TRUE");
            //cs.Open();
            //SqlCommand cmd = new SqlCommand("select max(productBillNo) + 1 from Receiptss", cs);
            //SqlDataReader dr = cmd.ExecuteReader();

            //if (dr.HasRows)
            //{
                
            //        while (dr.Read())
            //        {
            //            // output = dr[03].ToString();
            //            output = dr["productBillNo"].ToString();
            //            InvoiceNo = Convert.ToInt32(output);
            //       }

            //}


            /////////////////////////////////////////////
           int  InvoiceNo = 0;
            string css = "Data Source=.;Initial Catalog=MY_DB;Integrated Security=true";
            SqlConnection con;
            SqlDataAdapter adapt;
            DataTable dt;
            con = new SqlConnection(css);
            con.Open();
          ///  adapt = new SqlDataAdapter("select max(productBillNo) + 1 as productBillNo from Receiptss", con);
          ///  
            adapt = new SqlDataAdapter("select (max(productBillNo)) + 1  as productBillNo from Receiptss", con);
            dt = new DataTable();
            adapt.Fill(dt);

            foreach(DataRow row in dt.Rows)
            {
                if(row.IsNull("productBillNo"))
                {
                    InvoiceNo = 1000;
                }
                else
                {
                  string output = dt.Rows[0]["productBillNo"].ToString();
                  InvoiceNo = Convert.ToInt32(output);

                }

            }
            
  ///////////////////////////////////////////////////
            if (string.IsNullOrEmpty(txtCash.Text))
            {
                MessageBox.Show("Please Enter Cash to proceed with customer RECEIPT");
            }

            else
            {
                     int _bit = 1;
               // string Invoice_No = System.String.Format ( "E{0:000000}" , 42 ) ;
                     using (frmPrint frm = new frmPrint(receiptBindingSource.DataSource as List<Receipt>, string.Format("{0}", total), string.Format("{0}", txtCash.Text), string.Format("{0:0}", Convert.ToDouble(txtCash.Text) - total), DateTime.Now.ToString("MM/dd/yyyy"), DateTime.Now.ToString("HH:mm:ss tt"), lbluser.Text, InvoiceNo, _bit))
                {
                    frm.ShowDialog(this);

                    // for resetting fields after receipt
                    txtBarcode.Text = "";
                    txtProductName.Text = "";
                    txtunit.Text = "";
                    txtBrand.Text = "";
                    txtPrice.Text = "";
                    txtQuantity.Text = "";
                    txtCash.Text = "";
                    txtChange.Text = "";
                    lblTime.Text = DateTime.Now.ToLongTimeString();
                    lbldate.Text = DateTime.Now.ToLongDateString();
                    txtTotal.Text = "";

                    receiptBindingSource.DataSource = new List<Receipt>();
                    //  txtTotal.Text = string.Format("{0}.00", total);
                    txtunit.Enabled = false;
                    checkBox1.Checked = false;
                    txtTotal.Visible = true;
                    txtBrand.Enabled = false;
                    ddlCalulationMode.SelectedIndex = 0;

                    // for resetting fields after receipt

                };
 
               
             }


            }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

         

            if (ddlCalulationMode.SelectedItem == null)
            {

                MessageBox.Show("Please Select Calcuation Mode First");
            }

            else
            {

                int ActualQuantity = 0;
                int MinimumQuantity = 0;

                lblMinimumStock.Text = "";
                if (txtBarcode.Text != string.Empty)
                {
                    txtPrice.Enabled = false;
                    txtProductName.Enabled = false;
                    txtDescription.Enabled = false;
                    txtunit.Enabled = false;
                    txtmin.Visible = false;
                    txtBrand.Enabled = false;

                    dgvReceipt.Refresh();
                    ManageReceipt MR = new ManageReceipt(lbluser.Text);
                    // dgvReceipt.DataSource = searchProductss(Convert.ToInt32(txtBarcode.Text));

                    DataTable ManageReceipt = new DataTable();
                    ManageReceipt = searchProductss(Convert.ToString(txtBarcode.Text));
                    foreach (DataRow row in ManageReceipt.Rows)
                    {
                        txtProductName.Text = "";
                        txtPrice.Text = "";
                        txtQuantity.Text = "";


                        txtProductName.Text = row["PRO_Name"].ToString();



                        if (ddlCalulationMode.SelectedItem.Equals("RETAIL"))
                        {

                            txtPrice.Text = row["PRICE"].ToString();
                        }
                        else
                        {
                            txtPrice.Text = row["WholeSale"].ToString(); ;

                        }


                        txtQuantity.Text = "";
                     //  txtQuantity.Text = row["STOCK_QTE"].ToString(); added by ali abdullah
                        txtDescription.Text = row["DESCRIPTION"].ToString();
                        txtunit.Text = row["Quantity_unit"].ToString();
                        txtmin.Text = row["Minimum_Quantity"].ToString();
                        lblMinimumStock.Text = row["STOCK_QTE"].ToString();
                        lblMinimumStock.Text = string.Format("{0} Remaining Quantity Is available ", lblMinimumStock.Text);
                     //  txtWholeSale = row["WholeSale"].ToString();
                        txtBrand.Text = row["Brand"].ToString();
                        string results = row["STOCK_QTE"].ToString();
                        MinimumQuantity = Convert.ToInt32(txtmin.Text);

                        ///

                        ActualQuantity = Convert.ToInt32(results);

                        ///
              
                        //ActualQuantity = Convert.ToInt32(txtQuantity.Text); commented by ali abdullah
                     
                        if (ActualQuantity <= MinimumQuantity)
                        {
                            MessageBox.Show("Quantity Stock is ON Minimum Level please Proceed With Order", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }

                }

                else
                {
                    txtBarcode.Text = "";
                    txtProductName.Text = "";
                    txtPrice.Text = "";
                    txtQuantity.Text = "";
                    txtDescription.Text = "";
                    txtPrice.Enabled = false;
                    txtProductName.Enabled = false;
                    txtDescription.Enabled = false;
                    txtBrand.Text = "";

                }
            }
        }
        public DataTable searchProductss(string valueToSearch)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@val", SqlDbType.VarChar, 100);
            parameters[0].Value = valueToSearch;
            table = db.getData("spr_search_Products_custom", parameters);
            db.closeConnection();
            return table;
        }

       

        private void btnadd_Click(object sender, EventArgs e)
        {

            
                if (txtTotal.Text != string.Empty)
                {
                    Receipt obj = new Receipt() { BARCODE_ID = txtBarcode.Text, PRODUCT_NAME = txtProductName.Text, UNIT_PRICE = Convert.ToDouble(txtPrice.Text), QTY = Convert.ToInt32(txtQuantity.Text), TOTAL = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtQuantity.Text) };

                    UnitPrice = obj.UNIT_PRICE * obj.QTY;
                    total += obj.UNIT_PRICE * obj.QTY;
                    receiptBindingSource.Add(obj);
                    receiptBindingSource.MoveLast();
                    // txtprice.Text = string.Empty;
                    txtTotal.Text = string.Format("{0}.00", total);

                }
            }
           

        


        private void btnRemove_Click(object sender, EventArgs e)
        {
            Receipt obj = receiptBindingSource.Current as Receipt;
            if (obj != null)
            {
           
                {
                    total -= obj.UNIT_PRICE * obj.QTY;
                    txtTotal.Text = string.Format("{0}", total);
                    receiptBindingSource.RemoveCurrent();
                }

               
            }
                  
    
        }



        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            int price;
            int quantity;
      

            if (System.Text.RegularExpressions.Regex.IsMatch(txtQuantity.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter Quantity in numbers Only.");
                txtQuantity.Text = txtQuantity.Text.Remove(txtQuantity.Text.Length - 1);
            }


            else
            {
                if (txtPrice.Text != string.Empty && txtPrice.Text != null)
                {

                            if (txtQuantity.Text != string.Empty && txtQuantity.Text != null)
                            {
                                price = Convert.ToInt32(txtPrice.Text);
                                quantity = Convert.ToInt32(txtQuantity.Text);
                                txtTotal.Text = Convert.ToString(price * quantity);

                            }
                            else
                            {
                                txtQuantity.Text = string.Empty;

                            }
                        }
                    
                   


                        }

                    }
                
         
           
        private void txtCash_TextChanged(object sender, EventArgs e)
        {

            if (txtCash.Text != string.Empty)
            {
                double cash; double subtotal;
                cash = Convert.ToDouble(txtCash.Text);
                subtotal = Convert.ToDouble(txtTotal.Text);

                txtChange.Text = Convert.ToString(cash - subtotal);
                txtChange.Text = string.Format("{0}", txtChange.Text);

            }
            else
            {
                txtCash.Text = "";
                txtChange.Text = "";
            }
        }

        private void PANEL_MIN_Click(object sender, EventArgs e)
        {
          WindowState = FormWindowState.Minimized;
         // FORM_HOME frm = new FORM_HOME();
        //  frm.WindowState = FormWindowState.Normal;
        }


        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtTotal.Visible = true;

            }
            else
            {
                txtTotal.Visible = false;

            }
        }

        private void ddlCalulationMode_SelectedIndexChanged(object sender, EventArgs e)
        {



           int ActualQuantity = 0;
                int MinimumQuantity = 0;

                lblMinimumStock.Text = "";
                 if(!string.IsNullOrEmpty(txtBarcode.Text))
                    {
                    txtPrice.Enabled = false;
                    txtProductName.Enabled = false;
                    txtDescription.Enabled = false;
                    txtunit.Enabled = false;
                    txtmin.Visible = false;
                    txtBrand.Enabled = false;

                    dgvReceipt.Refresh();
                    ManageReceipt MR = new ManageReceipt(lbluser.Text);
                    // dgvReceipt.DataSource = searchProductss(Convert.ToInt32(txtBarcode.Text));


                  
                    DataTable ManageReceipt = new DataTable();
                    ManageReceipt = searchProductss(Convert.ToString(txtBarcode.Text));
                    foreach (DataRow row in ManageReceipt.Rows)
                    {
                        txtProductName.Text = "";
                        txtPrice.Text = "";
                        txtQuantity.Text = "";


                        txtProductName.Text = row["PRO_Name"].ToString();



                        if (ddlCalulationMode.SelectedItem.Equals("RETAIL"))
                        {

                            txtPrice.Text = row["PRICE"].ToString();
                        }
                        else
                        {
                            txtPrice.Text = row["WholeSale"].ToString(); ;

                        }

                       
                       txtQuantity.Text = row["STOCK_QTE"].ToString();
                        txtDescription.Text = row["DESCRIPTION"].ToString();
                        txtunit.Text = row["Quantity_unit"].ToString();
                        txtmin.Text = row["Minimum_Quantity"].ToString();
                        lblMinimumStock.Text = row["STOCK_QTE"].ToString();
                        lblMinimumStock.Text = string.Format("{0} Remaining Quantity Is available ", lblMinimumStock.Text);
                     //  txtWholeSale = row["WholeSale"].ToString();
                        txtBrand.Text = row["Brand"].ToString();

                        ActualQuantity = Convert.ToInt32(txtQuantity.Text);
                        MinimumQuantity = Convert.ToInt32(txtmin.Text);

                        if (ActualQuantity <= MinimumQuantity)
                        {
                            MessageBox.Show("Quantity Stock is ON Minimum Level please Proceed With Order", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }



                    }

                }

                else
                {
                    txtBarcode.Text = "";
                    txtProductName.Text = "";
                    txtPrice.Text = "";
                    txtQuantity.Text = "";
                    txtDescription.Text = "";
                    txtPrice.Enabled = false;
                    txtProductName.Enabled = false;
                    txtDescription.Enabled = false;
                    txtBrand.Text = "";

                }
            }

        private void cmbName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (cmbName.SelectedIndex > -1)
                {

                    string cs = "Data Source=.;Initial Catalog=MY_DB;Integrated Security=true";
                    SqlConnection con;
                    SqlDataAdapter adapt;
                    DataTable dt;

                    con = new SqlConnection(cs);
                    con.Open();
                    adapt = new SqlDataAdapter("select [PRO_ID],[PRO_NAME],[STOCK_QTE],[PRICE],[DESCRIPTION],[CAT_NAME],[PRODUCT_BARCODE],[Quantity_unit],[Minimum_Quantity],[Brand],[WholeSale],[purchase],[location] from [PRODUCT] INNER JOIN CATEGORY ON CATEGORY.CAT_ID = PRODUCT.CAT_ID where [PRO_NAME] = '" + cmbName.SelectedItem + "'", con);
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
                adapt = new SqlDataAdapter("select [PRO_ID],[PRO_NAME],[STOCK_QTE],[PRICE],[DESCRIPTION],[CAT_NAME],[PRODUCT_BARCODE],[Quantity_unit],[Minimum_Quantity],[Brand],[WholeSale],[purchase],[location] from [PRODUCT] INNER JOIN CATEGORY ON CATEGORY.CAT_ID = PRODUCT.CAT_ID where [PRODUCT_BARCODE] = '" + cmbBarcode.SelectedItem + "'", con);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dg_search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSaleReturn_Click(object sender, EventArgs e)
        {
            SalesReturnForms srf = new SalesReturnForms(lbluser.Text);
            srf.Show();
        }

       
        
       
    }

     

       
    }

