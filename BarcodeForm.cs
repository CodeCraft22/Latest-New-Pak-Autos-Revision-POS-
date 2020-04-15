using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace Csharp_Project
{
    public partial class BarcodeForm : Form
    {
        ReportDocument crystal = new ReportDocument();

        public BarcodeForm()
        {
            InitializeComponent();
        }

        private void txtShow_Click(object sender, EventArgs e)
        {
           
            
                  
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MY_DB;Integrated Security=true");

            string sql = "select * from product where PRODUCT_BARCODE ='" + txtProductCode.Text + "'";

            if (txtcopy.Text != string.Empty)
            {

                for (int i = 1; i < int.Parse(txtcopy.Text); i++)
                {

                    sql = sql + "Union All select * from product where PRODUCT_BARCODE ='" + txtProductCode.Text + "'";
                }



                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "PRODUCT");
                crystal.SetDataSource(ds);
                crystalReportViewer1.ReportSource = crystal;
            }
            else
            {

                MessageBox.Show("Please provide no of copies to generate barcode. Thanks ");
            }
        }

        private void BarcodeForm_Load(object sender, EventArgs e)
        {
            crystal.Load(@"D:\POS(Mujhaid Final Deployed)\C# POS Software\Mujhaid software final update and deployment\Auto Soft Most Recent Update of  08-04-2020\NPA_Archive 08.04.2020 Testing\Barcode.rpt");
        }

        private void txtShowAll_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=MY_DB;Integrated Security=true");
            SqlDataAdapter sda = new SqlDataAdapter("select * from product", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "PRODUCT");
            crystal.SetDataSource(ds);
            crystalReportViewer1.ReportSource = crystal;
        }
    }
}
