using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using AccessToDataLibrary;

namespace NewSaleApp
{
    public partial class ProductsForm : MetroForm
    {
        AccessToDataLibrary.AccessToDataLibrary accessDL = new AccessToDataLibrary.AccessToDataLibrary();
        public ProductsForm()
        {
            InitializeComponent();

            dataGridView1.DataSource = accessDL.GetProductList().Tables[0];
        }
    }
}
