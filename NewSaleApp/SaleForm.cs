using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace NewSaleApp
{
    /// <summary>
    /// SaleForm
    /// </summary>
    public partial class SaleForm : MetroForm
    {
        AccessToDataLibrary.AccessToDataLibrary _accessDL;

        string _barcode;
        double _quantity;
        int _rashodId;
        decimal _total;
        double _discValue;
        bool _save;
        double _discSum;

        /// <summary>
        /// Штрих код кассира
        /// </summary>
        public string StaffBarcode { get; set; }

        public SaleForm(string staffCode)
        {
            InitializeComponent();

            _accessDL = new AccessToDataLibrary.AccessToDataLibrary();

            StaffBarcode = staffCode;

            _quantity = 0;

            _total = 0M;
            _discSum = 0;

            _save = true;
        }

        private void barcodeTxBx_Leave(object sender, EventArgs e)
        {
            _barcode = barcodeTxBx.Text.Trim();

            if (_barcode == string.Empty && barcodeTxBx.Text.Trim() == string.Empty)
            {
                return;
            }
            else if (barcodeTxBx.Text.Trim()[0] == 'C')
            {
                ClientDefine(_barcode);

                barcodeTxBx.Clear();
                barcodeTxBx.Focus();
            }
            else
            {
                DataSet ds = _accessDL.FindProductByBarcode(_barcode);
                
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Товар не найден!");
                    barcodeTxBx.Clear();
                    barcodeTxBx.Focus();
                }
                else
                {
                    _quantity = 1;

                    quantityTxBx.Text = _quantity.ToString();

                    string id = ds.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
                    string fullName = ds.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
                    decimal price = decimal.Parse(ds.Tables[0].Rows[0].ItemArray.GetValue(8).ToString());
                    decimal discountValue = decimal.Parse(ds.Tables[0].Rows[0].ItemArray.GetValue(13).ToString());
                    decimal priceUpd = price - (price * discountValue / 100);

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["ID"].Value.ToString() == id)
                        {
                            _quantity = double.Parse(row.Cells["Items"].Value.ToString()) + 1;
                            row.Cells["Items"].Value = _quantity;
                            ToPayTxBx.Text = CountTotal().ToString();

                            _accessDL.UpdateQuantity(int.Parse(id), _quantity, decimal.Parse(row.Cells["PriceDisc"].Value.ToString()));

                            barcodeTxBx.Clear();

                            _quantity = 0;

                            return;
                        }
                    }

                    fullNameTxBx.Text = fullName;

                    DataSet ds1 = _accessDL.GroupCheck(id);

                    if (bool.Parse(ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString()))
                    {
                        priceUpd = priceUpd - (priceUpd * decimal.Parse(ds1.Tables[0].Rows[0].ItemArray.GetValue(1).ToString()) / 100);
                    }

                    dataGridView1.Rows.Add(id, fullName, _quantity, price, priceUpd, discountValue);

                    if (bool.Parse(ds1.Tables[0].Rows[0].ItemArray.GetValue(0).ToString()))
                    {
                        AkciyaLbl.Visible = true;
                        dataGridView1.SelectedRows[0].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    _accessDL.quantity = (float)this._quantity;
                    _accessDL.price = priceUpd;

                    if (ClientDiscLbl.Text != "Скидка клиента")
                    {
                        ApplyClientDiscount();
                        ToPayTxBx.Text = CountTotal().ToString();
                    }

                    _accessDL.AddProductToRashod();

                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(_accessDL.CheckSameModel().ToArray());

                    barcodeTxBx.Clear();
                    barcodeTxBx.Focus();

                    _quantity = 0;
                }
            }
        }

        private void ClientDefine(string _barcode)
        {
            DataSet ds = _accessDL.DefineClient(_barcode);
            clientLbl.Text = ds.Tables[0].Rows[0].Field<string>("Name");

            if (ds.Tables[0].Rows[0].Field<bool>("Discount"))
            {
                _discValue = ds.Tables[0].Rows[0].Field<double>("DiscountValue");
                ClientDiscLbl.Text = _discValue.ToString();

                ApplyClientDiscount();
                ToPayTxBx.Text = CountTotal().ToString();
            }
        }

        private void ApplyClientDiscount()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                decimal discountValue = decimal.Parse(row.Cells["Discount"].Value.ToString());

                row.Cells["PriceDisc"].Value = (decimal.Parse(row.Cells["Price"].Value.ToString()) - (decimal.Parse(row.Cells["Price"].Value.ToString()) * discountValue / 100));

                row.Cells["PriceDisc"].Value = decimal.Parse(row.Cells["PriceDisc"].Value.ToString()) - ((decimal)_discValue / 100 * decimal.Parse(row.Cells["PriceDisc"].Value.ToString()));
                _accessDL.UpdateQuantity(int.Parse(row.Cells["ID"].Value.ToString()), double.Parse(row.Cells["Items"].Value.ToString()), decimal.Parse(row.Cells["PriceDisc"].Value.ToString()));
            }
        }

        private decimal CountTotal()
        {
            _total = 0M;
            _discSum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                _total += (decimal.Parse(row.Cells["PriceDisc"].Value.ToString()) * decimal.Parse(row.Cells["Items"].Value.ToString()));
                _discSum += ((double.Parse(row.Cells["Price"].Value.ToString()) * double.Parse(row.Cells["Items"].Value.ToString())) - 
                    (double.Parse(row.Cells["PriceDisc"].Value.ToString()) * double.Parse(row.Cells["Items"].Value.ToString())));
            }

            DiscSumTxBx.Text = _discSum.ToString();
            return _total;
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            this.Text += "     Продавец: " + _accessDL.GetStaffName(StaffBarcode);

            _rashodId = _accessDL.GetRashodID();
            rashodIDTxBx.Text = string.Format("{0:d6}", _rashodId);

            FillTheGrid();

            barcodeTxBx.Focus();
        }

        private void FillTheGrid()
        {
            DataSet ds = _accessDL.ScanRashodSub();

            if (ds.Tables.Count != 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataGridView1.Rows.Add(row.ItemArray.GetValue(6).ToString(), row.ItemArray.GetValue(2).ToString(), row.ItemArray.GetValue(3).ToString(), row.ItemArray.GetValue(5).ToString(), row.ItemArray.GetValue(4).ToString(), row.ItemArray.GetValue(7).ToString());
                }
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
            ToPayTxBx.Text = CountTotal().ToString();
        }

        int _idToRemove;
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            _accessDL.RemoveItemFromRashod(_idToRemove);
            ToPayTxBx.Text = CountTotal().ToString();
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            PaymentForm pay = new PaymentForm();
            pay.Total = _total;
            pay.ID = _rashodId;
            pay.accessDL = this._accessDL;

            if (pay.ShowDialog() == DialogResult.OK)
            {
                _save = false;
                this.Close();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                _idToRemove = int.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());

                dataGridView1.Rows.RemoveAt(row.Index);

                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                fullNameTxBx.Text = dataGridView1.SelectedRows[0].Cells["ItemName"].Value.ToString();
                quantityTxBx.Text = dataGridView1.SelectedRows[0].Cells["Items"].Value.ToString();
            }
            catch
            {
            }
        }

        private void SaleForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
            {
                MaximizeQuantity();

                quantityTxBx.Text = _quantity.ToString();
                dataGridView1.SelectedRows[0].Cells["Items"].Value = _quantity;

                ToPayTxBx.Text = CountTotal().ToString();
            }

            if (e.KeyChar == '-')
            {
                MinimizeQuantity();

                quantityTxBx.Text = _quantity.ToString();
                dataGridView1.SelectedRows[0].Cells["Items"].Value = _quantity;

                ToPayTxBx.Text = CountTotal().ToString();
            }
        }

        private void MinimizeQuantity()
        {
            _quantity = double.Parse(dataGridView1.SelectedRows[0].Cells["Items"].Value.ToString());

            if (_quantity >= 2.0)
            {
                --_quantity;
                _accessDL.ChangeQuantityInRashodSub(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString(), _quantity);
            }
        }

        private void MaximizeQuantity()
        {
            _quantity = double.Parse(dataGridView1.SelectedRows[0].Cells["Items"].Value.ToString());
            ++_quantity;
            _accessDL.ChangeQuantityInRashodSub(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString(), _quantity);
        }

        private void SaleForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void SaleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_save && dataGridView1.Rows.Count > 0)
            {
                _accessDL.SaveSaleToRashod();
            }
        }

        private void encreaseItemsBtn_Click(object sender, EventArgs e)
        {
            MaximizeQuantity();

            quantityTxBx.Text = _quantity.ToString();
            dataGridView1.CurrentRow.Cells["Items"].Value = _quantity;

            ToPayTxBx.Text = CountTotal().ToString();
        }

        private void decreaseQuantityBtn_Click(object sender, EventArgs e)
        {
            MinimizeQuantity();

            quantityTxBx.Text = _quantity.ToString();
            dataGridView1.CurrentRow.Cells["Items"].Value = _quantity;

            ToPayTxBx.Text = CountTotal().ToString();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            retNumber.Visible = !retNumber.Visible;
            if (retNumber.Visible)
            {
                MessageBox.Show("Ввведите номер чека продажи", "Возврат товара");
                retNumber.Focus();
            }
        }

        private void retNumber_Leave(object sender, EventArgs e)
        {
            DataSet ds1 = _accessDL.DefineReturnSale(retNumber.Text.Trim());

            if (ds1.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Чек не найден!");
                ReturnBtn_Click(null, null);
            }
            else
            {
                foreach (DataRow row in ds1.Tables[0].Rows)
                {
                    string id = row.ItemArray.GetValue(1).ToString();
                    string fullName = row.ItemArray.GetValue(2).ToString();
                    int quantity = int.Parse(row.ItemArray.GetValue(4).ToString());
                    decimal price = decimal.Parse(row.ItemArray.GetValue(3).ToString());
                    decimal priceUpd = decimal.Parse(row.ItemArray.GetValue(3).ToString());

                    dataGridView1.Rows.Add(id, fullName, quantity, price, priceUpd);
                }
                

            }
        }

        private void retNumber_TextChanged(object sender, EventArgs e)
        {
        }

        private void retNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
