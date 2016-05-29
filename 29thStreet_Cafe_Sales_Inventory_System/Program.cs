using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _29thStreet_Cafe_Sales_Inventory_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _29thStreet_Cafe_Sales_Inventory_System.Connector.db.connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new _29thStreetCafeMDI());
        }
    }
}
