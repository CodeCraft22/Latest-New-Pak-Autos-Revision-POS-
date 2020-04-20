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
using System.IO;
using Spire.PdfViewer.Forms;



namespace Csharp_Project
{
    public partial class SalesReturnForms : Form
    {
        public SalesReturnForms(string user)
        {
            int sum = 0;
            string Operator = user;
            InitializeComponent();
            DGV_SALES_RETURN.DataSource = getInvoicesData();
   
            SaleBindingSource.DataSource = new List<Receipt>();

            for (int i = 0; i < DGV_SALES_RETURN.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(DGV_SALES_RETURN.Rows[i].Cells[5].Value);
            }


            txtTotal.Text = string.Format("{0}.00", sum.ToString());
            txtTotal.Enabled = false;
            txtQuanity.Enabled = false;
            txtProductName.Enabled = false;
            txtUnitPrice.Enabled = false;
            txtBarcode.Enabled = false;
            txtSaleAmount.Enabled = false;
            txtBillNo.Enabled = false;

        }



        public DataTable getInvoicesData()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            tab = db.getData("[spr_get_InvoiceData]", null);
            db.closeConnection();
            return tab;
        }

        private void DGV_SALES_RETURN_Click(object sender, EventArgs e)
        {

            txtBillNo.Text = DGV_SALES_RETURN.CurrentRow.Cells[0].Value.ToString();
            txtBarcode.Text = DGV_SALES_RETURN.CurrentRow.Cells[1].Value.ToString();
            txtProductName.Text = DGV_SALES_RETURN.CurrentRow.Cells[2].Value.ToString();
            txtQuanity.Text = DGV_SALES_RETURN.CurrentRow.Cells[3].Value.ToString();
            txtUnitPrice.Text = DGV_SALES_RETURN.CurrentRow.Cells[4].Value.ToString();
            txtSaleAmount.Text = DGV_SALES_RETURN.CurrentRow.Cells[5].Value.ToString();
            txtDate.Text = DGV_SALES_RETURN.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnBillNo_Click(object sender, EventArgs e)
        {

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;


            if (string.IsNullOrEmpty(txtsearchbyBillNo.Text) || string.IsNullOrWhiteSpace(txtsearchbyBillNo.Text))
            {
                //MessageBox.Show("Please provide information to Search");
                string cs = "Data Source=.;Initial Catalog=MY_DB;Integrated Security=true";
                SqlConnection con;
                SqlDataAdapter adapt;
                DataTable dt;
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select productBillNo,productid,productName, productQty, UnitPrice, productTotal, [date] from Receiptss where [date] between '" + dateTimePicker1.Value.Date.ToString("MM/dd/yyyy") + "' and'" + dateTimePicker2.Value.Date.ToString("MM/dd/yyyy") + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                DGV_SALES_RETURN.DataSource = dt;
                con.Close();

                int sum = 0;
                for (int i = 0; i < DGV_SALES_RETURN.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(DGV_SALES_RETURN.Rows[i].Cells[5].Value);
                }
                txtTotal.Text = string.Format("{0}.00", sum.ToString());



            }

            else
            {

                string cs = "Data Source=.;Initial Catalog=MY_DB;Integrated Security=true";
                SqlConnection con;
                SqlDataAdapter adapt;
                DataTable dt;
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select productBillNo,productid,productName, productQty, UnitPrice, productTotal, [date] from Receiptss where productBillNo =  '" + txtBillNo.Text + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                DGV_SALES_RETURN.DataSource = dt;
                con.Close();

                int sum = 0;
                for (int i = 0; i < DGV_SALES_RETURN.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(DGV_SALES_RETURN.Rows[i].Cells[5].Value);
                }
                txtTotal.Text = string.Format("{0}.00", sum.ToString()); 

        

                //commited feature
                int flg = 2;

                Form1 frm1 = new Form1(txtsearchbyBillNo.Text, flg);
                frm1.Show();
                txtsearchbyBillNo.Text = "";
                
               
                      
                  
            }

        }



        private void txtsearchbyBillNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBillNo_Click(sender, e);
            }

