using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Common;

namespace Provider
{
    public class DProvider
    {
        public string conString = ConfigurationSettings.AppSettings["conString"];

        NewSaleAppDS shopDS = new NewSaleAppDS();

    }
}
