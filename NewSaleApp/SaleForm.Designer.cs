namespace NewSaleApp
{
    partial class SaleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceDisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeTxBx = new MetroFramework.Controls.MetroTextBox();
            this.quantityTxBx = new MetroFramework.Controls.MetroTextBox();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rashodIDTxBx = new MetroFramework.Controls.MetroTextBox();
            this.ToPayTxBx = new MetroFramework.Controls.MetroTextBox();
            this.PayBtn = new MetroFramework.Controls.MetroButton();
            this.clientLbl = new MetroFramework.Controls.MetroLabel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.ClientDiscLbl = new MetroFramework.Controls.MetroLabel();
            this.fullNameTxBx = new MetroFramework.Controls.MetroTextBox();
            this.encreaseItemsBtn = new MetroFramework.Controls.MetroButton();
            this.decreaseQuantityBtn = new MetroFramework.Controls.MetroButton();
            this.DiscSumTxBx = new MetroFramework.Controls.MetroTextBox();
            this.ReturnBtn = new MetroFramework.Controls.MetroButton();
            this.AkciyaLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ItemName,
            this.Items,
            this.Price,
            this.PriceDisc,
            this.Discount});
            this.dataGridView1.Location = new System.Drawing.Point(24, 284);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 420);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaleForm_KeyPress);
            // 
            // ID
            // 
            this.ID.HeaderText = "ProdID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ItemName
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ItemName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ItemName.HeaderText = "Наименование";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemName.Width = 400;
            // 
            // Items
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Items.DefaultCellStyle = dataGridViewCellStyle3;
            this.Items.HeaderText = "Кол-во";
            this.Items.Name = "Items";
            this.Items.ReadOnly = true;
            this.Items.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Price
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Price.DefaultCellStyle = dataGridViewCellStyle4;
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.Width = 140;
            // 
            // PriceDisc
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.PriceDisc.DefaultCellStyle = dataGridViewCellStyle5;
            this.PriceDisc.HeaderText = "Цена со скидкой";
            this.PriceDisc.Name = "PriceDisc";
            this.PriceDisc.ReadOnly = true;
            this.PriceDisc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PriceDisc.Width = 140;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Скидка";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Visible = false;
            // 
            // barcodeTxBx
            // 
            this.barcodeTxBx.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.barcodeTxBx.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.barcodeTxBx.Location = new System.Drawing.Point(24, 133);
            this.barcodeTxBx.Name = "barcodeTxBx";
            this.barcodeTxBx.PromptText = "Barcode";
            this.barcodeTxBx.Size = new System.Drawing.Size(357, 46);
            this.barcodeTxBx.TabIndex = 0;
            this.barcodeTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.barcodeTxBx.Leave += new System.EventHandler(this.barcodeTxBx_Leave);
            // 
            // quantityTxBx
            // 
            this.quantityTxBx.Enabled = false;
            this.quantityTxBx.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.quantityTxBx.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.quantityTxBx.Location = new System.Drawing.Point(640, 198);
            this.quantityTxBx.Name = "quantityTxBx";
            this.quantityTxBx.Size = new System.Drawing.Size(135, 46);
            this.quantityTxBx.TabIndex = 1;
            this.quantityTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Наименование";
            this.FullName.Name = "FullName";
            this.FullName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FullName.Width = 400;
            // 
            // rashodIDTxBx
            // 
            this.rashodIDTxBx.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.rashodIDTxBx.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.rashodIDTxBx.Location = new System.Drawing.Point(24, 63);
            this.rashodIDTxBx.Name = "rashodIDTxBx";
            this.rashodIDTxBx.ReadOnly = true;
            this.rashodIDTxBx.Size = new System.Drawing.Size(133, 46);
            this.rashodIDTxBx.TabIndex = 0;
            this.rashodIDTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rashodIDTxBx.Leave += new System.EventHandler(this.barcodeTxBx_Leave);
            // 
            // ToPayTxBx
            // 
            this.ToPayTxBx.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ToPayTxBx.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.ToPayTxBx.Location = new System.Drawing.Point(787, 198);
            this.ToPayTxBx.Multiline = true;
            this.ToPayTxBx.Name = "ToPayTxBx";
            this.ToPayTxBx.PromptText = "К ОПЛАТЕ";
            this.ToPayTxBx.ReadOnly = true;
            this.ToPayTxBx.Size = new System.Drawing.Size(274, 46);
            this.ToPayTxBx.TabIndex = 3;
            this.ToPayTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PayBtn
            // 
            this.PayBtn.Location = new System.Drawing.Point(905, 746);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(156, 73);
            this.PayBtn.TabIndex = 4;
            this.PayBtn.Text = "Оплатить";
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // clientLbl
            // 
            this.clientLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.clientLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.clientLbl.Location = new System.Drawing.Point(24, 721);
            this.clientLbl.Name = "clientLbl";
            this.clientLbl.Size = new System.Drawing.Size(191, 37);
            this.clientLbl.TabIndex = 5;
            this.clientLbl.Text = "Клиент";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(508, 761);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(83, 58);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "X";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ClientDiscLbl
            // 
            this.ClientDiscLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ClientDiscLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ClientDiscLbl.Location = new System.Drawing.Point(787, 721);
            this.ClientDiscLbl.Name = "ClientDiscLbl";
            this.ClientDiscLbl.Size = new System.Drawing.Size(274, 37);
            this.ClientDiscLbl.TabIndex = 5;
            this.ClientDiscLbl.Text = "Скидка клиента";
            // 
            // fullNameTxBx
            // 
            this.fullNameTxBx.Enabled = false;
            this.fullNameTxBx.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.fullNameTxBx.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.fullNameTxBx.Location = new System.Drawing.Point(24, 198);
            this.fullNameTxBx.Name = "fullNameTxBx";
            this.fullNameTxBx.PromptText = "Наименование";
            this.fullNameTxBx.ReadOnly = true;
            this.fullNameTxBx.Size = new System.Drawing.Size(606, 46);
            this.fullNameTxBx.TabIndex = 0;
            this.fullNameTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fullNameTxBx.Leave += new System.EventHandler(this.barcodeTxBx_Leave);
            // 
            // encreaseItemsBtn
            // 
            this.encreaseItemsBtn.Location = new System.Drawing.Point(302, 761);
            this.encreaseItemsBtn.Name = "encreaseItemsBtn";
            this.encreaseItemsBtn.Size = new System.Drawing.Size(79, 58);
            this.encreaseItemsBtn.TabIndex = 4;
            this.encreaseItemsBtn.Text = "Увеличить кол-во (кнопка +)";
            this.encreaseItemsBtn.Click += new System.EventHandler(this.encreaseItemsBtn_Click);
            // 
            // decreaseQuantityBtn
            // 
            this.decreaseQuantityBtn.Location = new System.Drawing.Point(405, 761);
            this.decreaseQuantityBtn.Name = "decreaseQuantityBtn";
            this.decreaseQuantityBtn.Size = new System.Drawing.Size(79, 58);
            this.decreaseQuantityBtn.TabIndex = 4;
            this.decreaseQuantityBtn.Text = "Уменьшить кол-во (кнопка -)";
            this.decreaseQuantityBtn.Click += new System.EventHandler(this.decreaseQuantityBtn_Click);
            // 
            // DiscSumTxBx
            // 
            this.DiscSumTxBx.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.DiscSumTxBx.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.DiscSumTxBx.Location = new System.Drawing.Point(788, 132);
            this.DiscSumTxBx.Multiline = true;
            this.DiscSumTxBx.Name = "DiscSumTxBx";
            this.DiscSumTxBx.PromptText = "Сумма скидки";
            this.DiscSumTxBx.ReadOnly = true;
            this.DiscSumTxBx.Size = new System.Drawing.Size(274, 46);
            this.DiscSumTxBx.TabIndex = 3;
            this.DiscSumTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(200, 761);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(79, 58);
            this.ReturnBtn.TabIndex = 4;
            this.ReturnBtn.Text = "Возврат";
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // AkciyaLbl
            // 
            this.AkciyaLbl.BackColor = System.Drawing.Color.Yellow;
            this.AkciyaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.AkciyaLbl.ForeColor = System.Drawing.Color.Red;
            this.AkciyaLbl.Location = new System.Drawing.Point(449, 111);
            this.AkciyaLbl.Name = "AkciyaLbl";
            this.AkciyaLbl.Size = new System.Drawing.Size(297, 67);
            this.AkciyaLbl.TabIndex = 7;
            this.AkciyaLbl.Text = "АКЦИЯ!!!";
            this.AkciyaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AkciyaLbl.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(1096, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 420);
            this.panel1.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(24, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(372, 352);
            this.listBox1.TabIndex = 0;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 832);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AkciyaLbl);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.ClientDiscLbl);
            this.Controls.Add(this.clientLbl);
            this.Controls.Add(this.decreaseQuantityBtn);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.encreaseItemsBtn);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.DiscSumTxBx);
            this.Controls.Add(this.ToPayTxBx);
            this.Controls.Add(this.quantityTxBx);
            this.Controls.Add(this.fullNameTxBx);
            this.Controls.Add(this.rashodIDTxBx);
            this.Controls.Add(this.barcodeTxBx);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SaleForm";
            this.Text = "Продажа товара";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaleForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SaleForm_FormClosed);
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaleForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox barcodeTxBx;
        private MetroFramework.Controls.MetroTextBox quantityTxBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private MetroFramework.Controls.MetroTextBox rashodIDTxBx;
        private MetroFramework.Controls.MetroTextBox ToPayTxBx;
        private MetroFramework.Controls.MetroButton PayBtn;
        private MetroFramework.Controls.MetroLabel clientLbl;
        private System.Windows.Forms.Button deleteBtn;
        private MetroFramework.Controls.MetroLabel ClientDiscLbl;
        private MetroFramework.Controls.MetroTextBox fullNameTxBx;
        private MetroFramework.Controls.MetroButton encreaseItemsBtn;
        private MetroFramework.Controls.MetroButton decreaseQuantityBtn;
        private MetroFramework.Controls.MetroTextBox DiscSumTxBx;
        private MetroFramework.Controls.MetroButton ReturnBtn;
        private System.Windows.Forms.Label AkciyaLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceDisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
    }
}