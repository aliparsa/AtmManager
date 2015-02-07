using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Atm_Manager
{
    class DatabaseHelper
    {
        public  OleDbConnection con;
        public  DataSet ds1;
        public  OleDbDataAdapter da;
        public  OleDbCommandBuilder cb;
        public DatabaseHelper()
        {
            con = new OleDbConnection();
            ds1 = new DataSet();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\atm.accdb";
            
        }


        public void addProduct(Product product)
        {
            string sql = "select * from product";
            da = new System.Data.OleDb.OleDbDataAdapter(sql, con);
            con.Open();
            da.Fill(ds1, "product");

            cb = new System.Data.OleDb.OleDbCommandBuilder(da);
            System.Data.DataRow dRow = ds1.Tables["product"].NewRow();
            dRow[1] = product.name;
            dRow[2] = product.serial;
            ds1.Tables["product"].Rows.Add(dRow);
            da.Update(ds1, "product");
            con.Close();
        }








        internal void removeProduct(String  productId)
        {
            string sql = " DELETE FROM product WHERE id =" + productId;
            con.Open();
            OleDbCommand My_Command = new OleDbCommand(sql, con);
            My_Command.ExecuteNonQuery();
            con.Close();

        }

    }
}
