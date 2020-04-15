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
    public partial class frmPrint : Form
    {
      

        List<Receipt> _list;
        string _total, _cash,_change,_date,_time,_operator;
        int _billNo;
        int _bit;

        public frmPrint(List<Receipt> datasource, string total, string cash, string change, string date , string time, string Operator, int billNo, int bit)
        {

           
            InitializeComponent();
            _list = datasource;
            _total = total;
            _cash= cash;
            _change = change;
            _date = date;
            _time = time;
            _operator = Operator;
            _billNo = billNo;
            _bit = bit;
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            
            if (_bit == 1)
            {

               
                   
                    // ManageReceipt MR = new ManageReceipt();
                    DataTable ManageReceipt = new DataTable();
                    ReceiptBindingSource.DataSource = _list;
                    foreach (var ReceiptRecord in _list)
                    {
                        var Quantity = ReceiptRecord.QTY;
                        var ProductID = ReceiptRecord.BARCODE_ID;
                        int Quantities = Quantity;
                        string id = ProductID;
                        string TOTAL = Convert.ToString(ReceiptRecord.TOTAL);
                        string UNIT_TOTAL = Convert.ToString(ReceiptRecord.UNIT_PRICE);

                        SaveInvoiceData(id, Quantities, TOTAL, _billNo, _date, _time, UNIT_TOTAL, ReceiptRecord.PRODUCT_NAME, _cash, _change, _operator);
                        UpdateStockQuantityProducts(id, Quantities);


                    }




                    Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
                 {
                new Microsoft.Reporting.WinForms.ReportParameter("pTotal",_total),
                new Microsoft.Reporting.WinForms.ReportParameter("pCash",_cash),
                new Microsoft.Reporting.WinForms.ReportParameter("pChange",_change),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate",_date),


                 new Microsoft.Reporting.WinForms.ReportParameter("pBill", Convert.ToString( _billNo)),
                 new Microsoft.Reporting.WinForms.ReportParameter("pOperator", _operator),
                 new Microsoft.Reporting.WinForms.ReportParameter("pTime", _time),
                 };





                    this.reportViewer1.LocalReport.SetParameters(para);
                    this.reportViewer1.RefreshReport();
              }
                

                else
                {


                   

                    DataTable ManageReceipt = new DataTable();
                    ReceiptBindingSource.DataSource = _list;
                    foreach (var ReceiptRecord in _list)
                    {
                        var Quantity = ReceiptRecord.QTY;
                        var ProductID = ReceiptRecord.BARCODE_ID;
                        int Quantities = Quantity;
                        string id = ProductID;
                        string TOTAL = Convert.ToString(ReceiptRecord.TOTAL);
                        string UNIT_TOTAL = Convert.ToString(ReceiptRecord.UNIT_PRICE);

                        Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
                 {
                new Microsoft.Reporting.WinForms.ReportParameter("pTotal",_total),
                new Microsoft.Reporting.WinForms.ReportParameter("pCash",_cash),
                new Microsoft.Reporting.WinForms.ReportParameter("pChange",_change),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate",_date),


                 new Microsoft.Reporting.WinForms.ReportParameter("pBill", Convert.ToString( _billNo)),
                 new Microsoft.Reporting.WinForms.ReportParameter("pOperator", _operator),
                 new Microsoft.Reporting.WinForms.ReportParameter("pTime", _time),
                 };





                        this.reportViewer1.LocalReport.SetParameters(para);
                        this.reportViewer1.RefreshReport();



                    }
                }
            }
        

      
    


        public void UpdateStockQuantityProducts(string product_id, int Quantity)
        {

            DB db = new DB();
            DataTable table = new DataTable();
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@productid", SqlDbType.NVarChar);
            parameters[0].Value = product_id;

            parameters[1] = new SqlParameter("@productQty", SqlDbType.Int);
            parameters[1].Value = Quantity;
            db.openConnection();
            db.setData("sp_update_stock", parameters);
            db.closeConnection();

        }



        public void SaveInvoiceData(string product_id, int Quantity, string Total, int BillNO, string date, string time, string UnitPrice, string productName,string cash, string change, string operatr)
        {

            DB db = new DB();
            DataTable table = new DataTable();
            SqlParameter[] parameters = new SqlParameter[11];

            parameters[0] = new SqlParameter("@productid", SqlDbType.NVarChar);
            parameters[0].Value = product_id;

            parameters[1] = new SqlParameter("@productQty", SqlDbType.Int);
            parameters[1].Value = Quantity;


            parameters[2] = new SqlParameter("@productTotal", SqlDbType.NVarChar);
            parameters[2].Value = Total;


            parameters[3] = new SqlParameter("@productBillNo", SqlDbType.Int);
            parameters[3].Value = BillNO;

            parameters[4] = new SqlParameter("@date", SqlDbType.NVarChar);
            parameters[4].Value = date;


            parameters[5] = new SqlParameter("@time", SqlDbType.NVarChar);
            parameters[5].Value = time;


            parameters[6] = new SqlParameter("@UnitPrice", SqlDbType.NVarChar);
            parameters[6].Value = UnitPrice;

            parameters[7] = new SqlParameter("@productName", SqlDbType.NVarChar);
            parameters[7].Value = productName;


            parameters[8] = new SqlParameter("@cash", SqlDbType.VarChar);
            parameters[8].Value = cash;


            parameters[9] = new SqlParameter("@change", SqlDbType.VarChar);
            parameters[9].Value = change;

            parameters[10] = new SqlParameter("@optr", SqlDbType.VarChar);
            parameters[10].Value = operatr;






            db.openConnection();
            db.setData("spr_insert_Receiptss", parameters);
            db.closeConnection();

        }




    }
}
