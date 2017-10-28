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
    public partial class PaymentForm : Form
    {
        public decimal Total { get; set; }
        public int ID { get; set; }

        public AccessToDataLibrary.AccessToDataLibrary accessDL { get; set; }

        public PaymentForm()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (VisaChBx.Checked)
            {
                accessDL.Visa = VisaTxBx.Text;
                accessDL.MoneyRec = 0M;
                accessDL.Nal = false;
            }
            else
            {
                accessDL.Visa = "Null";
                accessDL.Nal = true;
                accessDL.MoneyRec = decimal.Parse(ReceivedSumTxBx.Text.Trim());
            }

            accessDL.PerformSale();
            PurchaseBill bill = new PurchaseBill(ID);
            bill.ShowDialog();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            totalTxBx.Text = Total.ToString();
        }

        private void ReceivedSumTxBx_Leave(object sender, EventArgs e)
        {
            if (ReceivedSumTxBx.Text.Trim() == string.Empty)
            {
                return;
            }

            if (decimal.Parse(ReceivedSumTxBx.Text.Trim()) - Total < 0M)
            {
                MessageBox.Show("Недостачная сумма для оплаты!");
                return;
            }
            else
            {
                ChangeTxBx.Text = (decimal.Parse(ReceivedSumTxBx.Text.Trim()) - Total).ToString();
                metroTile1.Visible = true;
            }
        }

        private void VisaChBx_CheckedChanged(object sender, EventArgs e)
        {
            if (VisaChBx.Checked)
            {
                accessDL.Nal = false;
                VisaTxBx.Visible = true;
                metroTile1.Visible = true;
                ReceivedSumTxBx.Enabled = false;
            }
            else
            {
                accessDL.Nal = true;
                VisaTxBx.Visible = false;
                VisaTxBx.Text = "";
                ReceivedSumTxBx.Enabled = true;
                metroTile1.Visible = false;
            }
        }

        private void PaymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {

            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
