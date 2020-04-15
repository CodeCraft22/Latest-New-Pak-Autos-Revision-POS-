using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Csharp_Project
{
    class Product
    {

        public void insertProduct(int cid, string name, string price, byte[] image, int quantity, string desc, string BARCODE, string UNIT, int MinimumQuantity, string Brand, string WholeSale, string Purchase,string location)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[13];

            parameters[0] = new SqlParameter("@c_id", SqlDbType.Int);
            parameters[0].Value = cid;
             
            parameters[1] = new SqlParameter("@p_name", SqlDbType.VarChar,50);
            parameters[1].Value = name;

            parameters[2] = new SqlParameter("@s_qty", SqlDbType.Int);
            parameters[2].Value = quantity;

            parameters[3] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            parameters[3].Value = price;

            parameters[4] = new SqlParameter("@desc", SqlDbType.VarChar);
            parameters[4].Value = desc;

            parameters[5] = new SqlParameter("@img", SqlDbType.Image);
            parameters[5].Value = image;

            //added by ali abdullah
            parameters[6] = new SqlParameter("@BARCODE", SqlDbType.NVarChar);
            parameters[6].Value = BARCODE;

            parameters[7] = new SqlParameter("@UNIT", SqlDbType.VarChar);
            parameters[7].Value = UNIT;

            parameters[8] = new SqlParameter("@MinimumQuantity", SqlDbType.Int);
            parameters[8].Value = MinimumQuantity;
            //end

            parameters[9] = new SqlParameter("@Brand", SqlDbType.VarChar);
            parameters[9].Value = Brand;

            parameters[10] = new SqlParameter("@WholeSale", SqlDbType.VarChar);
            parameters[10].Value = WholeSale;

            parameters[11] = new SqlParameter("@Purchase", SqlDbType.VarChar);
            parameters[11].Value = Purchase;

            parameters[12] = new SqlParameter("@location", SqlDbType.NVarChar);
            parameters[12].Value = location;
         

            db.setData("spr_insert_product", parameters);
            db.closeConnection();

        }

        public DataTable getProducts()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            tab = db.getData("spr_get_Products", null);
            db.closeConnection();
            return tab;
        }



        public DataTable GetLast10Products()
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            tab = db.getData("spr_GetLast10Products", null);
            db.closeConnection();
            return tab;
        }



        public DataTable getProduct(int id)
        {
            DB db = new DB();
            DataTable tab = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            tab = db.getData("spr_get_Product_by_id", parameters);
            db.closeConnection();
            return tab;
        }

        public DataTable getProductsByCategory(int cat_id)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@cid", SqlDbType.Int);
            parameters[0].Value = cat_id;
            table = db.getData("spr_products_by_category", parameters);
            db.closeConnection();
            return table;
        }


        //public DataTable searchProducts(string valueToSearch)
        //{

        //    DB db = new DB();
        //    DataTable table = new DataTable();
        //    SqlParameter[] parameters = new SqlParameter[1];
        //    parameters[0] = new SqlParameter("@val", SqlDbType.VarChar, 100);
        //    parameters[0].Value = valueToSearch;
        //    table = db.getData("spr_search_Products",parameters);
        //    db.closeConnection();
        //    return table;

        //}




        public DataTable SearchbyProductsBarcode(string valueToSearch)
        {

            DB db = new DB();
            DataTable table = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@val", SqlDbType.VarChar, 100);
            parameters[0].Value = valueToSearch;
            table = db.getData("spr_search_Products", parameters);
            db.closeConnection();
            return table;

        }






        //Modify according to client requirement
        public void insertWithoutImageProduct(int cid, string name, string price, int quantity, string desc, string BARCODE, string UNIT, int MinimumQuantity, string Brand, string WholeSale, string Purchase,string location)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[12];

            parameters[0] = new SqlParameter("@c_id", SqlDbType.Int);
            parameters[0].Value = cid;

            parameters[1] = new SqlParameter("@p_name", SqlDbType.VarChar, 50);
            parameters[1].Value = name;

            parameters[2] = new SqlParameter("@s_qty", SqlDbType.Int);
            parameters[2].Value = quantity;

            parameters[3] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            parameters[3].Value = price;

            parameters[4] = new SqlParameter("@desc", SqlDbType.VarChar);
            parameters[4].Value = desc;


            //added by ali abdullah
            parameters[5] = new SqlParameter("@BARCODE", SqlDbType.NVarChar);
            parameters[5].Value = BARCODE;

            parameters[6] = new SqlParameter("@UNIT", SqlDbType.VarChar);
            parameters[6].Value = UNIT;

            parameters[7] = new SqlParameter("@MinimumQuantity", SqlDbType.Int);
            parameters[7].Value = MinimumQuantity;
            //end

            parameters[8] = new SqlParameter("@Brand", SqlDbType.VarChar);
            parameters[8].Value = Brand;

            parameters[9] = new SqlParameter("@WholeSale", SqlDbType.VarChar);
            parameters[9].Value = WholeSale;

            parameters[10] = new SqlParameter("@Purchase", SqlDbType.VarChar);
            parameters[10].Value = Purchase;


            parameters[11] = new SqlParameter("@location", SqlDbType.NVarChar);
            parameters[11].Value = location;



            db.setData("spr_insert_product_custom", parameters);
            db.closeConnection();

        }

        public void deleteProducts(int product_id)
        {

            DB db = new DB();
            DataTable table = new DataTable();
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@pid", SqlDbType.Int);
            parameters[0].Value = product_id;

            db.openConnection();
            db.setData("spr_delete_Products", parameters);
            db.closeConnection();
           
        }

        public void updateProduct(int pid, int cid, string name, string price, byte[] image, int quantity, string desc, string productBaarcode, string unit, int minimumAmount, string Brand, string WholeSale, string Purchase, string location)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[14];

            parameters[0] = new SqlParameter("@pid", SqlDbType.Int);
            parameters[0].Value = pid;
           
            parameters[1] = new SqlParameter("@c_id", SqlDbType.Int);
            parameters[1].Value = cid;

            parameters[2] = new SqlParameter("@p_name", SqlDbType.VarChar, 50);
            parameters[2].Value = name;

            parameters[3] = new SqlParameter("@s_qty", SqlDbType.Int);
            parameters[3].Value = quantity;

            parameters[4] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            parameters[4].Value = price;

            parameters[5] = new SqlParameter("@desc", SqlDbType.VarChar);
            parameters[5].Value = desc;

            parameters[6] = new SqlParameter("@img", SqlDbType.Image);
            parameters[6].Value = image;



            parameters[7] = new SqlParameter("@productBaarcode", SqlDbType.NVarChar);
            parameters[7].Value = productBaarcode;

            parameters[8] = new SqlParameter("@unit", SqlDbType.VarChar);
            parameters[8].Value = unit;

            parameters[9] = new SqlParameter("@minimumAmount", SqlDbType.Int);
            parameters[9].Value = minimumAmount;


            parameters[10] = new SqlParameter("@Brand", SqlDbType.VarChar);
            parameters[10].Value = Brand;

            parameters[11] = new SqlParameter("@WholeSale", SqlDbType.VarChar);
            parameters[11].Value = WholeSale;

            parameters[12] = new SqlParameter("@Purchase", SqlDbType.VarChar);
            parameters[12].Value = Purchase;

            parameters[13] = new SqlParameter("@location", SqlDbType.NVarChar);
            parameters[13].Value = location;
            


            db.setData("spr_update_Product", parameters);
            db.closeConnection();
            
        }



        public void updateProductwithoutImage(int pid, int cid, string name, string price, int quantity, string desc, string productBaarcode, string unit, int minimumAmount, string Brand, string WholeSale, string Purchase, string location)
        {

            DB db = new DB();
            db.openConnection();
            SqlParameter[] parameters = new SqlParameter[13];

            parameters[0] = new SqlParameter("@pid", SqlDbType.Int);
            parameters[0].Value = pid;

            parameters[1] = new SqlParameter("@c_id", SqlDbType.Int);
            parameters[1].Value = cid;

            parameters[2] = new SqlParameter("@p_name", SqlDbType.VarChar, 50);
            parameters[2].Value = name;

            parameters[3] = new SqlParameter("@s_qty", SqlDbType.Int);
            parameters[3].Value = quantity;

            parameters[4] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            parameters[4].Value = price;

            parameters[5] = new SqlParameter("@desc", SqlDbType.VarChar);
            parameters[5].Value = desc;

            //parameters[6] = new SqlParameter("@img", SqlDbType.Image);
            //parameters[6].Value = image;



            parameters[6] = new SqlParameter("@productBaarcode", SqlDbType.NVarChar);
            parameters[6].Value = productBaarcode;

            parameters[7] = new SqlParameter("@unit", SqlDbType.VarChar);
            parameters[7].Value = unit;

            parameters[8] = new SqlParameter("@minimumAmount", SqlDbType.Int);
            parameters[8].Value = minimumAmount;


            parameters[9] = new SqlParameter("@Brand", SqlDbType.VarChar);
            parameters[9].Value = Brand;

            parameters[10] = new SqlParameter("@WholeSale", SqlDbType.VarChar);
            parameters[10].Value = WholeSale;

            parameters[11] = new SqlParameter("@Purchase", SqlDbType.VarChar);
            parameters[11].Value = Purchase;


            parameters[12] = new SqlParameter("@location", SqlDbType.NVarChar);
            parameters[12].Value = location;




            db.setData("spr_update_Product_Custom", parameters);
            db.closeConnection();

        }
    }
}
