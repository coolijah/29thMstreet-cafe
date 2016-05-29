using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _29thStreet_Cafe_Sales_Inventory_System
{
    public partial class _29thStreetCafeMDI : Form
    {
        public _29thStreetCafeMDI()
        {
            InitializeComponent();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm u = new UserForm();
            u.MdiParent = this;
            u.Dock = DockStyle.Fill;
            u.Show();
        }

        private void ingredientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngredientsForm ch = new IngredientsForm();
            ch.MdiParent = this;
            ch.Dock = DockStyle.Fill;
            ch.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm p = new ProductForm();
            p.MdiParent = this;
            p.Dock = DockStyle.Fill;
            p.Show();
        }

        private void _29thStreetCafeMDI_Load(object sender, EventArgs e)
        {

        }

    }
}
