using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace _29thStreet_Cafe_Sales_Inventory_System
{
    class Ingredients
    {

        private int _ingrID;
        private string _ingrName;
        private int _reorderPt;
        private int _onHand;
        private string _supName;
        private string _unit;

        public int IngrID
        {
            get
            {
                return _ingrID;
            }
            set
            {
                this._ingrID = value;
            }
        }

        public string IngrName
        {
            get
            {
                return _ingrName;
            }
            set
            {
                this._ingrName = value;
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

        public string Unit
        {
            get
            {
                return _unit;
            }
            set
            {
                this._unit = value;
            }
        }

        public void Save()
        {
            String insert = "";
            SqlCeCommand comm = new SqlCeCommand();

            insert = "INSERT INTO Ingredients (ingredientName, reorderPt, onHand, unit, supplierName) VALUES (@IngrName, @ReorderPt, @OnHand, @Unit, @SupName)";

            comm.CommandText = insert;
            comm.Connection = _29thStreet_Cafe_Sales_Inventory_System.Connector.db.getConnection();
            comm.Parameters.Add("@IngrName", this.IngrName);
            comm.Parameters.Add("@ReorderPt", this.ReorderPt);
            comm.Parameters.Add("@OnHand", this.OnHand);
            comm.Parameters.Add("@Unit", this.Unit);
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

        public void Edit()
        {
            String edit;
            SqlCeCommand comm = new SqlCeCommand();
            edit = "UPDATE Ingredients set ingredientName='" + @IngrName + "',reorderPt=" + @ReorderPt + ",onHand=" + @OnHand + ",unit='" + @Unit + "',supplierName='" + @SupName + "' where ingredientID=" + IngrID;
            comm.Connection = _29thStreet_Cafe_Sales_Inventory_System.Connector.db.getConnection();
            comm.CommandText = edit;
            Console.WriteLine(edit);
            comm.Prepare();

            try { comm.ExecuteNonQuery(); }
            catch (SqlCeException ex) { System.Windows.Forms.MessageBox.Show("" + ex.Message); }
            comm.Dispose();
            Console.WriteLine("Success Update!");
        }

        public void Delete()
        {
            String delete;
            SqlCeCommand comm = new SqlCeCommand();

            delete = "DELETE FROM Ingredients WHERE ingredientID = " + this.IngrID;
            comm.Connection = _29thStreet_Cafe_Sales_Inventory_System.Connector.db.getConnection();
            comm.CommandText = delete;
            Console.WriteLine(delete);
            comm.Prepare();

            try { comm.ExecuteNonQuery(); }
            catch (SqlCeException ex) { System.Windows.Forms.MessageBox.Show("" + ex.Message); }
            comm.Dispose();
            Console.WriteLine("Success Delete!");
        }
    }
}
