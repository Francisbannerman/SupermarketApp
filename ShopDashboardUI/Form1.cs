using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryUI;


namespace ShopDashboardUI
{
    public partial class shopsMainDashboard : Form
    {
        public shopsMainDashboard()
        {
            InitializeComponent();
        }

        private void inventoryFormButton_Click(object sender, EventArgs e)
        {
            inventoryDashBoard inventoryDashboard = new inventoryDashBoard();
            inventoryDashboard.Show();

        }

        private void clearItemFromCartButton_Click(object sender, EventArgs e)
        {

        }
    }
}
