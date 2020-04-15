using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
   public class Receipt
    {
       public string BARCODE_ID { get; set; }
       public string PRODUCT_NAME { get; set; }
       public double UNIT_PRICE { get; set; }
       public int QTY { get; set; }
       public double TOTAL { get; set; }

    }
}
