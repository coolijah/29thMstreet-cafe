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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            Clear();
            idTF.Enabled = false;
            pnTB.Enabled = true;
            rpTB.Enabled = true;
            ohTB.Enabled = true;
            priceTB.Enabled = true;
            snameTB.Enabled = true;
            deleteBTN.Enabled = false;
            editBTN.Enabled = false;
            saveBTN.Enabled = false;
            newBTN.Enabled = true;
            clearBTN.Enabled = true;
        }

        public void DisplayProduct()
        {
            String sql;
            SqlCeCommand comm = new SqlCeCommand();
            SqlCeDataReader reader;

            sql = "SELECT * from Product";
            comm.Connection = _29thStreet_Cafe_Sales_Inventory_System.Connector.db.getConnection();
            comm.CommandText = sql;

            reader = comm.ExecuteReader();

            while (reader.Read())
            {
                this.prodGV.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5));
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
            pnTB.Text = "";
            rpTB.Text = "";
            priceTB.Text = "";
            ohTB.Text = "";
            snameTB.Text = "";
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            if (MessageBox.Show("Are you sure you want to delete?",
                 "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                p.ProdID = Convert.ToInt16(prodGV.SelectedCells[0].Value);
                p.Delete();
                prodGV.Rows.Clear();
                DisplayProduct();
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            DisplayProduct();
            BagO();
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            pnTB.Enabled = true;
            rpTB.Enabled = true;
            ohTB.Enabled = true;
            priceTB.Enabled = true;
            snameTB.Enabled = true;
            deleteBTN.Enabled = false;
            editBTN.Enabled = false;
            saveBTN.Enabled = true;
            newBTN.Enabled = false;
            clearBTN.Enabled = true;
            addBTN.Enabled = false;
        }

        private void prodGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String sql;
            SqlCeCommand comm = new SqlCeCommand();
            SqlCeDataReader reader;

            idTF.Text = this.prodGV.SelectedCells[0].Value.ToString();
            sql = "SELECT * from Product where prodID=" + Convert.ToInt64(idTF.Text);
            comm.Connection = _29thStreet_Cafe_Sales_Inventory_System.Connector.db.getConnection();
            comm.CommandText = sql;

            reader = comm.ExecuteReader();

            reader.Read();
            pnTB.Text = reader.GetString(1);
            priceTB.Text = Convert.ToString(reader.GetDouble(2));
            rpTB.Text = Convert.ToString(reader.GetInt32(3));
            ohTB.Text = Convert.ToString(reader.GetInt32(4));
            snameTB.Text = reader.GetString(5);

            reader.Close();
            comm.Dispose();
            BagO();
        }
        
        private void newBTN_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProdName = pnTB.Text.ToString();
            p.Price = Convert.ToDouble(priceTB.Text);
            p.ReorderPt = Convert.ToInt16(rpTB.Text);
            p.OnHand = Convert.ToInt16(ohTB.Text);
            p.SupName = snameTB.Text.ToString();
            p.Save();
            prodGV.Rows.Clear();
            DisplayProduct();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            Product i = new Product();
            i.ProdID = Convert.ToInt16(prodGV.SelectedCells[0].Value);
            i.ProdName = pnTB.Text.ToString();
            i.Price = Convert.ToDouble(priceTB.Text);
            i.ReorderPt = Convert.ToInt16(rpTB.Text);
            i.OnHand = Convert.ToInt16(ohTB.Text);
            i.SupName = snameTB.Text.ToString();
            i.Edit();
            prodGV.Rows.Clear();
            DisplayProduct();
        }

        public void BagO()
        {
            pnTB.Enabled = false;
            priceTB.Enabled = false;
            rpTB.Enabled = false;
            ohTB.Enabled = false;
            snameTB.Enabled = false;
            clearBTN.Enabled = false;
            newBTN.Enabled = false;
            saveBTN.Enabled = false;
            addBTN.Enabled = true;
            editBTN.Enabled = true;
            deleteBTN.Enabled = true;
        }
    }
}
