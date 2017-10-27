using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using NewSaleApp.Reports;


namespace NewSaleApp
{
    public partial class ItemsPerDaySale : Form
    {
        private string rashodDate;

        public ItemsPerDaySale(string date)
        {
            InitializeComponent();
            rashodDate = date;
        }

        private void ItemsPerDaySale_Load(object sender, EventArgs e)
        {
            BillDisplay();
        }

        private void BillDisplay()
        {
            try
            {
                ItemsPerDay rep = new ItemsPerDay();
                rep.SetParameterValue("Date", rashodDate);
                crystalReportViewer1.ReportSource = rep;
                crystalReportViewer1.Refresh();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
