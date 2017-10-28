using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewSaleApp.Reports;

namespace NewSaleApp
{
    public partial class StaffSaleReport : Form
    {
        private string _rashodDate;
        public StaffSaleReport(string date)
        {
            InitializeComponent();
            _rashodDate = date;
        }

        private void StaffSaleReport_Load(object sender, EventArgs e)
        {
            BillDisplay();
        }

        private void BillDisplay()
        {
            try
            {
                StaffReport rep = new StaffReport();
                rep.SetParameterValue("Date", _rashodDate);
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
