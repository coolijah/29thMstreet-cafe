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
    public partial class IngredientsForm : Form
    {
        public IngredientsForm()
        {
            InitializeComponent();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            Clear();
            inTB.Enabled = true;
            rpTB.Enabled = true;
            ohTB.Enabled = true;
            unitTB.Enabled = true;
            snTB.Enabled = true;
            deleteBTN.Enabled = false;
            editBTN.Enabled = false;
            saveBTN.Enabled = false;
            newBTN.Enabled = true;
            clearBTN.Enabled = true;
        }

        public void DisplayIngredients()
        {
            String sql;
            SqlCeCommand comm = new SqlCeCommand();
            SqlCeDataReader reader;

            sql = "SELECT * from Ingredients";
            comm.Connection = _29thStreet_Cafe_Sales_Inventory_System.Connector.db.getConnection();
            comm.CommandText = sql;

            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                this.ingrGV.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5));
            }
            reader.Close();
            comm.Dispose();
        }

        private void clearBTN_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            idTF.Text = "";
            inTB.Text = "";
            rpTB.Text = "";
            ohTB.Text = "";
            unitTB.Text = "";
            snTB.Text = "";
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            Ingredients i = new Ingredients();
            if (MessageBox.Show("Are you sure you want to delete?",
                 "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                i.IngrID = Convert.ToInt16(ingrGV.SelectedCells[0].Value);
                i.Delete();
                ingrGV.Rows.Clear();
                DisplayIngredients();
            }
        }

        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            DisplayIngredients();
            BagO();
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            inTB.Enabled = true;
            rpTB.Enabled = true;
            ohTB.Enabled = true;
            unitTB.Enabled = true;
            snTB.Enabled = true;
            deleteBTN.Enabled = false;
            editBTN.Enabled = false;
            saveBTN.Enabled = true;
            newBTN.Enabled = false;
            clearBTN.Enabled = true;
            addBTN.Enabled = false;
        }

        private void ingrGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String sql;
            SqlCeCommand comm = new SqlCeCommand();
            SqlCeDataReader reader;

            idTF.Text = this.ingrGV.SelectedCells[0].Value.ToString();
            sql = "SELECT * from Ingredients where ingredientID=" + Convert.ToInt64(idTF.Text);
            comm.Connection = _29thStreet_Cafe_Sales_Inventory_System.Connector.db.getConnection();
            comm.CommandText = sql;

            reader = comm.ExecuteReader();

            reader.Read();
            inTB.Text = reader.GetString(1);
            rpTB.Text = Convert.ToString(reader.GetInt32(2));
            ohTB.Text = Convert.ToString(reader.GetInt32(3));
            unitTB.Text = reader.GetString(4);
            snTB.Text = reader.GetString(5);

            reader.Close();
            comm.Dispose();
            BagO();
        }

        private void newBTN_Click(object sender, EventArgs e)
        {
            Ingredients i = new Ingredients();
            i.IngrName = inTB.Text.ToString();
            i.ReorderPt = Convert.ToInt16(rpTB.Text);
            i.OnHand = Convert.ToInt16(ohTB.Text);
            i.Unit = unitTB.Text.ToString();
            i.SupName = snTB.Text.ToString();
            i.Save();
            ingrGV.Rows.Clear();
            DisplayIngredients();
        }

        public void BagO()
        {
            idTF.Enabled = false;
            inTB.Enabled = false;
            rpTB.Enabled = false;
            ohTB.Enabled = false;
            unitTB.Enabled = false;
            snTB.Enabled = false;
            clearBTN.Enabled = false;
            newBTN.Enabled = false;
            saveBTN.Enabled = false;
            addBTN.Enabled = true;
            editBTN.Enabled = true;
            deleteBTN.Enabled = true;
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            Ingredients i = new Ingredients();
            i.IngrID = Convert.ToInt16(ingrGV.SelectedCells[0].Value);
            i.IngrName = inTB.Text.ToString();
            i.ReorderPt = Convert.ToInt16(rpTB.Text);
            i.OnHand = Convert.ToInt16(ohTB.Text);
            i.Unit = unitTB.Text.ToString();
            i.SupName = snTB.Text.ToString();
            i.Edit();
            ingrGV.Rows.Clear();
            DisplayIngredients();
        }
    }
}