            if (e.KeyCode == Keys.Back)
            {
                DGV_SALES_RETURN.DataSource = getInvoicesData();
                txtBillNo.Text = "";
                int sum = 0;
                for (int i = 0; i < DGV_SALES_RETURN.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(DGV_SALES_RETURN.Rows[i].Cells[5].Value);
                }
                txtTotal.Text = string.Format("{0}.00", sum.ToString());
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
       {

            if (textBox1.Text != string.Empty)
            {



                if(Convert.ToInt32(txtQuanity.Text) == 0)
                {
                    MessageBox.Show("Sold Quantity is already Zero, SO nothing to retuen");
                }
                else
                {


                    int SaleAmount;
                    SaleAmount = Convert.ToInt32(txtQuanity.Text) - Convert.ToInt32(textBox1.Text);
                    SaleAmount = SaleAmount * Convert.ToInt32(txtUnitPrice.Text);
                    txtSaleAmount.Text = Convert.ToString(SaleAmount);


                }




            }
            else
            {

                MessageBox.Show("Please end the No of Items to return");
            }
        
        }

    




        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please Enter the Return Quantity");
            }
            else
            {

                double _APT = 0;
                string _cash = "";
                string _change = "";
                string _date = "";
                string _time = "";
                // string _operator = "";
                int _billno = 0;
                string _operators = "";
                int _bit = 2;


                string cs = "Data Source=.;Initial Catalog=MY_DB;Integrated Security=true";
                SqlConnection con;
                SqlDataAdapter adapt;
                DataTable dt;
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select productQty from Receiptss where productBillNo ='" + txtBillNo.Text + "' and productid ='" + txtBarcode.Text + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);


                string OrignalQty = dt.Rows[0]["productQty"].ToString();
                if (Convert.ToInt16(OrignalQty) > 0)
                {

                    using (SqlConnection conn =
                       new SqlConnection(cs))
                    {
                        conn.Open();
                        using (SqlCommand cmd =
                            new SqlCommand("UPDATE PRODUCT Set STOCK_QTE = STOCK_QTE + '" + (Convert.ToInt32(textBox1.Text)) + "' where PRODUCT_BARCODE ='" + txtBarcode.Text + "'", conn))
                        {

                            cmd.ExecuteNonQuery();

                            //rows number of record got updated
                        }

                        using (SqlCommand cmd =
                          new SqlCommand("UPDATE Receiptss Set productTotal ='" + txtSaleAmount.Text + "' ,productQty = '" + (Convert.ToInt32(txtQuanity.Text) - Convert.ToInt32(textBox1.Text)) + "' where productBillNo ='" + txtBillNo.Text + "' and productid ='" + txtBarcode.Text + "'", conn))
                        {

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Sucessfully Update");
                            //rows number of record got updated

                            adapt = new SqlDataAdapter("select productBillNo,productid,productName, productQty, UnitPrice, productTotal, [date],time,cash,change, optr from Receiptss where productBillNo ='" + txtBillNo.Text + "'", con);
                            dt = new DataTable();
                            adapt.Fill(dt);
                            con.Close();
                            conn.Close();

                            

                            DGV_SALES_RETURN.DataSource = dt;
                            this.DGV_SALES_RETURN.Columns[7].Visible = false;
                            this.DGV_SALES_RETURN.Columns[8].Visible = false;
                            this.DGV_SALES_RETURN.Columns[9].Visible = false;
                            this.DGV_SALES_RETURN.Columns[10].Visible = false;


                            foreach (DataRow row in dt.Rows)
                            {
                                // TextBox1.Text = row["ImagePath"].ToString();

                                Receipt obj = new Receipt() { BARCODE_ID = row["productid"].ToString(), PRODUCT_NAME = row["productName"].ToString(), UNIT_PRICE = Convert.ToDouble(row["UnitPrice"].ToString()), QTY = Convert.ToInt32(row["productQty"].ToString()), TOTAL = Convert.ToDouble(row["productTotal"].ToString()) };

                            
                                _APT = _APT + Convert.ToDouble(row["productTotal"].ToString());
                                _cash = row["cash"].ToString();
                                _change = row["change"].ToString();
                                _date = row["date"].ToString();
                                _time = row["time"].ToString();
                                _billno = Convert.ToInt32(row["productBillNo"].ToString());
                                _operators = row["optr"].ToString();
                                SaleBindingSource.Add(obj);

                            }


                        }
                    }
                }

                using (frmPrint frm = new frmPrint(SaleBindingSource.DataSource as List<Receipt>, string.Format("{0}", Convert.ToString(_APT)), string.Format("{0}", Convert.ToString(_cash)), string.Format("{0}", Convert.ToString(_change)), _date, _time, _operators, _billno, _bit))
                {

                      frm.ShowDialog();
                      SaleBindingSource.Clear();
                  
                   //  txtTotal.Text = string.Format("{0}.00");
                     txtQuanity.Text = "";
                     txtProductName.Text = "";
                     txtUnitPrice.Text = "";
                     txtBarcode.Text = "";
                     txtSaleAmount.Text = "";
                     textBox1.Text = "";
                     txtBillNo.Text = "";
                     txtsearchbyBillNo.Text = "";
                     DGV_SALES_RETURN.DataSource = getInvoicesData();

                
                 
        

                    // for resetting fields after receipt
                };

            }

        }

        private void btnsale_Click(object sender, EventArgs e)
        {

            int flgs = 1;
            Form1 frm1 = new Form1(txtSearchbysale.Text, flgs);
            frm1.ShowDialog();
            txtSearchbysale.Text = "";
        }
    }
}
                    


                  
               







                
                
   
       
    

        


       




                 
           
         


         

