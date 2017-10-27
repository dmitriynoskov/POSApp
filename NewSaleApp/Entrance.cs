using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSaleApp
{
    public partial class Entrance : Form
    {
        public Entrance()
        {
            InitializeComponent();
        }

        private void staffIDTxBx_Click(object sender, EventArgs e)
        {

        }

        private void staffIDTxBx_Leave(object sender, EventArgs e)
        {
            if (staffIDTxBx.Text.Trim() != "")
            {
                SaleForm sale = new SaleForm(staffIDTxBx.Text.Trim());
                sale.Show();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AdminForm ad = new AdminForm();
            ad.ShowDialog();
        }
    }
}
