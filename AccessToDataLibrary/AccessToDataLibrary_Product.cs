using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessToDataLibrary
{
    public partial class AccessToDataLibrary
    {
        public DataSet GetProductList()
        {
            string query = "SELECT * FROM PRODUCT";

            SqlConnection con = new SqlConnection(provider.conString);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds);

            return ds;
        }
    }
}
