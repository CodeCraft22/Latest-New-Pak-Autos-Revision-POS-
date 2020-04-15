using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Csharp_Project
{
   public  class Invoices
    {

        public DataTable getInvoicesData()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            tab = db.getData("[spr_get_InvoiceData]", null);
            db.closeConnection();
            return tab;
        }

    }
}
