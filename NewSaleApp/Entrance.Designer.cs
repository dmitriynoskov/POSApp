namespace NewSaleApp
{
    partial class Entrance
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
            this.staffIDTxBx = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // staffIDTxBx
            // 
            this.staffIDTxBx.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.staffIDTxBx.Location = new System.Drawing.Point(148, 89);
            this.staffIDTxBx.Name = "staffIDTxBx";
            this.staffIDTxBx.Size = new System.Drawing.Size(258, 89);
            this.staffIDTxBx.TabIndex = 0;
            this.staffIDTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.staffIDTxBx.Click += new System.EventHandler(this.staffIDTxBx_Click);
            this.staffIDTxBx.Leave += new System.EventHandler(this.staffIDTxBx_Leave);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(179, 206);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(143, 33);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "metroButton1";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(12, 21);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(85, 53);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Admin";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 316);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.staffIDTxBx);
            this.Name = "Entrance";
            this.Text = "Entrance";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox staffIDTxBx;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}