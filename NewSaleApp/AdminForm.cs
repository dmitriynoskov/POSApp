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
    public partial class AdminForm : Form
    {
        AccessToDataLibrary.AccessToDataLibrary accessDL;
        public AdminForm()
        {
            InitializeComponent();
            accessDL = new AccessToDataLibrary.AccessToDataLibrary();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            CountMoney();
        }

        private void CountMoney()
        {
            DataSet ds = accessDL.CountMoney(dateTimePicker1.Value.ToShortDateString());

            if (ds.Tables[0].Rows[0].IsNull(0))
            {
                ItogTxBx.Text = "0";
            }
            else
            {
                ItogTxBx.Text = ds.Tables[0].Rows[0].Field<decimal>("Total").ToString();
            }

            if (ds.Tables[0].Rows[0].IsNull(1))
            {
                NalTxBx.Text = "0";
            }
            else
            {
                NalTxBx.Text = ds.Tables[0].Rows[0].Field<decimal>("Nal").ToString();
            }

            if (ds.Tables[0].Rows[0].IsNull(2))
            {
                VisaTxBx.Text = "0";
            }
            else
            {
                VisaTxBx.Text = ds.Tables[0].Rows[0].Field<decimal>("Visa").ToString();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CountMoney();
        }

        private void btnSaleReport_Click(object sender, EventArgs e)
        {
            ItemsPerDaySale saleRep = new ItemsPerDaySale(dateTimePicker1.Value.ToShortDateString());
            saleRep.ShowDialog();
        }
    }
}
