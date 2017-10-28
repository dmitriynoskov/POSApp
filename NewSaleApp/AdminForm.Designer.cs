namespace NewSaleApp
{
    partial class AdminForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VisaTxBx = new System.Windows.Forms.TextBox();
            this.NalTxBx = new System.Windows.Forms.TextBox();
            this.ItogTxBx = new System.Windows.Forms.TextBox();
            this.btnSaleReport = new System.Windows.Forms.Button();
            this.btnStaffReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.VisaTxBx);
            this.panel1.Controls.Add(this.NalTxBx);
            this.panel1.Controls.Add(this.ItogTxBx);
            this.panel1.Location = new System.Drawing.Point(35, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 160);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Visa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наличных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Итого";
            // 
            // VisaTxBx
            // 
            this.VisaTxBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisaTxBx.Location = new System.Drawing.Point(219, 95);
            this.VisaTxBx.Multiline = true;
            this.VisaTxBx.Name = "VisaTxBx";
            this.VisaTxBx.ReadOnly = true;
            this.VisaTxBx.Size = new System.Drawing.Size(213, 47);
            this.VisaTxBx.TabIndex = 0;
            this.VisaTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NalTxBx
            // 
            this.NalTxBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NalTxBx.Location = new System.Drawing.Point(3, 95);
            this.NalTxBx.Multiline = true;
            this.NalTxBx.Name = "NalTxBx";
            this.NalTxBx.ReadOnly = true;
            this.NalTxBx.Size = new System.Drawing.Size(213, 47);
            this.NalTxBx.TabIndex = 0;
            this.NalTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItogTxBx
            // 
            this.ItogTxBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItogTxBx.Location = new System.Drawing.Point(179, 15);
            this.ItogTxBx.Multiline = true;
            this.ItogTxBx.Name = "ItogTxBx";
            this.ItogTxBx.ReadOnly = true;
            this.ItogTxBx.Size = new System.Drawing.Size(253, 47);
            this.ItogTxBx.TabIndex = 0;
            this.ItogTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSaleReport
            // 
            this.btnSaleReport.Location = new System.Drawing.Point(509, 116);
            this.btnSaleReport.Name = "btnSaleReport";
            this.btnSaleReport.Size = new System.Drawing.Size(281, 74);
            this.btnSaleReport.TabIndex = 2;
            this.btnSaleReport.Text = "Отчет по продажам за день";
            this.btnSaleReport.UseVisualStyleBackColor = true;
            this.btnSaleReport.Click += new System.EventHandler(this.btnSaleReport_Click);
            // 
            // btnStaffReport
            // 
            this.btnStaffReport.Location = new System.Drawing.Point(509, 202);
            this.btnStaffReport.Name = "btnStaffReport";
            this.btnStaffReport.Size = new System.Drawing.Size(281, 74);
            this.btnStaffReport.TabIndex = 2;
            this.btnStaffReport.Text = "Отчет по продавцам за день";
            this.btnStaffReport.UseVisualStyleBackColor = true;
            this.btnStaffReport.Click += new System.EventHandler(this.btnStaffReport_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 754);
            this.Controls.Add(this.btnStaffReport);
            this.Controls.Add(this.btnSaleReport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VisaTxBx;
        private System.Windows.Forms.TextBox NalTxBx;
        private System.Windows.Forms.TextBox ItogTxBx;
        private System.Windows.Forms.Button btnSaleReport;
        private System.Windows.Forms.Button btnStaffReport;
    }
}