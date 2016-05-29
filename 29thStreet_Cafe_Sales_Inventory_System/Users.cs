using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace _29thStreet_Cafe_Sales_Inventory_System
{
    class Users
    {
        private int _userID;
        private string _fname;
        private string _lname;
        private string _type;
        private string _username;
        private string _password;
    
        public int UserID
        {
            get
            {
                return _userID;
            }
            set
            {
                this._userID = value;
            }
        }

        public string Fname
        {
            get
            {
                return _fname;
            }
            set
            {
                this._fname = value;
            }
        }

        public string Lname
        {
            get
            {
                return _lname;
            }
            set
            {
                this._lname = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                this._type = value;
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                this._username = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                this._password = value;
            }
        }

        public void Save()
        {
            String insert = "";
            SqlCeCommand comm = new SqlCeCommand();

            insert = "INSERT INTO Users (fname, lname, type, username, password) VALUES (@Fname, @Lname, @Type, @Username, @Password)";

            comm.CommandText = insert;
            comm.Connection = _29thStreet_Cafe_Sales_Inventory_System.Connector.db.getConnection();
            comm.Parameters.Add("@Fname", this.Fname);
            comm.Parameters.Add("@Lname", this.Lname);
            comm.Parameters.Add("@Type", this.Type);
            comm.Parameters.Add("@Username", this.Username);
            comm.Parameters.Add("@Password", this.Password);
            comm.Prepare();

            try { comm.ExecuteNonQuery(); }
            catch (SqlCeException ex) {
                System.Windows.Forms.MessageBox.Show("" + ex.Message);
            }

            comm.Dispose();
            Console.WriteLine("Successfully Added!");
        }

        public void Delete()
        {
            String delete;
            SqlCeCommand comm = new SqlCeCommand();

            delete = "DELETE FROM Users WHERE userID = " + this.UserID;
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
            edit = "UPDATE Users set fname='" + @Fname + "',lname='" + @Lname + "',type='" + @Type + "',username='" + @Username + "',password='" + @Password + "' where userID=" + UserID;
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
