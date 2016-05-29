using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace _29thStreet_Cafe_Sales_Inventory_System
{
    public class DBconn
    {
        private SqlCeConnection conn;

        public void connect()
        {
            this.conn = new SqlCeConnection("Data Source=C:\\Users\\Guest 2\\Desktop\\29thStreet_Cafe_Sales_Inventory_System\\29thStreet_Cafe_Sales_Inventory_System\\29thStreetCafeDB.sdf");
            //this.conn = new SqlCeConnection("Data Source=C:\\Users\\User\\Documents\\C#\\29thStreet_Cafe_Sales_Inventory_System\\29thStreet_Cafe_Sales_Inventory_System\\29thStreetCafeDB.sdf");
            try { this.conn.Open(); }
            catch (SqlCeException ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        public SqlCeConnection getConnection()
        {
            return this.conn;
        }
    }
}
