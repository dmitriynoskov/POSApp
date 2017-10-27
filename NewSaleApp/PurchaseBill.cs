using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSaleApp
{
    public partial class PurchaseBill : Form
    {
        AccessToDataLibrary.AccessToDataLibrary accessDL = new AccessToDataLibrary.AccessToDataLibrary();
        int id;
        public PurchaseBill(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void PurchaseBill_Load(object sender, EventArgs e)
        {
            BillDisplay();
        }

        void BillDisplay()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=POSNewDB;Integrated Security=True"))
                {
                    string query = "SELECT * FROM RASHOD WHERE ID=" + id;

                    ReportDocument crys1 = new ReportDocument();

                    string str = "SELECT * FROM RASHODSUB";

                    crys1.Load(@"E:\Проекты\NewSaleApp\NewSaleApp\Reports\Purchase.rpt");

                    crys1.SetDataSource(accessDL.PrintBill(query, "Rashod"));
                    crys1.SetDataSource(accessDL.PrintBill(str, "RashodSub"));

                    crystalReportViewer1.ReportSource = crys1;

                    crystalReportViewer1.RefreshReport();
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
    }
}
