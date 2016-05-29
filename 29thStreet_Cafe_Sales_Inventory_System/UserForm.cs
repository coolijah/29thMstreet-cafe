using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace _29thStreet_Cafe_Sales_Inventory_System
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void userGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String sql;
            SqlCeCommand comm = new SqlCeCommand();
            SqlCeDataReader reader;

            idTB.Text = this.userGV.SelectedCells[0].Value.ToString();
            sql = "SELECT * from Users where userID="+Convert.ToInt64(idTB.Text);
            comm.Connection = _29thStreet_Cafe_Sales_Inventory_System.Connector.db.getConnection();
            comm.CommandText = sql;

            reader = comm.ExecuteReader();

            reader.Read();
            fnTB.Text = reader.GetString(1);
            lnTB.Text = reader.GetString(2);
            if (reader.GetString(3) == "Owner" || reader.GetString(3) == "owner") { ownerRB.Checked = true; staffRB.Checked = false; }
            else if (reader.GetString(3) == "Staff" || reader.GetString(3) == "staff") { staffRB.Checked = true; ownerRB.Checked = false; }
            unTB.Text = reader.GetString(4);
            pwTB.Text = reader.GetString(5);
            
            reader.Close();
            comm.Dispose();
            BagO();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {            
            Clear();
            fnTB.Enabled = true;
            lnTB.Enabled = true;
            ownerRB.Enabled = true;
            staffRB.Enabled = true;
            unTB.Enabled = true;
            pwTB.Enabled = true;
            deleteBTN.Enabled = false;
            editBTN.Enabled = false;
            saveBTN.Enabled = false;
            newBTN.Enabled = true;
            clearBTN.Enabled = true;
        }

        public void displayUser()
        {
            String sql;
            SqlCeCommand comm = new SqlCeCommand();
            SqlCeDataReader reader;

            sql = "SELECT * from Users";
            comm.Connection = _29thStreet_Cafe_Sales_Inventory_System.Connector.db.getConnection();
            comm.CommandText = sql;

            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                this.userGV.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
            }
            reader.Close();
            comm.Dispose();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

            idTB.Enabled = false;
            fnTB.Enabled = false;
            lnTB.Enabled = false;
            ownerRB.Enabled = false;
            staffRB.Enabled = false;
            unTB.Enabled = false;
            pwTB.Enabled = false;
            clearBTN.Enabled = false;
            newBTN.Enabled = false;
            saveBTN.Enabled = false;
            addBTN.Enabled = true;
            displayUser();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            if (MessageBox.Show("Are you sure you want to delete?",
                 "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                u.UserID = Convert.ToInt16(userGV.SelectedCells[0].Value);
                u.Delete();
                userGV.Rows.Clear();
                displayUser();
            }            
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            idTB.Text = "";
            fnTB.Text = "";
            lnTB.Text = "";
            ownerRB.Checked = false;
            staffRB.Checked = false;
            unTB.Text = "";
            pwTB.Text = "";
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            fnTB.Enabled = true;
            lnTB.Enabled = true;
            ownerRB.Enabled = true;
            staffRB.Enabled = true;
            unTB.Enabled = true;
            pwTB.Enabled = true;
            deleteBTN.Enabled = false;
            editBTN.Enabled = false;
            saveBTN.Enabled = true;
            newBTN.Enabled = false;
            clearBTN.Enabled = true;
            addBTN.Enabled = false;
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.UserID = Convert.ToInt16(userGV.SelectedCells[0].Value);
            u.Fname = fnTB.Text.ToString();
            u.Lname = lnTB.Text.ToString();
            if (ownerRB.Checked) { u.Type = "Owner"; }
            else if (staffRB.Checked) { u.Type = "Staff"; }
            u.Username = unTB.Text.ToString();
            u.Password = pwTB.Text.ToString();
            u.Edit();
            userGV.Rows.Clear();
            displayUser();
        }

        private void newBTN_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.Fname = fnTB.Text.ToString();
            u.Lname = lnTB.Text.ToString();
            if (ownerRB.Checked) { u.Type = "Owner"; }
            else if (staffRB.Checked) { u.Type = "Staff"; }
            u.Username = unTB.Text.ToString();
            u.Password = pwTB.Text.ToString();
            u.Save();
            userGV.Rows.Clear();
            displayUser();
        }

        public void BagO()
        {
            
            idTB.Enabled = false;
            fnTB.Enabled = false;
            lnTB.Enabled = false;
            ownerRB.Enabled = false;
            staffRB.Enabled = false;
            unTB.Enabled = false;
            pwTB.Enabled = false;
            clearBTN.Enabled = false;
            newBTN.Enabled = false;
            saveBTN.Enabled = false;
            addBTN.Enabled = true;
            editBTN.Enabled = true;
            deleteBTN.Enabled = true;
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            String sql;
            SqlCeCommand comm = new SqlCeCommand();
            SqlCeDataReader reader;
            comm.Connection = _29thStreet_Cafe_Sales_Inventory_System.Connector.db.getConnection();
            

            if (comboBox1.Text == "Lastname")
            {
                this.userGV.Rows.Clear();
                sql = "SELECT * from Users where lname LIKE '" + searchTB.Text + "%'";
                comm.CommandText = sql;                
            }

            else if (comboBox1.Text == "User ID")
            {
                this.userGV.Rows.Clear();
                sql = "SELECT * from Users where userID LIKE " + Convert.ToInt32(searchTB.Text);
                comm.CommandText = sql;
                
            }

            else if (comboBox1.Text == "Firstname")
            {
                this.userGV.Rows.Clear();
                sql = "SELECT * from Users where fname LIKE '" + searchTB.Text + "%'";
                comm.CommandText = sql;
            }

            else if (comboBox1.Text == "Type")
            {
                this.userGV.Rows.Clear();
                sql = "SELECT * from Users where type LIKE '" + searchTB.Text + "%'";
                comm.CommandText = sql;
            }

            else if (comboBox1.Text == "Username")
            {
                this.userGV.Rows.Clear();
                sql = "SELECT * from Users where username LIKE '" + searchTB.Text + "%'";
                comm.CommandText = sql;
            }

            else if (comboBox1.Text == "Password")
            {
                this.userGV.Rows.Clear();
                sql = "SELECT * from Users where password LIKE '" + searchTB.Text + "%'";
                comm.CommandText = sql;
            }

            else {
                this.userGV.Rows.Clear();
                displayUser();
            }
            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                this.userGV.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
            }
            reader.Close();
            comm.Dispose();
        }
    }
}
