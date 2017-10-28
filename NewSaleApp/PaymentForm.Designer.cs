namespace NewSaleApp
{
    partial class PaymentForm
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
            this.totalTxBx = new MetroFramework.Controls.MetroTextBox();
            this.ReceivedSumTxBx = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.ChangeTxBx = new MetroFramework.Controls.MetroTextBox();
            this.VisaChBx = new MetroFramework.Controls.MetroCheckBox();
            this.VisaTxBx = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // totalTxBx
            // 
            this.totalTxBx.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.totalTxBx.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.totalTxBx.Location = new System.Drawing.Point(114, 88);
            this.totalTxBx.Multiline = true;
            this.totalTxBx.Name = "totalTxBx";
            this.totalTxBx.Size = new System.Drawing.Size(259, 74);
            this.totalTxBx.TabIndex = 3;
            this.totalTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReceivedSumTxBx
            // 
            this.ReceivedSumTxBx.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ReceivedSumTxBx.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.ReceivedSumTxBx.Location = new System.Drawing.Point(114, 202);
            this.ReceivedSumTxBx.Multiline = true;
            this.ReceivedSumTxBx.Name = "ReceivedSumTxBx";
            this.ReceivedSumTxBx.Size = new System.Drawing.Size(259, 74);
            this.ReceivedSumTxBx.TabIndex = 0;
            this.ReceivedSumTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReceivedSumTxBx.Leave += new System.EventHandler(this.ReceivedSumTxBx_Leave);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(171, 417);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(134, 92);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "ОПЛАТИТЬ";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Visible = false;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // ChangeTxBx
            // 
            this.ChangeTxBx.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ChangeTxBx.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.ChangeTxBx.Location = new System.Drawing.Point(114, 321);
            this.ChangeTxBx.Multiline = true;
            this.ChangeTxBx.Name = "ChangeTxBx";
            this.ChangeTxBx.ReadOnly = true;
            this.ChangeTxBx.Size = new System.Drawing.Size(259, 74);
            this.ChangeTxBx.TabIndex = 2;
            this.ChangeTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VisaChBx
            // 
            this.VisaChBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisaChBx.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.VisaChBx.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.VisaChBx.Location = new System.Drawing.Point(38, 30);
            this.VisaChBx.Name = "VisaChBx";
            this.VisaChBx.Size = new System.Drawing.Size(104, 34);
            this.VisaChBx.TabIndex = 4;
            this.VisaChBx.Text = "Visa";
            this.VisaChBx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VisaChBx.UseVisualStyleBackColor = true;
            this.VisaChBx.CheckedChanged += new System.EventHandler(this.VisaChBx_CheckedChanged);
            // 
            // VisaTxBx
            // 
            this.VisaTxBx.Location = new System.Drawing.Point(171, 41);
            this.VisaTxBx.Mask = "0000";
            this.VisaTxBx.Name = "VisaTxBx";
            this.VisaTxBx.Size = new System.Drawing.Size(100, 22);
            this.VisaTxBx.TabIndex = 5;
            this.VisaTxBx.Visible = false;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 545);
            this.Controls.Add(this.VisaTxBx);
            this.Controls.Add(this.VisaChBx);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.ChangeTxBx);
            this.Controls.Add(this.ReceivedSumTxBx);
            this.Controls.Add(this.totalTxBx);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaymentForm_FormClosed);
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox totalTxBx;
        private MetroFramework.Controls.MetroTextBox ReceivedSumTxBx;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox ChangeTxBx;
        private MetroFramework.Controls.MetroCheckBox VisaChBx;
        private System.Windows.Forms.MaskedTextBox VisaTxBx;
    }
}