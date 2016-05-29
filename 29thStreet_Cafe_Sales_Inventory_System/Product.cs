using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace _29thStreet_Cafe_Sales_Inventory_System
{
    class Product
    {
        private int _prodID;
        private string _prodName;
        private double _price;
        private int _reorderPt;
        private int _onHand;
        private string _supName;

        public int ProdID
        {
            get
            {
                return _prodID;
            }
            set
            {
                this._prodID = value;
            }
        }

        public string ProdName
        {
            get
            {
                return _prodName;
            }
            set
            {
                this._prodName = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                this._price = value;
            }
        }

        public int ReorderPt
        {
            get
            {
                return _reorderPt;
            }
            set
            {
                this._reorderPt = value;
            }
        }

        public int OnHand
        {
            get
            {
                return _onHand;
            }
            set
            {
                this._onHand = value;
            }
        }

        public string SupName
        {
            get
            {
                return _supName;
            }
            set
            {
                this._supName = value;
            }
        }

        public void Save()
        {
            String insert = "";
            SqlCeCommand comm = new SqlCeCommand();

            insert = "INSERT INTO Product (prodName, price, reorderPt, onHand, supplierName) VALUES (@ProdName, @Price, @ReorderPt, @OnHand, @SupName)";

            comm.CommandText = insert;
            comm.Connection = _29thStreet_Cafe_Sales_Inventory_System.Connector.db.getConnection();
            comm.Parameters.Add("@ProdName", this.ProdName);
            comm.Parameters.Add("@Price", this.Price);
            comm.Parameters.Add("@ReorderPt", this.ReorderPt);
            comm.Parameters.Add("@OnHand", this.OnHand);
            comm.Parameters.Add("@SupName", this.SupName);
            comm.Prepare();

            try { comm.ExecuteNonQuery(); }
            catch (SqlCeException ex)
            {
                System.Windows.Forms.MessageBox.Show("" + ex.Message);
            }

            comm.Dispose();
            Console.WriteLine("Successfully Added!");
        }

        public void Delete()
        {
            String delete;
            SqlCeCommand comm = new SqlCeCommand();

            delete = "DELETE FROM Product WHERE prodID = " + this.ProdID;
            comm.Connection = _29thStreet_Cafe_Sales_Inventory_System.Connector.db.getConnection();
            comm.CommandText = delete;
            Console.WriteLine(delete);
            comm.Prepare();

            try { comm.ExecuteNonQuery(); }
            catch (SqlCeException ex) { System.Windows.Forms.MessageBox.Show("" + ex.Message); }
            comm.Dispose();
            Console.WriteLine("Success Delete!");
        }

        public void Edit()
        {
            String edit;
            SqlCeCommand comm = new SqlCeCommand();
            edit = "UPDATE Product set prodName='" + @ProdName + "',price=" + @Price + ",reorderPt=" + @ReorderPt + ",onHand=" + @OnHand + ",supplierName='" + @SupName + "' where prodID=" + ProdID;
            comm.Connection = _29thStreet_Cafe_Sales_Inventory_System.Connector.db.getConnection();
            comm.CommandText = edit;
            Console.WriteLine(edit);
            comm.Prepare();

            try { comm.ExecuteNonQuery(); }
            catch (SqlCeException ex) { System.Windows.Forms.MessageBox.Show("" + ex.Message); }
            comm.Dispose();
            Console.WriteLine("Success Update!");
        }
    }
}
